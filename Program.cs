using System.Security.Cryptography.X509Certificates;

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
            if (Directory.Exists(Properties.Settings.Default.GameDocumentsDirectory))
            {
                Application.Run(new SyncSetup());
            } else
            {
                Application.Run(new GameDocumentDirectorySelection());
            }
            
        }
    }
}