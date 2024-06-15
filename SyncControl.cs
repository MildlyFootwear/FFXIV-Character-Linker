using FFXIV_Character_Linker.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Permissions;
using System.Security.Principal;
using System.Diagnostics;

namespace FFXIV_Character_Linker
{
    public partial class SyncControl : Form
    {
        List<string> characters = CommonFunctions.GenerateCharacters();
        List<string> LinkOps = new List<string>();
        List<string> UnLinkOps = new List<string>();
        List<string> linkables = Variables.linkables;

        public SyncControl()
        {
            InitializeComponent();

            SelectedSource.Text = "Selected source: " + Settings.Default.SelectedMaster;
            DirectoryLabel.Text = "Settings directory: " + Settings.Default.GameDocumentsDirectory;

            int row = 0;
            string MasterPath = Settings.Default.GameDocumentsDirectory + "\\" + Settings.Default.SelectedMaster + "\\";
            foreach (string str in characters)
            {
                if (str != Settings.Default.SelectedMaster)
                {
                    string ActivePath = Settings.Default.GameDocumentsDirectory + "\\" + str + "\\";
                    row++;
                    Label CharacterName = new Label();
                    CharacterName.Name = str;
                    CharacterName.Text = str;
                    CharacterName.AutoSize = true;
                    tableLayoutPanel1.Controls.Add(CharacterName, 0, row);

                    int column = 0;
                    foreach (string linkable in linkables)
                    {
                        column++;
                        CheckBox box = new CheckBox();
                        box.Name = linkable;
                        box.AutoSize = true;
                        box.Anchor = AnchorStyles.Top;
                        if (CommonFunctions.IsLinked(ActivePath + linkable))
                        {
                            box.Checked = true;
                        }
                        void check(object sender, EventArgs e)
                        {
                            if (File.Exists(MasterPath + linkable))
                            {

                                string file = ActivePath + linkable;
                                if (box.Checked)
                                {
                                    if (UnLinkOps.Remove(file) == false)
                                    {
                                        LinkOps.Add(file);
                                    }
                                }
                                else
                                {
                                    if (LinkOps.Remove(file) == false)
                                    {
                                        UnLinkOps.Add(file);
                                    }
                                }
                            }
                            else { MessageBox.Show("Could not find " + linkable + "for the source character."); box.Checked = false; }
                        }
                        box.Click += check;
                        tableLayoutPanel1.Controls.Add(box, column, row);
                    }

                }

            }
        }

        private void LinkButton_Click(object sender, EventArgs e)
        {

            Settings.Default.NeedToDeploy = true;
            Settings.Default.Save();

            File.Delete("LinkOps.txt");
            File.Delete("UnLinkOps.txt");

            System.IO.File.WriteAllLines("LinkOps.txt", LinkOps);
            System.IO.File.WriteAllLines("UnLinkOps.txt", UnLinkOps);

            Array Links = System.IO.File.ReadAllLines("LinkOps.txt");
            Array Unlinks = System.IO.File.ReadAllLines("UnLinkOps.txt");

            Thread.Sleep(100);

            Process proc = new Process();
            proc.StartInfo.FileName = "FFXIV Character Linker.exe";
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.Verb = "runas";

            MessageBox.Show("Admin permission will be requested to deploy files.");

            proc.Start();
            proc.WaitForExit();


            Application.Restart();

        }

        private void OnClose(object sender, FormClosingEventArgs e)
        {
            Settings.Default.SyncControlPosition = this.Location;
            Settings.Default.Save();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            this.Location = Settings.Default.SyncControlPosition;
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LinkOps.Clear();
            UnLinkOps.Clear();
            foreach (string character in CommonFunctions.GenerateCharacters())
            {
                foreach (string linkable in linkables)
                {
                    UnLinkOps.Add(Settings.Default.GameDocumentsDirectory + "\\" + character + "\\" + linkable);
                }
            }

            Settings.Default.NeedToDeploy = true;
            Settings.Default.Save();

            File.Delete("LinkOps.txt");
            File.Delete("UnLinkOps.txt");

            System.IO.File.WriteAllLines("LinkOps.txt", LinkOps);
            System.IO.File.WriteAllLines("UnLinkOps.txt", UnLinkOps);

            Array Links = System.IO.File.ReadAllLines("LinkOps.txt");
            Array Unlinks = System.IO.File.ReadAllLines("UnLinkOps.txt");

            Thread.Sleep(100);

            Process proc = new Process();
            proc.StartInfo.FileName = "FFXIV Character Linker.exe";
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.Verb = "runas";

            MessageBox.Show("Admin permission will be requested to reset files.");

            proc.Start();
            proc.WaitForExit();

            Settings.Default.Reset();
            Settings.Default.Save();
            Application.Restart();
        }

        private void UILabel_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.UILabel, "Contains HUD layout.");
        }

        private void HotbarLabel_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.HotbarLabel, "Contains hotbar settings.");
        }

        private void KeybindLabel_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.KeybindLabel, "Contains keybinds.");
        }

        private void GaugeLabel_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.GaugeLabel, "Contains job gauge settings.");
        }

        private void MacrosLabel_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.MacrosLabel, "Contains character specific macros.");
        }

        private void ChatFiltersLabel_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.ChatFiltersLabel, "Contains filters for the chat window.");
        }

        private void CMNLabel_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.CMNLabel, "Contains settings for battle effects, camera settings, and others.");
        }

        private void CTRL1Label_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.CTRL1Label, "Contains settings for mouse sensitivity similar control settings.");
        }

        private void CTRL2Label_MouseHover(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.SetToolTip(this.CTRL2Label, "Contains the same settings as CTRL0.");
        }
    }
}
