using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using System.Security.Principal;
using FFXIV_Character_Linker.Properties;

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

            if (Settings.Default.NeedToDeploy && (new WindowsPrincipal(WindowsIdentity.GetCurrent())).IsInRole(WindowsBuiltInRole.Administrator))
            {

                DeployFunction.Deploy();
                Settings.Default.NeedToDeploy = false;
                Settings.Default.Save();
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