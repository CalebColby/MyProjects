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
            this.GuessBtn = new System.Windows.Forms.Button();
            this.GuessTxtBox = new System.Windows.Forms.TextBox();
            this.ResultsLbn = new System.Windows.Forms.Label();
            this.PreGameElements.SuspendLayout();
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
            // GuessBtn
            // 
            this.GuessBtn.Enabled = false;
            this.GuessBtn.Location = new System.Drawing.Point(809, 602);
            this.GuessBtn.Name = "GuessBtn";
            this.GuessBtn.Size = new System.Drawing.Size(117, 58);
            this.GuessBtn.TabIndex = 0;
            this.GuessBtn.Text = "&Guess";
            this.GuessBtn.UseVisualStyleBackColor = true;
            // 
            // GuessTxtBox
            // 
            this.GuessTxtBox.Enabled = false;
            this.GuessTxtBox.Location = new System.Drawing.Point(768, 448);
            this.GuessTxtBox.Name = "GuessTxtBox";
            this.GuessTxtBox.Size = new System.Drawing.Size(184, 47);
            this.GuessTxtBox.TabIndex = 5;
            this.GuessTxtBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.GuessTxtBox_KeyPress);
            // 
            // ResultsLbn
            // 
            this.ResultsLbn.AutoSize = true;
            this.ResultsLbn.Location = new System.Drawing.Point(809, 90);
            this.ResultsLbn.Name = "ResultsLbn";
            this.ResultsLbn.Size = new System.Drawing.Size(0, 41);
            this.ResultsLbn.TabIndex = 5;
            this.ResultsLbn.Visible = false;
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 1188);
            this.Controls.Add(this.ResultsLbn);
            this.Controls.Add(this.GuessTxtBox);
            this.Controls.Add(this.GuessBtn);
            this.Controls.Add(this.GameTable);
            this.Controls.Add(this.PreGameElements);
            this.Name = "Form";
            this.Text = "Form1";
            this.PreGameElements.ResumeLayout(false);
            this.PreGameElements.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private Label ResultsLbn;
    }
}