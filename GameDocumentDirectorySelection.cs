using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFXIV_Character_Linker
{
    public partial class GameDocumentDirectorySelection : Form
    {
        public GameDocumentDirectorySelection()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(Environment.GetEnvironmentVariable("HOMEPATH")+ "\\Documents\\My Games\\FINAL FANTASY XIV - A Realm Reborn"))
            {
                folderBrowserDialog1.InitialDirectory = Environment.GetEnvironmentVariable("HOMEPATH") + "\\Documents\\My Games\\FINAL FANTASY XIV - A Realm Reborn";
            }
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Properties.Settings.Default.GameDocumentsDirectory = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.SelectedMaster = "Blank";
                Properties.Settings.Default.Save();
                Application.Restart();
            }
        }

        private void GameDocumentDirectorySelection_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
