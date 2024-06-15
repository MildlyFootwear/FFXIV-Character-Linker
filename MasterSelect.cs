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
            int Width = 0;
            int Height = 0;
            Button dummy = new Button();
            tableLayoutPanel1.Controls.Add(dummy, 0, 0);
            foreach (string character in CommonFunctions.GenerateCharacters())
            {
                dummy.Text = character;
                dummy.AutoSize = true;
                if (dummy.Width > Width)
                    Width = dummy.Width;
                if (dummy.Height > Height)
                    Height = dummy.Height;
            }
            tableLayoutPanel1.Controls.Remove(dummy);
            int row = 0;
            foreach (string character in CommonFunctions.GenerateCharacters())
            {

                void SelectCharacter(object sender, EventArgs e)
                {
                    Properties.Settings.Default.SelectedMaster = character;
                    Properties.Settings.Default.Save();
                    Application.Restart();
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
