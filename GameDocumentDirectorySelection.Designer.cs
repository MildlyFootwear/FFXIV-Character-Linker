namespace FFXIV_Character_Linker
{
    partial class GameDocumentDirectorySelection
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
            label1 = new Label();
            SelectSettingsDirectoryButton = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Location = new Point(41, 18);
            label1.Name = "label1";
            label1.Size = new Size(395, 30);
            label1.TabIndex = 0;
            label1.Text = "Please select the game settings directory.";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // SelectSettingsDirectoryButton
            // 
            SelectSettingsDirectoryButton.Location = new Point(98, 67);
            SelectSettingsDirectoryButton.Name = "SelectSettingsDirectoryButton";
            SelectSettingsDirectoryButton.Size = new Size(281, 40);
            SelectSettingsDirectoryButton.TabIndex = 1;
            SelectSettingsDirectoryButton.Text = "Select Directory";
            SelectSettingsDirectoryButton.UseVisualStyleBackColor = true;
            SelectSettingsDirectoryButton.Click += button1_Click;
            // 
            // GameDocumentDirectorySelection
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(476, 136);
            Controls.Add(SelectSettingsDirectoryButton);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "GameDocumentDirectorySelection";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FFXIV Settings Linker";
            Load += GameDocumentDirectorySelection_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label label1;
        private Button SelectSettingsDirectoryButton;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}