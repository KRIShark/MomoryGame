namespace MomoryGame
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
            this.groupBoxGameWi = new System.Windows.Forms.GroupBox();
            this.buttonRightDown = new System.Windows.Forms.Button();
            this.buttonRightUp = new System.Windows.Forms.Button();
            this.buttonLeftDown = new System.Windows.Forms.Button();
            this.buttonLeftUp = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.textBoxPlayerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelrounds = new System.Windows.Forms.Label();
            this.labelWinns = new System.Windows.Forms.Label();
            this.labelfails = new System.Windows.Forms.Label();
            this.labelplayerName = new System.Windows.Forms.Label();
            this.buttonCech = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.labelMoveDone = new System.Windows.Forms.Label();
            this.groupBoxGameWi.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxGameWi
            // 
            this.groupBoxGameWi.Controls.Add(this.buttonRightDown);
            this.groupBoxGameWi.Controls.Add(this.buttonRightUp);
            this.groupBoxGameWi.Controls.Add(this.buttonLeftDown);
            this.groupBoxGameWi.Controls.Add(this.buttonLeftUp);
            this.groupBoxGameWi.Location = new System.Drawing.Point(10, 94);
            this.groupBoxGameWi.Name = "groupBoxGameWi";
            this.groupBoxGameWi.Size = new System.Drawing.Size(256, 222);
            this.groupBoxGameWi.TabIndex = 0;
            this.groupBoxGameWi.TabStop = false;
            this.groupBoxGameWi.Text = "Game";
            // 
            // buttonRightDown
            // 
            this.buttonRightDown.Location = new System.Drawing.Point(131, 126);
            this.buttonRightDown.Name = "buttonRightDown";
            this.buttonRightDown.Size = new System.Drawing.Size(119, 85);
            this.buttonRightDown.TabIndex = 0;
            this.buttonRightDown.UseVisualStyleBackColor = true;
            this.buttonRightDown.Click += new System.EventHandler(this.buttonRightDown_Click);
            // 
            // buttonRightUp
            // 
            this.buttonRightUp.Location = new System.Drawing.Point(131, 35);
            this.buttonRightUp.Name = "buttonRightUp";
            this.buttonRightUp.Size = new System.Drawing.Size(119, 85);
            this.buttonRightUp.TabIndex = 0;
            this.buttonRightUp.UseVisualStyleBackColor = true;
            this.buttonRightUp.Click += new System.EventHandler(this.buttonRightUp_Click);
            // 
            // buttonLeftDown
            // 
            this.buttonLeftDown.Location = new System.Drawing.Point(6, 126);
            this.buttonLeftDown.Name = "buttonLeftDown";
            this.buttonLeftDown.Size = new System.Drawing.Size(119, 85);
            this.buttonLeftDown.TabIndex = 0;
            this.buttonLeftDown.UseVisualStyleBackColor = true;
            this.buttonLeftDown.Click += new System.EventHandler(this.buttonLeftDown_Click);
            // 
            // buttonLeftUp
            // 
            this.buttonLeftUp.Location = new System.Drawing.Point(9, 35);
            this.buttonLeftUp.Name = "buttonLeftUp";
            this.buttonLeftUp.Size = new System.Drawing.Size(119, 85);
            this.buttonLeftUp.TabIndex = 0;
            this.buttonLeftUp.UseVisualStyleBackColor = true;
            this.buttonLeftUp.Click += new System.EventHandler(this.buttonLeftUp_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(16, 338);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(122, 23);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStartGame_Click);
            // 
            // textBoxPlayerName
            // 
            this.textBoxPlayerName.Location = new System.Drawing.Point(16, 387);
            this.textBoxPlayerName.Name = "textBoxPlayerName";
            this.textBoxPlayerName.Size = new System.Drawing.Size(244, 20);
            this.textBoxPlayerName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PlayerName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "rounds";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "winns";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "fails";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "playerName";
            // 
            // labelrounds
            // 
            this.labelrounds.AutoSize = true;
            this.labelrounds.Location = new System.Drawing.Point(55, 13);
            this.labelrounds.Name = "labelrounds";
            this.labelrounds.Size = new System.Drawing.Size(13, 13);
            this.labelrounds.TabIndex = 4;
            this.labelrounds.Text = "0";
            // 
            // labelWinns
            // 
            this.labelWinns.AutoSize = true;
            this.labelWinns.Location = new System.Drawing.Point(55, 30);
            this.labelWinns.Name = "labelWinns";
            this.labelWinns.Size = new System.Drawing.Size(13, 13);
            this.labelWinns.TabIndex = 5;
            this.labelWinns.Text = "0";
            // 
            // labelfails
            // 
            this.labelfails.AutoSize = true;
            this.labelfails.Location = new System.Drawing.Point(55, 47);
            this.labelfails.Name = "labelfails";
            this.labelfails.Size = new System.Drawing.Size(13, 13);
            this.labelfails.TabIndex = 6;
            this.labelfails.Text = "0";
            // 
            // labelplayerName
            // 
            this.labelplayerName.AutoSize = true;
            this.labelplayerName.Location = new System.Drawing.Point(79, 64);
            this.labelplayerName.Name = "labelplayerName";
            this.labelplayerName.Size = new System.Drawing.Size(27, 13);
            this.labelplayerName.TabIndex = 7;
            this.labelplayerName.Text = "N/A";
            // 
            // buttonCech
            // 
            this.buttonCech.Enabled = false;
            this.buttonCech.Location = new System.Drawing.Point(144, 338);
            this.buttonCech.Name = "buttonCech";
            this.buttonCech.Size = new System.Drawing.Size(116, 23);
            this.buttonCech.TabIndex = 1;
            this.buttonCech.Text = "Check";
            this.buttonCech.UseVisualStyleBackColor = true;
            this.buttonCech.Click += new System.EventHandler(this.buttonCech_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(185, 8);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 8;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(157, 64);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(60, 13);
            this.label22.TabIndex = 7;
            this.label22.Text = "MoveDone";
            // 
            // labelMoveDone
            // 
            this.labelMoveDone.AutoSize = true;
            this.labelMoveDone.Location = new System.Drawing.Point(226, 64);
            this.labelMoveDone.Name = "labelMoveDone";
            this.labelMoveDone.Size = new System.Drawing.Size(13, 13);
            this.labelMoveDone.TabIndex = 7;
            this.labelMoveDone.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 420);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelMoveDone);
            this.Controls.Add(this.labelplayerName);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelfails);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelWinns);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelrounds);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPlayerName);
            this.Controls.Add(this.buttonCech);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.groupBoxGameWi);
            this.Name = "Form1";
            this.Text = "Memory";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.groupBoxGameWi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxGameWi;
        private System.Windows.Forms.Button buttonRightDown;
        private System.Windows.Forms.Button buttonRightUp;
        private System.Windows.Forms.Button buttonLeftDown;
        private System.Windows.Forms.Button buttonLeftUp;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.TextBox textBoxPlayerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelrounds;
        private System.Windows.Forms.Label labelWinns;
        private System.Windows.Forms.Label labelfails;
        private System.Windows.Forms.Label labelplayerName;
        private System.Windows.Forms.Button buttonCech;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label labelMoveDone;
    }
}

