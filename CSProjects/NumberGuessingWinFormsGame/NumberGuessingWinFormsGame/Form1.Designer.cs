namespace NumberGuessingWinFormsGame
{
    partial class Form
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
            this.StartBtn = new System.Windows.Forms.Button();
            this.EasyButton = new System.Windows.Forms.RadioButton();
            this.MedButton = new System.Windows.Forms.RadioButton();
            this.HardButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.PreGameElements = new System.Windows.Forms.GroupBox();
            this.GameTable = new System.Windows.Forms.TableLayoutPanel();
            this.Pic1 = new System.Windows.Forms.PictureBox();
            this.Pic2 = new System.Windows.Forms.PictureBox();
            this.Pic3 = new System.Windows.Forms.PictureBox();
            this.Pic4 = new System.Windows.Forms.PictureBox();
            this.Pic5 = new System.Windows.Forms.PictureBox();
            this.LBNgt1 = new System.Windows.Forms.Label();
            this.LBNgt2 = new System.Windows.Forms.Label();
            this.LBNgt3 = new System.Windows.Forms.Label();
            this.LBNgt4 = new System.Windows.Forms.Label();
            this.LBNgt5 = new System.Windows.Forms.Label();
            this.GuessBtn = new System.Windows.Forms.Button();
            this.GuessTxtBox = new System.Windows.Forms.TextBox();
            this.LBNResult = new System.Windows.Forms.Label();
            this.PreGameElements.SuspendLayout();
            this.GameTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic5)).BeginInit();
            this.SuspendLayout();
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(129, 281);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(188, 58);
            this.StartBtn.TabIndex = 0;
            this.StartBtn.Text = "&Start Game";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // EasyButton
            // 
            this.EasyButton.AutoSize = true;
            this.EasyButton.Location = new System.Drawing.Point(80, 103);
            this.EasyButton.Name = "EasyButton";
            this.EasyButton.Size = new System.Drawing.Size(215, 45);
            this.EasyButton.TabIndex = 1;
            this.EasyButton.TabStop = true;
            this.EasyButton.Text = "&Easy (1 - 25)";
            this.EasyButton.UseVisualStyleBackColor = true;
            // 
            // MedButton
            // 
            this.MedButton.AutoSize = true;
            this.MedButton.Location = new System.Drawing.Point(80, 154);
            this.MedButton.Name = "MedButton";
            this.MedButton.Size = new System.Drawing.Size(268, 45);
            this.MedButton.TabIndex = 2;
            this.MedButton.TabStop = true;
            this.MedButton.Text = "&Medium (1 - 50)";
            this.MedButton.UseVisualStyleBackColor = true;
            // 
            // HardButton
            // 
            this.HardButton.AutoSize = true;
            this.HardButton.Location = new System.Drawing.Point(80, 205);
            this.HardButton.Name = "HardButton";
            this.HardButton.Size = new System.Drawing.Size(237, 45);
            this.HardButton.TabIndex = 3;
            this.HardButton.TabStop = true;
            this.HardButton.Text = "&Hard (1 - 100)";
            this.HardButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Difficulty";
            // 
            // PreGameElements
            // 
            this.PreGameElements.Controls.Add(this.label1);
            this.PreGameElements.Controls.Add(this.StartBtn);
            this.PreGameElements.Controls.Add(this.EasyButton);
            this.PreGameElements.Controls.Add(this.HardButton);
            this.PreGameElements.Controls.Add(this.MedButton);
            this.PreGameElements.Location = new System.Drawing.Point(12, 12);
            this.PreGameElements.Name = "PreGameElements";
            this.PreGameElements.Size = new System.Drawing.Size(500, 367);
            this.PreGameElements.TabIndex = 5;
            this.PreGameElements.TabStop = false;
            // 
            // GameTable
            // 
            this.GameTable.ColumnCount = 2;
            this.GameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.43189F));
            this.GameTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.56811F));
            this.GameTable.Controls.Add(this.Pic1, 0, 0);
            this.GameTable.Controls.Add(this.Pic2, 0, 1);
            this.GameTable.Controls.Add(this.Pic3, 0, 2);
            this.GameTable.Controls.Add(this.Pic4, 0, 3);
            this.GameTable.Controls.Add(this.Pic5, 0, 4);
            this.GameTable.Controls.Add(this.LBNgt1, 1, 0);
            this.GameTable.Controls.Add(this.LBNgt2, 1, 1);
            this.GameTable.Controls.Add(this.LBNgt3, 1, 2);
            this.GameTable.Controls.Add(this.LBNgt4, 1, 3);
            this.GameTable.Controls.Add(this.LBNgt5, 1, 4);
            this.GameTable.Location = new System.Drawing.Point(12, 385);
            this.GameTable.Name = "GameTable";
            this.GameTable.RowCount = 5;
            this.GameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.GameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.GameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.GameTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.GameTable.Size = new System.Drawing.Size(602, 566);
            this.GameTable.TabIndex = 6;
            this.GameTable.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Pic1
            // 
            this.Pic1.Image = global::NumberGuessingWinFormsGame.Properties.Resources.incorrect_icon;
            this.Pic1.Location = new System.Drawing.Point(3, 3);
            this.Pic1.Name = "Pic1";
            this.Pic1.Size = new System.Drawing.Size(116, 111);
            this.Pic1.TabIndex = 0;
            this.Pic1.TabStop = false;
            this.Pic1.Visible = false;
            this.Pic1.Click += new System.EventHandler(this.Pic1_Click);
            // 
            // Pic2
            // 
            this.Pic2.Image = global::NumberGuessingWinFormsGame.Properties.Resources.incorrect_icon;
            this.Pic2.Location = new System.Drawing.Point(3, 120);
            this.Pic2.Name = "Pic2";
            this.Pic2.Size = new System.Drawing.Size(116, 111);
            this.Pic2.TabIndex = 1;
            this.Pic2.TabStop = false;
            this.Pic2.Visible = false;
            // 
            // Pic3
            // 
            this.Pic3.Image = global::NumberGuessingWinFormsGame.Properties.Resources.incorrect_icon;
            this.Pic3.Location = new System.Drawing.Point(3, 237);
            this.Pic3.Name = "Pic3";
            this.Pic3.Size = new System.Drawing.Size(116, 111);
            this.Pic3.TabIndex = 2;
            this.Pic3.TabStop = false;
            this.Pic3.Visible = false;
            // 
            // Pic4
            // 
            this.Pic4.Image = global::NumberGuessingWinFormsGame.Properties.Resources.incorrect_icon;
            this.Pic4.Location = new System.Drawing.Point(3, 354);
            this.Pic4.Name = "Pic4";
            this.Pic4.Size = new System.Drawing.Size(116, 104);
            this.Pic4.TabIndex = 3;
            this.Pic4.TabStop = false;
            this.Pic4.Visible = false;
            // 
            // Pic5
            // 
            this.Pic5.Image = global::NumberGuessingWinFormsGame.Properties.Resources.incorrect_icon;
            this.Pic5.Location = new System.Drawing.Point(3, 464);
            this.Pic5.Name = "Pic5";
            this.Pic5.Size = new System.Drawing.Size(116, 99);
            this.Pic5.TabIndex = 4;
            this.Pic5.TabStop = false;
            this.Pic5.Visible = false;
            // 
            // LBNgt1
            // 
            this.LBNgt1.AutoSize = true;
            this.LBNgt1.Location = new System.Drawing.Point(125, 0);
            this.LBNgt1.Name = "LBNgt1";
            this.LBNgt1.Size = new System.Drawing.Size(0, 41);
            this.LBNgt1.TabIndex = 5;
            // 
            // LBNgt2
            // 
            this.LBNgt2.AutoSize = true;
            this.LBNgt2.Location = new System.Drawing.Point(125, 117);
            this.LBNgt2.Name = "LBNgt2";
            this.LBNgt2.Size = new System.Drawing.Size(0, 41);
            this.LBNgt2.TabIndex = 6;
            // 
            // LBNgt3
            // 
            this.LBNgt3.AutoSize = true;
            this.LBNgt3.Location = new System.Drawing.Point(125, 234);
            this.LBNgt3.Name = "LBNgt3";
            this.LBNgt3.Size = new System.Drawing.Size(0, 41);
            this.LBNgt3.TabIndex = 7;
            // 
            // LBNgt4
            // 
            this.LBNgt4.AutoSize = true;
            this.LBNgt4.Location = new System.Drawing.Point(125, 351);
            this.LBNgt4.Name = "LBNgt4";
            this.LBNgt4.Size = new System.Drawing.Size(0, 41);
            this.LBNgt4.TabIndex = 8;
            // 
            // LBNgt5
            // 
            this.LBNgt5.AutoSize = true;
            this.LBNgt5.Location = new System.Drawing.Point(125, 461);
            this.LBNgt5.Name = "LBNgt5";
            this.LBNgt5.Size = new System.Drawing.Size(0, 41);
            this.LBNgt5.TabIndex = 9;
            // 
            // GuessBtn
            // 
            this.GuessBtn.Enabled = false;
            this.GuessBtn.Location = new System.Drawing.Point(809, 602);
            this.GuessBtn.Name = "GuessBtn";
            this.GuessBtn.Size = new System.Drawing.Size(117, 58);
            this.GuessBtn.TabIndex = 0;
            this.GuessBtn.Text = "&Guess";
            this.GuessBtn.UseVisualStyleBackColor = true;
            this.GuessBtn.Click += new System.EventHandler(this.GuessBtn_Click);
            // 
            // GuessTxtBox
            // 
            this.GuessTxtBox.Enabled = false;
            this.GuessTxtBox.Location = new System.Drawing.Point(768, 448);
            this.GuessTxtBox.Name = "GuessTxtBox";
            this.GuessTxtBox.Size = new System.Drawing.Size(184, 47);
            this.GuessTxtBox.TabIndex = 5;
            this.GuessTxtBox.TextChanged += new System.EventHandler(this.GuessTxtBox_TextChanged);
            this.GuessTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GuessTxtBox_KeyPress);
            // 
            // LBNResult
            // 
            this.LBNResult.AutoSize = true;
            this.LBNResult.Location = new System.Drawing.Point(518, 71);
            this.LBNResult.Name = "LBNResult";
            this.LBNResult.Size = new System.Drawing.Size(358, 41);
            this.LBNResult.TabIndex = 5;
            this.LBNResult.Text = "Please Choose a Difficulty";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 1188);
            this.Controls.Add(this.LBNResult);
            this.Controls.Add(this.GuessTxtBox);
            this.Controls.Add(this.GuessBtn);
            this.Controls.Add(this.GameTable);
            this.Controls.Add(this.PreGameElements);
            this.Name = "Form";
            this.Text = "Number Guessing Game";
            this.PreGameElements.ResumeLayout(false);
            this.PreGameElements.PerformLayout();
            this.GameTable.ResumeLayout(false);
            this.GameTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Pic5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        #endregion

        private Button StartBtn;
        private RadioButton EasyButton;
        private RadioButton MedButton;
        private RadioButton HardButton;
        private Label label1;
        private GroupBox PreGameElements;
        private TableLayoutPanel GameTable;
        private Button GuessBtn;
        private TextBox GuessTxtBox;
        private Label LBNResult;
        private PictureBox Pic1;
        private PictureBox Pic2;
        private PictureBox Pic3;
        private PictureBox Pic4;
        private PictureBox Pic5;
        private Label LBNgt1;
        private Label LBNgt2;
        private Label LBNgt3;
        private Label LBNgt4;
        private Label LBNgt5;
    }
}