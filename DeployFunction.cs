using FFXIV_Character_Linker.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace FFXIV_Character_Linker
{
    public class DeployFunction
    {
        
        public static void Deploy()
        {
            static void LinkFile(string file1Dir, string file1Name)
            {
                string SourcePath = Properties.Settings.Default.GameDocumentsDirectory + "\\" + Properties.Settings.Default.SelectedMaster + "\\" + file1Name;
                if (CommonFunctions.IsLinked(SourcePath) == false)
                {
                    if (File.Exists(file1Dir + file1Name))
                    {
                        if (Directory.Exists(file1Dir + "\\Backup\\") == false)
                        {
                            Directory.CreateDirectory(file1Dir + "\\Backup\\");
                        }
                        File.Move(file1Dir + file1Name, file1Dir + "\\Backup\\" + file1Name);
                    }

                    try { File.CreateSymbolicLink(file1Dir + file1Name, SourcePath); }
                    catch (ArgumentException e) { MessageBox.Show("Exception:" + e.Message); }
                } else { MessageBox.Show("The source character's "+file1Name+" is already a link. Aborting link."); }
                

            }
            static void UnLinkFile(string file1Dir, string file1Name)
            {
                if (CommonFunctions.IsLinked(file1Dir + file1Name))
                {
                    if (File.Exists(file1Dir + "\\Backup\\" + file1Name))
                    {
                        File.Delete(file1Dir + file1Name);
                        File.Move(file1Dir + "\\Backup\\" + file1Name, file1Dir + file1Name);
                    }
                    else
                    {
                        MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                        DialogResult result = MessageBox.Show("Could not locate backup for " + file1Name + ", continue removal?", "FFXIV Settings Linker", buttons);
                        if (result == System.Windows.Forms.DialogResult.Yes)
                            File.Delete(file1Dir + file1Name);
                    }
                }
            }

            Array Links = System.IO.File.ReadAllLines("LinkOps.txt");
            Array Unlinks = System.IO.File.ReadAllLines("UnLinkOps.txt");

            foreach (var Link in Links)
            {
                if (Link.ToString() != "" && Link != null)
                {
                    string file = Link.ToString().Substring(FFXIV_Character_Linker.Properties.Settings.Default.GameDocumentsDirectory.Length + 1);
                    file = file.Substring(file.IndexOf("\\") + 1);
                    string dir = Link.ToString().Substring(0, Link.ToString().Length - file.Length);
                    LinkFile(dir, file);
                }
            }
            foreach (var Link in Unlinks)
            {
                if (Link.ToString() != "" && Link != null)
                {
                    string file = Link.ToString().Substring(FFXIV_Character_Linker.Properties.Settings.Default.GameDocumentsDirectory.Length + 1);
                    file = file.Substring(file.IndexOf("\\") + 1);
                    string dir = Link.ToString().Substring(0, Link.ToString().Length - file.Length);
                    UnLinkFile(dir, file);
                }
            }
            File.Delete("LinkOps.txt");
            File.Delete("UnLinkOps.txt");
        }

    }
    
}
