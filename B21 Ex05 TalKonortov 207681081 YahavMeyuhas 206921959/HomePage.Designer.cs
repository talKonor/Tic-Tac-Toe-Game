
namespace GUI
{
    partial class HomePage
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.ColNumber = new System.Windows.Forms.NumericUpDown();
            this.RowNumber = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.Rows = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckBoxIsHuman = new System.Windows.Forms.CheckBox();
            this.Player2Name = new System.Windows.Forms.TextBox();
            this.Player1Name = new System.Windows.Forms.TextBox();
            this.Player1 = new System.Windows.Forms.Label();
            this.Players = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.ColNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.buttonStart.Location = new System.Drawing.Point(93, 372);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(299, 39);
            this.buttonStart.TabIndex = 11;
            this.buttonStart.Text = "Start!";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // ColNumber
            // 
            this.ColNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.ColNumber.Location = new System.Drawing.Point(388, 295);
            this.ColNumber.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.ColNumber.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.ColNumber.Name = "ColNumber";
            this.ColNumber.Size = new System.Drawing.Size(62, 35);
            this.ColNumber.TabIndex = 9;
            this.ColNumber.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.ColNumber.ValueChanged += new System.EventHandler(this.numericUpDownCols_ValueChanged);
            // 
            // RowNumber
            // 
            this.RowNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.RowNumber.Location = new System.Drawing.Point(158, 293);
            this.RowNumber.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.RowNumber.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.RowNumber.Name = "RowNumber";
            this.RowNumber.Size = new System.Drawing.Size(64, 35);
            this.RowNumber.TabIndex = 8;
            this.RowNumber.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.RowNumber.ValueChanged += new System.EventHandler(this.numericUpDownRows_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(298, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 32);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cols:";
            // 
            // Rows
            // 
            this.Rows.AutoSize = true;
            this.Rows.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rows.Location = new System.Drawing.Point(54, 294);
            this.Rows.Name = "Rows";
            this.Rows.Size = new System.Drawing.Size(93, 32);
            this.Rows.TabIndex = 6;
            this.Rows.Text = "Rows:";
            this.Rows.Click += new System.EventHandler(this.labelRows_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Board Size:";
            // 
            // CheckBoxIsHuman
            // 
            this.CheckBoxIsHuman.BackColor = System.Drawing.SystemColors.Control;
            this.CheckBoxIsHuman.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.CheckBoxIsHuman.Location = new System.Drawing.Point(93, 136);
            this.CheckBoxIsHuman.Name = "CheckBoxIsHuman";
            this.CheckBoxIsHuman.Size = new System.Drawing.Size(144, 31);
            this.CheckBoxIsHuman.TabIndex = 0;
            this.CheckBoxIsHuman.Text = "Player 2:";
            this.CheckBoxIsHuman.UseVisualStyleBackColor = false;
            this.CheckBoxIsHuman.CheckedChanged += new System.EventHandler(this.checkBoxIsHuman_CheckedChanged);
            // 
            // Player2Name
            // 
            this.Player2Name.AccessibleName = "";
            this.Player2Name.Enabled = false;
            this.Player2Name.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Player2Name.Location = new System.Drawing.Point(243, 141);
            this.Player2Name.MaximumSize = new System.Drawing.Size(174, 26);
            this.Player2Name.MaxLength = 20;
            this.Player2Name.Name = "Player2Name";
            this.Player2Name.Size = new System.Drawing.Size(174, 33);
            this.Player2Name.TabIndex = 4;
            this.Player2Name.Text = "[Computer]";
            // 
            // Player1Name
            // 
            this.Player1Name.Location = new System.Drawing.Point(243, 94);
            this.Player1Name.MaximumSize = new System.Drawing.Size(174, 26);
            this.Player1Name.MaxLength = 20;
            this.Player1Name.Name = "Player1Name";
            this.Player1Name.Size = new System.Drawing.Size(174, 26);
            this.Player1Name.TabIndex = 3;
            this.Player1Name.TextChanged += new System.EventHandler(this.Player1Name_TextChanged);
            // 
            // Player1
            // 
            this.Player1.AutoSize = true;
            this.Player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1.Location = new System.Drawing.Point(88, 90);
            this.Player1.Name = "Player1";
            this.Player1.Size = new System.Drawing.Size(159, 44);
            this.Player1.TabIndex = 1;
            this.Player1.Text = "Player 1:";
            this.Player1.Click += new System.EventHandler(this.labelPlayer1_Click);
            // 
            // Players
            // 
            this.Players.AutoSize = true;
            this.Players.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Players.Location = new System.Drawing.Point(26, 47);
            this.Players.Name = "Players";
            this.Players.Size = new System.Drawing.Size(118, 32);
            this.Players.TabIndex = 0;
            this.Players.Text = "Players:";
            this.Players.Click += new System.EventHandler(this.labelPlayers_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 468);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.ColNumber);
            this.Controls.Add(this.RowNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Rows);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CheckBoxIsHuman);
            this.Controls.Add(this.Player2Name);
            this.Controls.Add(this.Player1Name);
            this.Controls.Add(this.Player1);
            this.Controls.Add(this.Players);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Settings";
            ((System.ComponentModel.ISupportInitialize)(this.ColNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RowNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.NumericUpDown ColNumber;
        private System.Windows.Forms.NumericUpDown RowNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Rows;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CheckBoxIsHuman;
        private System.Windows.Forms.TextBox Player2Name;
        private System.Windows.Forms.TextBox Player1Name;
        private System.Windows.Forms.Label Players;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label Player1;
    }
}