using FFXIV_Character_Linker.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFXIV_Character_Linker
{
    public partial class MasterSelect : Form
    {
        public MasterSelect()
        {
            InitializeComponent();
            List<string> characters = CommonFunctions.GenerateCharacters();
            string settingsdir = Settings.Default.GameDocumentsDirectory;
            int Width = 0;
            int Height = 0;
            Button dummy = new Button();
            tableLayoutPanel1.Controls.Add(dummy, 0, 0);
            foreach (string character in characters)
            {
                dummy.Text = character;
                dummy.AutoSize = true;
                if (dummy.Width > Width)
                    Width = dummy.Width;
                if (dummy.Height > Height)
                    Height = dummy.Height;
            }
            tableLayoutPanel1.Controls.Remove(dummy);
            long timestamp = 0;
            string latest = "";
            foreach (string character in characters)
            {
                string chardirectory = settingsdir +"\\"+ character+"\\";
                if (CommonFunctions.ValidMaster(character))
                {
                    foreach (string linkable in Variables.linkables)
                    {
                        if (File.Exists(chardirectory + linkable))
                        {
                            DateTime stamp = System.IO.File.GetLastWriteTime(chardirectory + linkable);
                            if (stamp.Ticks > timestamp)
                            {
                                timestamp = stamp.Ticks;
                                latest = character;
                            }
                        }
                    }
                }
                
            }

            Button latestbutton = new Button();
            latestbutton.Text = "Last Modified";
            latestbutton.Width = Width;
            latestbutton.Height = Height;
            void SelectLatest(object sender, EventArgs e) 
            {
                Properties.Settings.Default.SelectedMaster = latest;
                Properties.Settings.Default.Save();
                Application.Restart();
            }
            latestbutton.Click += SelectLatest;
            latestbutton.Anchor = AnchorStyles.Top;
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(latestbutton, "Will select "+latest+" as the source, since it is the most recently modified.");

            tableLayoutPanel1.Controls.Add(latestbutton, 0, 0);

            int row = 1;

            foreach (string character in characters)
            {

                void SelectCharacter(object sender, EventArgs e)
                {

                    if (CommonFunctions.ValidMaster(character)) 
                    {
                        Properties.Settings.Default.SelectedMaster = character;
                        Properties.Settings.Default.Save();
                        Application.Restart();
                    } else { MessageBox.Show("Can't select " +character+" as a source as there are linked files present in their directory."); }
                    
                }
                Button button = new Button();
                button.Text = character;
                button.Width = Width;
                button.Height = Height;
                button.Click += SelectCharacter;
                button.Anchor = AnchorStyles.Top;
                
                tableLayoutPanel1.Controls.Add(button, 0, row);
                row++;

            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MasterSelect_Load(object sender, EventArgs e)
        {

        }
    }

}
