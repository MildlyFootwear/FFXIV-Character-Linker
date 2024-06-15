namespace FFXIV_Character_Linker
{
    partial class SyncControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SyncControl));
            SelectedSource = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            CharacterList = new Label();
            UILabel = new Label();
            HotbarLabel = new Label();
            KeybindLabel = new Label();
            GaugeLabel = new Label();
            MacrosLabel = new Label();
            ChatFiltersLabel = new Label();
            CMNLabel = new Label();
            CTRL1Label = new Label();
            CTRL2Label = new Label();
            resetButton = new Button();
            LinkButton = new Button();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // SelectedSource
            // 
            resources.ApplyResources(SelectedSource, "SelectedSource");
            SelectedSource.Name = "SelectedSource";
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(tableLayoutPanel1, "tableLayoutPanel1");
            tableLayoutPanel1.Controls.Add(CharacterList, 0, 0);
            tableLayoutPanel1.Controls.Add(UILabel, 1, 0);
            tableLayoutPanel1.Controls.Add(HotbarLabel, 2, 0);
            tableLayoutPanel1.Controls.Add(KeybindLabel, 3, 0);
            tableLayoutPanel1.Controls.Add(GaugeLabel, 4, 0);
            tableLayoutPanel1.Controls.Add(MacrosLabel, 5, 0);
            tableLayoutPanel1.Controls.Add(ChatFiltersLabel, 6, 0);
            tableLayoutPanel1.Controls.Add(CMNLabel, 7, 0);
            tableLayoutPanel1.Controls.Add(CTRL1Label, 8, 0);
            tableLayoutPanel1.Controls.Add(CTRL2Label, 9, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // CharacterList
            // 
            resources.ApplyResources(CharacterList, "CharacterList");
            CharacterList.Name = "CharacterList";
            // 
            // UILabel
            // 
            resources.ApplyResources(UILabel, "UILabel");
            UILabel.Name = "UILabel";
            UILabel.MouseHover += UILabel_MouseHover;
            // 
            // HotbarLabel
            // 
            resources.ApplyResources(HotbarLabel, "HotbarLabel");
            HotbarLabel.Name = "HotbarLabel";
            HotbarLabel.MouseHover += HotbarLabel_MouseHover;
            // 
            // KeybindLabel
            // 
            resources.ApplyResources(KeybindLabel, "KeybindLabel");
            KeybindLabel.Name = "KeybindLabel";
            KeybindLabel.MouseHover += KeybindLabel_MouseHover;
            // 
            // GaugeLabel
            // 
            resources.ApplyResources(GaugeLabel, "GaugeLabel");
            GaugeLabel.Name = "GaugeLabel";
            GaugeLabel.MouseHover += GaugeLabel_MouseHover;
            // 
            // MacrosLabel
            // 
            resources.ApplyResources(MacrosLabel, "MacrosLabel");
            MacrosLabel.Name = "MacrosLabel";
            MacrosLabel.MouseHover += MacrosLabel_MouseHover;
            // 
            // ChatFiltersLabel
            // 
            resources.ApplyResources(ChatFiltersLabel, "ChatFiltersLabel");
            ChatFiltersLabel.Name = "ChatFiltersLabel";
            ChatFiltersLabel.MouseHover += ChatFiltersLabel_MouseHover;
            // 
            // CMNLabel
            // 
            resources.ApplyResources(CMNLabel, "CMNLabel");
            CMNLabel.Name = "CMNLabel";
            CMNLabel.MouseHover += CMNLabel_MouseHover;
            // 
            // CTRL1Label
            // 
            resources.ApplyResources(CTRL1Label, "CTRL1Label");
            CTRL1Label.Name = "CTRL1Label";
            CTRL1Label.MouseHover += CTRL1Label_MouseHover;
            // 
            // CTRL2Label
            // 
            resources.ApplyResources(CTRL2Label, "CTRL2Label");
            CTRL2Label.Name = "CTRL2Label";
            CTRL2Label.MouseHover += CTRL2Label_MouseHover;
            // 
            // resetButton
            // 
            resources.ApplyResources(resetButton, "resetButton");
            resetButton.Name = "resetButton";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += button1_Click;
            // 
            // LinkButton
            // 
            resources.ApplyResources(LinkButton, "LinkButton");
            LinkButton.Name = "LinkButton";
            LinkButton.UseVisualStyleBackColor = true;
            LinkButton.Click += LinkButton_Click;
            // 
            // SyncControl
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(LinkButton);
            Controls.Add(resetButton);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(SelectedSource);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "SyncControl";
            FormClosing += OnClose;
            Load += OnLoad;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SelectedSource;
        private TableLayoutPanel tableLayoutPanel1;
        private Label CharacterList;
        private Button resetButton;
        private Label UILabel;
        private Label HotbarLabel;
        private Label KeybindLabel;
        private Label GaugeLabel;
        private Label MacrosLabel;
        private Label ChatFiltersLabel;
        private Button LinkButton;
        private Label CMNLabel;
        private Label CTRL1Label;
        private Label CTRL2Label;
    }
}