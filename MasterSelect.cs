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
    public partial class MasterSelect : Form
    {
        public MasterSelect()
        {
            InitializeComponent();
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
                button.Width = 375;
                button.Height = 40;
                button.Click += SelectCharacter;
                flowLayoutPanel1.Controls.Add(button);
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
