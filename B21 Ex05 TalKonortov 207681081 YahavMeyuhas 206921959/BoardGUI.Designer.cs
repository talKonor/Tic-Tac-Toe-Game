namespace GUI
{
    partial class BoardGUI
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
            this.Player1Name = new System.Windows.Forms.Label();
            this.Player1Score = new System.Windows.Forms.Label();
            this.Player2Name = new System.Windows.Forms.Label();
            this.Player2Score = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Player1Name
            // 
            this.Player1Name.AutoSize = true;
            this.Player1Name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Player1Name.Location = new System.Drawing.Point(3, 0);
            this.Player1Name.Name = "Player1Name";
            this.Player1Name.Size = new System.Drawing.Size(73, 20);
            this.Player1Name.TabIndex = 0;
            this.Player1Name.Text = "Player 1: ";
            this.Player1Name.Click += new System.EventHandler(this.Player1Name_Click);
            // 
            // Player1Score
            // 
            this.Player1Score.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Player1Score.AutoSize = true;
            this.Player1Score.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Player1Score.Location = new System.Drawing.Point(82, 0);
            this.Player1Score.Name = "Player1Score";
            this.Player1Score.Size = new System.Drawing.Size(18, 20);
            this.Player1Score.TabIndex = 1;
            this.Player1Score.Text = "0";
            // 
            // Player2Name
            // 
            this.Player2Name.AutoSize = true;
            this.Player2Name.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Player2Name.Location = new System.Drawing.Point(106, 0);
            this.Player2Name.Name = "Player2Name";
            this.Player2Name.Size = new System.Drawing.Size(73, 20);
            this.Player2Name.TabIndex = 2;
            this.Player2Name.Text = "Player 2: ";
            // 
            // Player2Score
            // 
            this.Player2Score.AutoSize = true;
            this.Player2Score.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Player2Score.Location = new System.Drawing.Point(185, 0);
            this.Player2Score.Name = "Player2Score";
            this.Player2Score.Size = new System.Drawing.Size(18, 20);
            this.Player2Score.TabIndex = 3;
            this.Player2Score.Text = "0";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.Player1Name);
            this.flowLayoutPanel1.Controls.Add(this.Player1Score);
            this.flowLayoutPanel1.Controls.Add(this.Player2Name);
            this.flowLayoutPanel1.Controls.Add(this.Player2Score);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(140, 436);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(677, 27);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // BoardGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(485, 462);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "BoardGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToeMisere";
            this.Load += new System.EventHandler(this.BoardGUI_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Player1Name;
        private System.Windows.Forms.Label Player1Score;
        private System.Windows.Forms.Label Player2Name;
        private System.Windows.Forms.Label Player2Score;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}