namespace GraphicalTicTacToe
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.one_btn = new System.Windows.Forms.Button();
            this.four_btn = new System.Windows.Forms.Button();
            this.seven_btn = new System.Windows.Forms.Button();
            this.two_btn = new System.Windows.Forms.Button();
            this.five_btn = new System.Windows.Forms.Button();
            this.eight_btn = new System.Windows.Forms.Button();
            this.three_btn = new System.Windows.Forms.Button();
            this.six_btn = new System.Windows.Forms.Button();
            this.nine_btn = new System.Windows.Forms.Button();
            this.gameState_lbl = new System.Windows.Forms.Label();
            this.restart_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GraphicalTicTacToe.Properties.Resources._205_2056247_tic_tac_toe_board_png_steel_frame_semi;
            this.pictureBox1.Location = new System.Drawing.Point(20, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(724, 746);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // one_btn
            // 
            this.one_btn.Location = new System.Drawing.Point(31, 30);
            this.one_btn.Name = "one_btn";
            this.one_btn.Size = new System.Drawing.Size(230, 237);
            this.one_btn.TabIndex = 1;
            this.one_btn.UseVisualStyleBackColor = true;
            this.one_btn.Click += new System.EventHandler(this.one_btn_Click);
            // 
            // four_btn
            // 
            this.four_btn.Location = new System.Drawing.Point(31, 273);
            this.four_btn.Name = "four_btn";
            this.four_btn.Size = new System.Drawing.Size(230, 237);
            this.four_btn.TabIndex = 2;
            this.four_btn.UseVisualStyleBackColor = true;
            this.four_btn.Click += new System.EventHandler(this.four_btn_Click);
            // 
            // seven_btn
            // 
            this.seven_btn.Location = new System.Drawing.Point(31, 516);
            this.seven_btn.Name = "seven_btn";
            this.seven_btn.Size = new System.Drawing.Size(230, 237);
            this.seven_btn.TabIndex = 3;
            this.seven_btn.UseVisualStyleBackColor = true;
            this.seven_btn.Click += new System.EventHandler(this.seven_btn_Click);
            // 
            // two_btn
            // 
            this.two_btn.Location = new System.Drawing.Point(267, 30);
            this.two_btn.Name = "two_btn";
            this.two_btn.Size = new System.Drawing.Size(230, 237);
            this.two_btn.TabIndex = 4;
            this.two_btn.UseVisualStyleBackColor = true;
            this.two_btn.Click += new System.EventHandler(this.two_btn_Click);
            // 
            // five_btn
            // 
            this.five_btn.Location = new System.Drawing.Point(267, 273);
            this.five_btn.Name = "five_btn";
            this.five_btn.Size = new System.Drawing.Size(230, 237);
            this.five_btn.TabIndex = 5;
            this.five_btn.UseVisualStyleBackColor = true;
            this.five_btn.Click += new System.EventHandler(this.five_btn_Click);
            // 
            // eight_btn
            // 
            this.eight_btn.Location = new System.Drawing.Point(267, 516);
            this.eight_btn.Name = "eight_btn";
            this.eight_btn.Size = new System.Drawing.Size(230, 237);
            this.eight_btn.TabIndex = 6;
            this.eight_btn.UseVisualStyleBackColor = true;
            this.eight_btn.Click += new System.EventHandler(this.eight_btn_Click);
            // 
            // three_btn
            // 
            this.three_btn.Location = new System.Drawing.Point(503, 30);
            this.three_btn.Name = "three_btn";
            this.three_btn.Size = new System.Drawing.Size(230, 237);
            this.three_btn.TabIndex = 7;
            this.three_btn.UseVisualStyleBackColor = true;
            this.three_btn.Click += new System.EventHandler(this.three_btn_Click);
            // 
            // six_btn
            // 
            this.six_btn.Location = new System.Drawing.Point(503, 273);
            this.six_btn.Name = "six_btn";
            this.six_btn.Size = new System.Drawing.Size(230, 237);
            this.six_btn.TabIndex = 8;
            this.six_btn.UseVisualStyleBackColor = true;
            this.six_btn.Click += new System.EventHandler(this.six_btn_Click);
            // 
            // nine_btn
            // 
            this.nine_btn.Location = new System.Drawing.Point(503, 516);
            this.nine_btn.Name = "nine_btn";
            this.nine_btn.Size = new System.Drawing.Size(230, 237);
            this.nine_btn.TabIndex = 9;
            this.nine_btn.UseVisualStyleBackColor = true;
            this.nine_btn.Click += new System.EventHandler(this.nine_btn_Click);
            // 
            // gameState_lbl
            // 
            this.gameState_lbl.AutoSize = true;
            this.gameState_lbl.Location = new System.Drawing.Point(107, 111);
            this.gameState_lbl.Name = "gameState_lbl";
            this.gameState_lbl.Size = new System.Drawing.Size(148, 32);
            this.gameState_lbl.TabIndex = 10;
            this.gameState_lbl.Text = "GAME STATE";
            // 
            // restart_btn
            // 
            this.restart_btn.Location = new System.Drawing.Point(107, 320);
            this.restart_btn.Name = "restart_btn";
            this.restart_btn.Size = new System.Drawing.Size(150, 46);
            this.restart_btn.TabIndex = 11;
            this.restart_btn.Text = "RESTART";
            this.restart_btn.UseVisualStyleBackColor = true;
            this.restart_btn.Click += new System.EventHandler(this.restart_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.restart_btn);
            this.groupBox1.Controls.Add(this.gameState_lbl);
            this.groupBox1.Location = new System.Drawing.Point(898, 158);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 442);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Game Info";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1476, 784);
            this.Controls.Add(this.nine_btn);
            this.Controls.Add(this.six_btn);
            this.Controls.Add(this.three_btn);
            this.Controls.Add(this.eight_btn);
            this.Controls.Add(this.five_btn);
            this.Controls.Add(this.two_btn);
            this.Controls.Add(this.seven_btn);
            this.Controls.Add(this.four_btn);
            this.Controls.Add(this.one_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox pictureBox1;
        private Button one_btn;
        private Button four_btn;
        private Button seven_btn;
        private Button two_btn;
        private Button five_btn;
        private Button eight_btn;
        private Button three_btn;
        private Button six_btn;
        private Button nine_btn;
        private Label gameState_lbl;
        private Button restart_btn;
        private GroupBox groupBox1;
    }
}