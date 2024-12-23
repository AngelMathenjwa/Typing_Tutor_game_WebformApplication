
namespace typing_tutor
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lblcorrect = new System.Windows.Forms.Label();
            this.lblincorrect = new System.Windows.Forms.Label();
            this.lblword = new System.Windows.Forms.Label();
            this.lblcommand = new System.Windows.Forms.Label();
            this.inputbox = new System.Windows.Forms.TextBox();
            this.btnexit = new System.Windows.Forms.Button();
            this.wordsTyped = new System.Windows.Forms.ListBox();
            this.lbltime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblmessage = new System.Windows.Forms.Label();
            this.btnrestart = new System.Windows.Forms.Button();
            this.Leaderboard = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblcorrect
            // 
            this.lblcorrect.AutoSize = true;
            this.lblcorrect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcorrect.Location = new System.Drawing.Point(6, 265);
            this.lblcorrect.Name = "lblcorrect";
            this.lblcorrect.Size = new System.Drawing.Size(69, 15);
            this.lblcorrect.TabIndex = 0;
            this.lblcorrect.Text = "Correct: 0";
            this.lblcorrect.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblincorrect
            // 
            this.lblincorrect.AutoSize = true;
            this.lblincorrect.Location = new System.Drawing.Point(255, 265);
            this.lblincorrect.Name = "lblincorrect";
            this.lblincorrect.Size = new System.Drawing.Size(79, 15);
            this.lblincorrect.TabIndex = 1;
            this.lblincorrect.Text = "Incorrect: 0";
            this.lblincorrect.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lblword
            // 
            this.lblword.AutoSize = true;
            this.lblword.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblword.Location = new System.Drawing.Point(142, 72);
            this.lblword.Name = "lblword";
            this.lblword.Size = new System.Drawing.Size(84, 31);
            this.lblword.TabIndex = 2;
            this.lblword.Text = "Word";
            this.lblword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblcommand
            // 
            this.lblcommand.AutoSize = true;
            this.lblcommand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcommand.Location = new System.Drawing.Point(53, 157);
            this.lblcommand.Name = "lblcommand";
            this.lblcommand.Size = new System.Drawing.Size(235, 15);
            this.lblcommand.TabIndex = 3;
            this.lblcommand.Text = "Type the words displayed then press enter";
            this.lblcommand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputbox
            // 
            this.inputbox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.inputbox.Font = new System.Drawing.Font("Modern No. 20", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputbox.Location = new System.Drawing.Point(25, 115);
            this.inputbox.Name = "inputbox";
            this.inputbox.Size = new System.Drawing.Size(292, 39);
            this.inputbox.TabIndex = 4;
            this.inputbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnty_KeyPress);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Red;
            this.btnexit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.Location = new System.Drawing.Point(263, 7);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(80, 25);
            this.btnexit.TabIndex = 6;
            this.btnexit.Text = "Quit Game";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // wordsTyped
            // 
            this.wordsTyped.Font = new System.Drawing.Font("Bahnschrift", 9F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wordsTyped.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.wordsTyped.FormattingEnabled = true;
            this.wordsTyped.ItemHeight = 14;
            this.wordsTyped.Location = new System.Drawing.Point(3, 192);
            this.wordsTyped.MultiColumn = true;
            this.wordsTyped.Name = "wordsTyped";
            this.wordsTyped.Size = new System.Drawing.Size(340, 60);
            this.wordsTyped.TabIndex = 7;
            this.wordsTyped.SelectedIndexChanged += new System.EventHandler(this.wordsTyped_SelectedIndexChanged);
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("MS Mincho", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltime.Location = new System.Drawing.Point(6, 319);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(49, 13);
            this.lbltime.TabIndex = 9;
            this.lbltime.Text = "30 Sec";
            this.lbltime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.Font = new System.Drawing.Font("Stencil", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmessage.ForeColor = System.Drawing.Color.Red;
            this.lblmessage.Location = new System.Drawing.Point(145, 305);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(32, 16);
            this.lblmessage.TabIndex = 10;
            this.lblmessage.Text = "------";
            this.lblmessage.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnrestart
            // 
            this.btnrestart.BackColor = System.Drawing.Color.Lime;
            this.btnrestart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnrestart.Location = new System.Drawing.Point(9, 7);
            this.btnrestart.Name = "btnrestart";
            this.btnrestart.Size = new System.Drawing.Size(87, 25);
            this.btnrestart.TabIndex = 11;
            this.btnrestart.Text = "New Game";
            this.btnrestart.UseVisualStyleBackColor = false;
            this.btnrestart.Click += new System.EventHandler(this.btnrestart_Click);
            // 
            // Leaderboard
            // 
            this.Leaderboard.FormattingEnabled = true;
            this.Leaderboard.ItemHeight = 15;
            this.Leaderboard.Location = new System.Drawing.Point(389, 7);
            this.Leaderboard.Name = "Leaderboard";
            this.Leaderboard.Size = new System.Drawing.Size(148, 319);
            this.Leaderboard.TabIndex = 12;
            this.Leaderboard.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(550, 330);
            this.Controls.Add(this.Leaderboard);
            this.Controls.Add(this.btnrestart);
            this.Controls.Add(this.lblmessage);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.wordsTyped);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.inputbox);
            this.Controls.Add(this.lblcommand);
            this.Controls.Add(this.lblword);
            this.Controls.Add(this.lblincorrect);
            this.Controls.Add(this.lblcorrect);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Typing Tutor Game";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEnty_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcorrect;
        private System.Windows.Forms.Label lblincorrect;
        private System.Windows.Forms.Label lblword;
        private System.Windows.Forms.Label lblcommand;
        private System.Windows.Forms.TextBox inputbox;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.ListBox wordsTyped;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblmessage;
        private System.Windows.Forms.Button btnrestart;
        private System.Windows.Forms.ListBox Leaderboard;
    }
}

