namespace CommandPattern
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
            this.pnl_View = new System.Windows.Forms.Panel();
            this.lbl_Player = new System.Windows.Forms.Label();
            this.btn_Color = new System.Windows.Forms.Button();
            this.btn_Up = new System.Windows.Forms.Button();
            this.btn_Left = new System.Windows.Forms.Button();
            this.btn_Right = new System.Windows.Forms.Button();
            this.btn_Down = new System.Windows.Forms.Button();
            this.btn_Undo = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.pnl_View.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_View
            // 
            this.pnl_View.Controls.Add(this.lbl_Player);
            this.pnl_View.Location = new System.Drawing.Point(29, 26);
            this.pnl_View.Name = "pnl_View";
            this.pnl_View.Size = new System.Drawing.Size(1456, 992);
            this.pnl_View.TabIndex = 0;
            // 
            // lbl_Player
            // 
            this.lbl_Player.AutoSize = true;
            this.lbl_Player.Location = new System.Drawing.Point(660, 457);
            this.lbl_Player.Name = "lbl_Player";
            this.lbl_Player.Size = new System.Drawing.Size(122, 41);
            this.lbl_Player.TabIndex = 0;
            this.lbl_Player.Text = "\"Player\"";
            this.lbl_Player.Click += new System.EventHandler(this.lab_Player_Click);
            // 
            // btn_Color
            // 
            this.btn_Color.Location = new System.Drawing.Point(1536, 78);
            this.btn_Color.Name = "btn_Color";
            this.btn_Color.Size = new System.Drawing.Size(228, 58);
            this.btn_Color.TabIndex = 1;
            this.btn_Color.Text = "Change Color";
            this.btn_Color.UseVisualStyleBackColor = true;
            this.btn_Color.Click += new System.EventHandler(this.btn_Color_Click);
            // 
            // btn_Up
            // 
            this.btn_Up.Location = new System.Drawing.Point(1597, 216);
            this.btn_Up.Name = "btn_Up";
            this.btn_Up.Size = new System.Drawing.Size(110, 58);
            this.btn_Up.TabIndex = 2;
            this.btn_Up.Text = "Up";
            this.btn_Up.UseVisualStyleBackColor = true;
            this.btn_Up.Click += new System.EventHandler(this.btn_Up_Click);
            // 
            // btn_Left
            // 
            this.btn_Left.Location = new System.Drawing.Point(1536, 290);
            this.btn_Left.Name = "btn_Left";
            this.btn_Left.Size = new System.Drawing.Size(101, 58);
            this.btn_Left.TabIndex = 3;
            this.btn_Left.Text = "Left";
            this.btn_Left.UseVisualStyleBackColor = true;
            this.btn_Left.Click += new System.EventHandler(this.btn_Left_Click);
            // 
            // btn_Right
            // 
            this.btn_Right.Location = new System.Drawing.Point(1663, 290);
            this.btn_Right.Name = "btn_Right";
            this.btn_Right.Size = new System.Drawing.Size(101, 58);
            this.btn_Right.TabIndex = 4;
            this.btn_Right.Text = "Right";
            this.btn_Right.UseVisualStyleBackColor = true;
            this.btn_Right.Click += new System.EventHandler(this.btn_Right_Click);
            // 
            // btn_Down
            // 
            this.btn_Down.Location = new System.Drawing.Point(1597, 376);
            this.btn_Down.Name = "btn_Down";
            this.btn_Down.Size = new System.Drawing.Size(110, 58);
            this.btn_Down.TabIndex = 5;
            this.btn_Down.Text = "Down";
            this.btn_Down.UseVisualStyleBackColor = true;
            this.btn_Down.Click += new System.EventHandler(this.btn_Down_Click);
            // 
            // btn_Undo
            // 
            this.btn_Undo.Location = new System.Drawing.Point(1597, 653);
            this.btn_Undo.Name = "btn_Undo";
            this.btn_Undo.Size = new System.Drawing.Size(110, 58);
            this.btn_Undo.TabIndex = 6;
            this.btn_Undo.Text = "Undo";
            this.btn_Undo.UseVisualStyleBackColor = true;
            this.btn_Undo.Click += new System.EventHandler(this.btn_Undo_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Location = new System.Drawing.Point(1597, 786);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(110, 58);
            this.btn_Reset.TabIndex = 7;
            this.btn_Reset.Text = "Reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1805, 1056);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.btn_Undo);
            this.Controls.Add(this.btn_Down);
            this.Controls.Add(this.btn_Right);
            this.Controls.Add(this.btn_Left);
            this.Controls.Add(this.btn_Up);
            this.Controls.Add(this.btn_Color);
            this.Controls.Add(this.pnl_View);
            this.Name = "Form1";
            this.Text = "CommandPattern";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnl_View.ResumeLayout(false);
            this.pnl_View.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnl_View;
        private Button btn_Color;
        private Button btn_Up;
        private Button btn_Left;
        private Button btn_Right;
        private Button btn_Down;
        private Button btn_Undo;
        private Button btn_Reset;
        private Label lbl_Player;
    }
}