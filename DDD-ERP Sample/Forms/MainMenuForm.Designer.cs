namespace DDD_ERP_Sample
{
    partial class MainMenuForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnItemMenu = new Button();
            SuspendLayout();
            // 
            // btnItemMenu
            // 
            btnItemMenu.Location = new Point(142, 82);
            btnItemMenu.Name = "btnItemMenu";
            btnItemMenu.Size = new Size(94, 29);
            btnItemMenu.TabIndex = 0;
            btnItemMenu.Text = "Item";
            btnItemMenu.UseVisualStyleBackColor = true;
            btnItemMenu.Click += btnItemMenu_Click;
            // 
            // MainMenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnItemMenu);
            Name = "MainMenuForm";
            Text = "MainMenu";
            ResumeLayout(false);
        }

        #endregion

        private Button btnItemMenu;
    }
}