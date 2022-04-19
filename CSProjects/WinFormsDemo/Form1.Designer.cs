namespace WinFormsDemo
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
            this.BtnHello = new System.Windows.Forms.Button();
            this.lbnGreet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnHello
            // 
            this.BtnHello.AccessibleName = "btnHello";
            this.BtnHello.Location = new System.Drawing.Point(12, 12);
            this.BtnHello.Name = "BtnHello";
            this.BtnHello.Size = new System.Drawing.Size(188, 58);
            this.BtnHello.TabIndex = 0;
            this.BtnHello.Text = "Greet";
            this.BtnHello.UseVisualStyleBackColor = true;
            this.BtnHello.Click += new System.EventHandler(this.BtnHello_Click);
            // 
            // lbnGreet
            // 
            this.lbnGreet.AccessibleName = "lbnGreet";
            this.lbnGreet.AutoSize = true;
            this.lbnGreet.Location = new System.Drawing.Point(246, 21);
            this.lbnGreet.Name = "lbnGreet";
            this.lbnGreet.Size = new System.Drawing.Size(0, 41);
            this.lbnGreet.TabIndex = 1;
            // 
            // Form1
            // 
            this.AccessibleName = "";
            this.ClientSize = new System.Drawing.Size(1022, 594);
            this.Controls.Add(this.lbnGreet);
            this.Controls.Add(this.BtnHello);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtnHello;
        private Label lbnGreet;
    }
}