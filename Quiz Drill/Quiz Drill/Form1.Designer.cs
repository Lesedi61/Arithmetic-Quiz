
namespace Quiz_Drill
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblNumA = new System.Windows.Forms.Label();
            this.logiOper = new System.Windows.Forms.Label();
            this.lblNumB = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblAnswer = new System.Windows.Forms.TextBox();
            this.lblSubmit = new System.Windows.Forms.Button();
            this.lblQuesNum = new System.Windows.Forms.Label();
            this.lblComplete = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblPercent = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Arithmetic Drills For Kids";
            // 
            // lblNumA
            // 
            this.lblNumA.AutoSize = true;
            this.lblNumA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumA.Location = new System.Drawing.Point(70, 107);
            this.lblNumA.Name = "lblNumA";
            this.lblNumA.Size = new System.Drawing.Size(36, 25);
            this.lblNumA.TabIndex = 1;
            this.lblNumA.Text = "00";
            // 
            // logiOper
            // 
            this.logiOper.AutoSize = true;
            this.logiOper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logiOper.Location = new System.Drawing.Point(141, 107);
            this.logiOper.Name = "logiOper";
            this.logiOper.Size = new System.Drawing.Size(25, 25);
            this.logiOper.TabIndex = 2;
            this.logiOper.Text = "+";
            // 
            // lblNumB
            // 
            this.lblNumB.AutoSize = true;
            this.lblNumB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumB.Location = new System.Drawing.Point(226, 107);
            this.lblNumB.Name = "lblNumB";
            this.lblNumB.Size = new System.Drawing.Size(36, 25);
            this.lblNumB.TabIndex = 3;
            this.lblNumB.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(309, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "=";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Lime;
            this.lblStatus.Location = new System.Drawing.Point(70, 169);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(97, 29);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "correct";
            // 
            // lblAnswer
            // 
            this.lblAnswer.Location = new System.Drawing.Point(370, 100);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(100, 36);
            this.lblAnswer.TabIndex = 6;
            this.lblAnswer.TextChanged += new System.EventHandler(this.CheckAnswer);
            // 
            // lblSubmit
            // 
            this.lblSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmit.Location = new System.Drawing.Point(562, 101);
            this.lblSubmit.Name = "lblSubmit";
            this.lblSubmit.Size = new System.Drawing.Size(75, 35);
            this.lblSubmit.TabIndex = 7;
            this.lblSubmit.Text = "Submit";
            this.lblSubmit.UseVisualStyleBackColor = true;
            this.lblSubmit.Click += new System.EventHandler(this.CheckBtnSubmit);
            // 
            // lblQuesNum
            // 
            this.lblQuesNum.AutoSize = true;
            this.lblQuesNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuesNum.Location = new System.Drawing.Point(12, 107);
            this.lblQuesNum.Name = "lblQuesNum";
            this.lblQuesNum.Size = new System.Drawing.Size(24, 25);
            this.lblQuesNum.TabIndex = 8;
            this.lblQuesNum.Text = "0";
            // 
            // lblComplete
            // 
            this.lblComplete.AutoSize = true;
            this.lblComplete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComplete.ForeColor = System.Drawing.Color.Lime;
            this.lblComplete.Location = new System.Drawing.Point(70, 231);
            this.lblComplete.Name = "lblComplete";
            this.lblComplete.Size = new System.Drawing.Size(145, 29);
            this.lblComplete.TabIndex = 9;
            this.lblComplete.Text = "Completed";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.Lime;
            this.lblScore.Location = new System.Drawing.Point(70, 283);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(84, 29);
            this.lblScore.TabIndex = 10;
            this.lblScore.Text = "Score";
            // 
            // lblPercent
            // 
            this.lblPercent.AutoSize = true;
            this.lblPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercent.ForeColor = System.Drawing.Color.Lime;
            this.lblPercent.Location = new System.Drawing.Point(70, 332);
            this.lblPercent.Name = "lblPercent";
            this.lblPercent.Size = new System.Drawing.Size(152, 29);
            this.lblPercent.TabIndex = 11;
            this.lblPercent.Text = "Percentage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(12, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 29);
            this.label2.TabIndex = 12;
            this.label2.Text = "Questions";
            // 
            // lblRestart
            // 
            this.lblRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestart.Location = new System.Drawing.Point(75, 390);
            this.lblRestart.Name = "lblRestart";
            this.lblRestart.Size = new System.Drawing.Size(91, 31);
            this.lblRestart.TabIndex = 13;
            this.lblRestart.Text = "Restart";
            this.lblRestart.UseVisualStyleBackColor = true;
            this.lblRestart.Click += new System.EventHandler(this.lblRestart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 480);
            this.Controls.Add(this.lblRestart);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPercent);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblComplete);
            this.Controls.Add(this.lblQuesNum);
            this.Controls.Add(this.lblSubmit);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNumB);
            this.Controls.Add(this.logiOper);
            this.Controls.Add(this.lblNumA);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNumA;
        private System.Windows.Forms.Label logiOper;
        private System.Windows.Forms.Label lblNumB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox lblAnswer;
        private System.Windows.Forms.Button lblSubmit;
        private System.Windows.Forms.Label lblQuesNum;
        private System.Windows.Forms.Label lblComplete;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblPercent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button lblRestart;
    }
}

