
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckBoxIsHuman = new System.Windows.Forms.CheckBox();
            this.Player2Name = new System.Windows.Forms.TextBox();
            this.Player1Name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.buttonStart.Click += new System.EventHandler(this.button2_Click);
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
            this.ColNumber.ValueChanged += new System.EventHandler(this.ColNumber_ValueChanged);
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
            this.RowNumber.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(54, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 32);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rows:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            this.CheckBoxIsHuman.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Player2Name
            // 
            this.Player2Name.AccessibleName = "";
            this.Player2Name.Enabled = false;
            this.Player2Name.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Player2Name.Location = new System.Drawing.Point(243, 141);
            this.Player2Name.MaximumSize = new System.Drawing.Size(174, 26);
            this.Player2Name.Name = "Player2Name";
            this.Player2Name.Size = new System.Drawing.Size(174, 33);
            this.Player2Name.TabIndex = 4;
            this.Player2Name.Text = "[Computer]";
            // 
            // Player1Name
            // 
            this.Player1Name.Location = new System.Drawing.Point(243, 94);
            this.Player1Name.MaximumSize = new System.Drawing.Size(174, 26);
            this.Player1Name.Name = "Player1Name";
            this.Player1Name.Size = new System.Drawing.Size(174, 26);
            this.Player1Name.TabIndex = 3;
            this.Player1Name.TextChanged += new System.EventHandler(this.Player1Name_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player 1:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Players:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
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
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CheckBoxIsHuman);
            this.Controls.Add(this.Player2Name);
            this.Controls.Add(this.Player1Name);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CheckBoxIsHuman;
        private System.Windows.Forms.TextBox Player2Name;
        private System.Windows.Forms.TextBox Player1Name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}