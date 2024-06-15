using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Security.Principal;

namespace FFXIV_Character_Linker
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            if (File.Exists("LinkOps.txt") && (new WindowsPrincipal(WindowsIdentity.GetCurrent())).IsInRole(WindowsBuiltInRole.Administrator))
            {

                static void LinkFile(string file1Dir, string file1Name)
                {

                    if (File.Exists(file1Dir + file1Name))
                    {
                        if (Directory.Exists(file1Dir + "\\Backup\\") == false)
                        {
                            Directory.CreateDirectory(file1Dir + "\\Backup\\");
                        }
                        File.Move(file1Dir + file1Name, file1Dir + "\\Backup\\" + file1Name);
                    }

                    try { File.CreateSymbolicLink(file1Dir + file1Name, Properties.Settings.Default.GameDocumentsDirectory + "\\" + Properties.Settings.Default.SelectedMaster + "\\" + file1Name); }
                    catch(ArgumentException e) { MessageBox.Show("Exception:"+e.Message); }

                }
                static void UnLinkFile(string file1Dir, string file1Name)
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
            else {

                File.Delete("LinkOps.txt");
                File.Delete("UnLinkOps.txt");
                if (Directory.Exists(Properties.Settings.Default.GameDocumentsDirectory) == false)
                {

                    Application.Run(new GameDocumentDirectorySelection());

                }
                else
                {
                    if (Properties.Settings.Default.SelectedMaster == "Blank")
                    {
                        Application.Run(new MasterSelect());
                    }
                    else
                    {
                        Application.Run(new SyncControl());
                    }
                }

            }
            


        }
    }
}