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
            button1 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(235, 87);
            label1.Name = "label1";
            label1.Size = new Size(335, 30);
            label1.TabIndex = 0;
            label1.Text = "Game settings directory not found.";
            // 
            // button1
            // 
            button1.Location = new Point(271, 220);
            button1.Name = "button1";
            button1.Size = new Size(281, 40);
            button1.TabIndex = 1;
            button1.Text = "Select Directory";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // GameDocumentDirectorySelection
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "GameDocumentDirectorySelection";
            Text = "FFXIV Settings Linker";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion


        private Label label1;
        private Button button1;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}