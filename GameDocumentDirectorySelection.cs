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
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                Properties.Settings.Default.GameDocumentsDirectory = folderBrowserDialog1.SelectedPath;
                Properties.Settings.Default.Save();
                Application.Restart();
            }
        }
    }
}
