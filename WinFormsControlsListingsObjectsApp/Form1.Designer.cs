namespace WinFormsControlsListingsObjectsApp
{
    partial class Form1
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
            lstBoxEmploees = new ListBox();
            SuspendLayout();
            // 
            // lstBoxEmploees
            // 
            lstBoxEmploees.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lstBoxEmploees.FormattingEnabled = true;
            lstBoxEmploees.ItemHeight = 30;
            lstBoxEmploees.Location = new Point(22, 23);
            lstBoxEmploees.Name = "lstBoxEmploees";
            lstBoxEmploees.Size = new Size(247, 244);
            lstBoxEmploees.TabIndex = 0;
            lstBoxEmploees.DoubleClick += lstBoxEmploees_DoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstBoxEmploees);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstBoxEmploees;
    }
}