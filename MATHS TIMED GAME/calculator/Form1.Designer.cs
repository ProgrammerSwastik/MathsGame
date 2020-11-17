namespace calculator
{
    partial class MathTimedGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MathTimedGame));
            this.doneButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.answerBox = new System.Windows.Forms.TextBox();
            this.alabel = new System.Windows.Forms.Label();
            this.pluslabel = new System.Windows.Forms.Label();
            this.blabel = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.timeleftmore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textcorrectanswer = new System.Windows.Forms.Label();
            this.correctanswer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loading = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // doneButton
            // 
            this.doneButton.Enabled = false;
            this.doneButton.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doneButton.Location = new System.Drawing.Point(24, 389);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(1411, 75);
            this.doneButton.TabIndex = 0;
            this.doneButton.Text = "DONE";
            this.doneButton.UseVisualStyleBackColor = true;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Algerian", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(24, 515);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(1411, 77);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // answerBox
            // 
            this.answerBox.Font = new System.Drawing.Font("Stencil", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answerBox.Location = new System.Drawing.Point(24, 267);
            this.answerBox.Multiline = true;
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(1411, 86);
            this.answerBox.TabIndex = 2;
            // 
            // alabel
            // 
            this.alabel.AutoSize = true;
            this.alabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alabel.Location = new System.Drawing.Point(50, 134);
            this.alabel.Name = "alabel";
            this.alabel.Size = new System.Drawing.Size(68, 73);
            this.alabel.TabIndex = 3;
            this.alabel.Text = "0";
            // 
            // pluslabel
            // 
            this.pluslabel.AutoSize = true;
            this.pluslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pluslabel.Location = new System.Drawing.Point(178, 134);
            this.pluslabel.Name = "pluslabel";
            this.pluslabel.Size = new System.Drawing.Size(69, 73);
            this.pluslabel.TabIndex = 4;
            this.pluslabel.Text = "+";
            // 
            // blabel
            // 
            this.blabel.AutoSize = true;
            this.blabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blabel.Location = new System.Drawing.Point(316, 134);
            this.blabel.Name = "blabel";
            this.blabel.Size = new System.Drawing.Size(68, 73);
            this.blabel.TabIndex = 5;
            this.blabel.Text = "0";
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(1054, 18);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(57, 65);
            this.timerLabel.TabIndex = 6;
            this.timerLabel.Text = "0";
            // 
            // timeleftmore
            // 
            this.timeleftmore.AutoSize = true;
            this.timeleftmore.Font = new System.Drawing.Font("Modern No. 20", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeleftmore.Location = new System.Drawing.Point(676, 18);
            this.timeleftmore.Name = "timeleftmore";
            this.timeleftmore.Size = new System.Drawing.Size(332, 65);
            this.timeleftmore.TabIndex = 7;
            this.timeleftmore.Text = "Time Left :";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textcorrectanswer
            // 
            this.textcorrectanswer.AutoSize = true;
            this.textcorrectanswer.Enabled = false;
            this.textcorrectanswer.Font = new System.Drawing.Font("Castellar", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcorrectanswer.Location = new System.Drawing.Point(679, 123);
            this.textcorrectanswer.Name = "textcorrectanswer";
            this.textcorrectanswer.Size = new System.Drawing.Size(440, 44);
            this.textcorrectanswer.TabIndex = 8;
            this.textcorrectanswer.Text = "Correct Answer :";
            // 
            // correctanswer
            // 
            this.correctanswer.AutoSize = true;
            this.correctanswer.Enabled = false;
            this.correctanswer.Font = new System.Drawing.Font("Castellar", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctanswer.Location = new System.Drawing.Point(1125, 123);
            this.correctanswer.Name = "correctanswer";
            this.correctanswer.Size = new System.Drawing.Size(48, 44);
            this.correctanswer.TabIndex = 9;
            this.correctanswer.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(501, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(477, 298);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(642, 306);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(173, 129);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // loading
            // 
            this.loading.AutoSize = true;
            this.loading.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.loading.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loading.Location = new System.Drawing.Point(635, 550);
            this.loading.Name = "loading";
            this.loading.Size = new System.Drawing.Size(225, 42);
            this.loading.TabIndex = 12;
            this.loading.Text = "Loading......";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // MathTimedGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1447, 659);
            this.Controls.Add(this.loading);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.correctanswer);
            this.Controls.Add(this.textcorrectanswer);
            this.Controls.Add(this.timeleftmore);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.blabel);
            this.Controls.Add(this.pluslabel);
            this.Controls.Add(this.alabel);
            this.Controls.Add(this.answerBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.doneButton);
            this.Name = "MathTimedGame";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MathTimedGame_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox answerBox;
        private System.Windows.Forms.Label alabel;
        private System.Windows.Forms.Label pluslabel;
        private System.Windows.Forms.Label blabel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Label timeleftmore;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label textcorrectanswer;
        private System.Windows.Forms.Label correctanswer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label loading;
        private System.Windows.Forms.Timer timer2;
    }
}

