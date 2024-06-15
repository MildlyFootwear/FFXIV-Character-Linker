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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
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
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 2, 0);
            tableLayoutPanel1.Controls.Add(label3, 3, 0);
            tableLayoutPanel1.Controls.Add(label4, 4, 0);
            tableLayoutPanel1.Controls.Add(label5, 5, 0);
            tableLayoutPanel1.Controls.Add(label6, 6, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // CharacterList
            // 
            resources.ApplyResources(CharacterList, "CharacterList");
            CharacterList.Name = "CharacterList";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(label4, "label4");
            label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(label5, "label5");
            label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(label6, "label6");
            label6.Name = "label6";
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button LinkButton;
    }
}