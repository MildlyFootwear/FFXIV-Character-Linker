using FFXIV_Character_Linker.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
        public static bool IsLinked(string file1)
        {
            
            if (File.Exists(file1))
            {
                FileInfo pathInfo = new FileInfo(file1);
                return pathInfo.Attributes.HasFlag(FileAttributes.ReparsePoint);
            }
            
            return false;


        }
        public static bool ValidMaster(string character)
        {
            string characterPath = Settings.Default.GameDocumentsDirectory + "\\" + character + "\\";
            foreach (string linkable in Variables.linkables)
            {
                if (CommonFunctions.IsLinked(characterPath + linkable))
                {
                    return false;
                }
            }
            return true;
        }

    }
    
}
