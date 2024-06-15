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
    public class CommonFunctions
    {
        public static List<string> GenerateCharacters()
        {
            var Directories = Directory.EnumerateDirectories(Properties.Settings.Default.GameDocumentsDirectory);
            List<string> Characters = new List<string>();
            foreach (string directory in Directories)
            {
                if (directory.IndexOf("FFXIV_CHR") != -1)
                {
                    Characters.Add(directory.Substring(Properties.Settings.Default.GameDocumentsDirectory.Length + 1));
                }
            }
            return Characters;
        }
        public static bool IsLinked(string file1, string file2)
        {
            
            if (File.Exists(file1) && File.Exists(file2))
            {
                FileStream f1 = null;
                FileStream f2 = null;
                f1 = new FileStream(file1, FileMode.Open, FileAccess.Read);
                f2 = new FileStream(file2, FileMode.Open, FileAccess.Read);
                while (true)
                {
                    int f1byte = f1.ReadByte();
                    int f2byte = f2.ReadByte();
                    if (f1byte != f2byte)
                    {
                        f1.Close();
                        f2.Close();
                        return false;
                    }
                    else if (f1byte == -1 && f2byte == -1)
                    {
                        f1.Close();
                        f2.Close();
                        return true;
                    }

                }
            }
            
            return false;


        }

    }
    
}
