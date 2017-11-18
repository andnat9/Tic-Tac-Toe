namespace Andre_Cherrier_Project_1
{
    partial class ticTacToeBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ticTacToeBoard));
            this.nameButton = new System.Windows.Forms.Button();
            this.gameName = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.ticTacBox = new System.Windows.Forms.GroupBox();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.threeThree = new System.Windows.Forms.Button();
            this.threeTwo = new System.Windows.Forms.Button();
            this.threeOne = new System.Windows.Forms.Button();
            this.twoThree = new System.Windows.Forms.Button();
            this.twoTwo = new System.Windows.Forms.Button();
            this.twoOne = new System.Windows.Forms.Button();
            this.oneThree = new System.Windows.Forms.Button();
            this.oneTwo = new System.Windows.Forms.Button();
            this.oneOne = new System.Windows.Forms.Button();
            this.moose = new System.Windows.Forms.PictureBox();
            this.bearPicture = new System.Windows.Forms.PictureBox();
            this.ticTacToePicture = new System.Windows.Forms.PictureBox();
            this.playerOneScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.playerTwoScore = new System.Windows.Forms.Label();
            this.playAgain = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.playerOne = new System.Windows.Forms.Label();
            this.xButton = new System.Windows.Forms.RadioButton();
            this.oButton = new System.Windows.Forms.RadioButton();
            this.ticTacBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bearPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticTacToePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // nameButton
            // 
            this.nameButton.BackColor = System.Drawing.SystemColors.Control;
            this.nameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameButton.Location = new System.Drawing.Point(62, 77);
            this.nameButton.Name = "nameButton";
            this.nameButton.Size = new System.Drawing.Size(114, 25);
            this.nameButton.TabIndex = 0;
            this.nameButton.Text = "Enter Name:";
            this.nameButton.UseVisualStyleBackColor = false;
            this.nameButton.Click += new System.EventHandler(this.name_Click);
            // 
            // gameName
            // 
            this.gameName.AutoSize = true;
            this.gameName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameName.Location = new System.Drawing.Point(375, 214);
            this.gameName.Name = "gameName";
            this.gameName.Size = new System.Drawing.Size(0, 24);
            this.gameName.TabIndex = 1;
            this.gameName.Click += new System.EventHandler(this.gameName_Click);
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(182, 79);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(112, 20);
            this.nameBox.TabIndex = 2;
            this.nameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ticTacBox
            // 
            this.ticTacBox.Controls.Add(this.winnerLabel);
            this.ticTacBox.Controls.Add(this.threeThree);
            this.ticTacBox.Controls.Add(this.threeTwo);
            this.ticTacBox.Controls.Add(this.threeOne);
            this.ticTacBox.Controls.Add(this.twoThree);
            this.ticTacBox.Controls.Add(this.twoTwo);
            this.ticTacBox.Controls.Add(this.twoOne);
            this.ticTacBox.Controls.Add(this.oneThree);
            this.ticTacBox.Controls.Add(this.oneTwo);
            this.ticTacBox.Controls.Add(this.oneOne);
            this.ticTacBox.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticTacBox.Location = new System.Drawing.Point(298, 238);
            this.ticTacBox.Name = "ticTacBox";
            this.ticTacBox.Size = new System.Drawing.Size(434, 373);
            this.ticTacBox.TabIndex = 3;
            this.ticTacBox.TabStop = false;
            this.ticTacBox.Text = "Player 1 goes first.";
            this.ticTacBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // winnerLabel
            // 
            this.winnerLabel.AutoSize = true;
            this.winnerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerLabel.Location = new System.Drawing.Point(81, 334);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(0, 25);
            this.winnerLabel.TabIndex = 13;
            // 
            // threeThree
            // 
            this.threeThree.BackColor = System.Drawing.Color.Gainsboro;
            this.threeThree.Location = new System.Drawing.Point(271, 233);
            this.threeThree.Name = "threeThree";
            this.threeThree.Size = new System.Drawing.Size(91, 88);
            this.threeThree.TabIndex = 12;
            this.threeThree.Text = "Click Here";
            this.threeThree.UseVisualStyleBackColor = false;
            this.threeThree.Click += new System.EventHandler(this.threeThree_Click);
            // 
            // threeTwo
            // 
            this.threeTwo.BackColor = System.Drawing.Color.Gainsboro;
            this.threeTwo.Location = new System.Drawing.Point(174, 233);
            this.threeTwo.Name = "threeTwo";
            this.threeTwo.Size = new System.Drawing.Size(91, 88);
            this.threeTwo.TabIndex = 11;
            this.threeTwo.Text = "Click Here";
            this.threeTwo.UseVisualStyleBackColor = false;
            this.threeTwo.Click += new System.EventHandler(this.threeTwo_Click);
            // 
            // threeOne
            // 
            this.threeOne.BackColor = System.Drawing.Color.Gainsboro;
            this.threeOne.Location = new System.Drawing.Point(77, 233);
            this.threeOne.Name = "threeOne";
            this.threeOne.Size = new System.Drawing.Size(91, 88);
            this.threeOne.TabIndex = 10;
            this.threeOne.Text = "Click Here";
            this.threeOne.UseVisualStyleBackColor = false;
            this.threeOne.Click += new System.EventHandler(this.threeOne_Click);
            // 
            // twoThree
            // 
            this.twoThree.BackColor = System.Drawing.Color.Gainsboro;
            this.twoThree.Location = new System.Drawing.Point(271, 139);
            this.twoThree.Name = "twoThree";
            this.twoThree.Size = new System.Drawing.Size(91, 88);
            this.twoThree.TabIndex = 9;
            this.twoThree.Text = "Click Here";
            this.twoThree.UseVisualStyleBackColor = false;
            this.twoThree.Click += new System.EventHandler(this.twoThree_Click);
            // 
            // twoTwo
            // 
            this.twoTwo.BackColor = System.Drawing.Color.Gainsboro;
            this.twoTwo.Location = new System.Drawing.Point(174, 139);
            this.twoTwo.Name = "twoTwo";
            this.twoTwo.Size = new System.Drawing.Size(91, 88);
            this.twoTwo.TabIndex = 8;
            this.twoTwo.Text = "Click Here";
            this.twoTwo.UseVisualStyleBackColor = false;
            this.twoTwo.Click += new System.EventHandler(this.twoTwo_Click);
            // 
            // twoOne
            // 
            this.twoOne.BackColor = System.Drawing.Color.Gainsboro;
            this.twoOne.Location = new System.Drawing.Point(77, 139);
            this.twoOne.Name = "twoOne";
            this.twoOne.Size = new System.Drawing.Size(91, 88);
            this.twoOne.TabIndex = 7;
            this.twoOne.Text = "Click Here";
            this.twoOne.UseVisualStyleBackColor = false;
            this.twoOne.Click += new System.EventHandler(this.twoOne_Click);
            // 
            // oneThree
            // 
            this.oneThree.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.oneThree.BackColor = System.Drawing.Color.Gainsboro;
            this.oneThree.Location = new System.Drawing.Point(271, 45);
            this.oneThree.Name = "oneThree";
            this.oneThree.Size = new System.Drawing.Size(91, 88);
            this.oneThree.TabIndex = 6;
            this.oneThree.Text = "Click Here";
            this.oneThree.UseVisualStyleBackColor = false;
            this.oneThree.Click += new System.EventHandler(this.oneThree_Click);
            // 
            // oneTwo
            // 
            this.oneTwo.BackColor = System.Drawing.Color.Gainsboro;
            this.oneTwo.Location = new System.Drawing.Point(174, 45);
            this.oneTwo.Name = "oneTwo";
            this.oneTwo.Size = new System.Drawing.Size(91, 88);
            this.oneTwo.TabIndex = 5;
            this.oneTwo.Text = "Click Here";
            this.oneTwo.UseVisualStyleBackColor = false;
            this.oneTwo.Click += new System.EventHandler(this.oneTwo_Click);
            // 
            // oneOne
            // 
            this.oneOne.BackColor = System.Drawing.Color.Gainsboro;
            this.oneOne.Location = new System.Drawing.Point(77, 45);
            this.oneOne.Name = "oneOne";
            this.oneOne.Size = new System.Drawing.Size(91, 88);
            this.oneOne.TabIndex = 4;
            this.oneOne.Text = "Click Here";
            this.oneOne.UseVisualStyleBackColor = false;
            this.oneOne.Click += new System.EventHandler(this.button1_Click);
            // 
            // moose
            // 
            this.moose.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.moose.Image = ((System.Drawing.Image)(resources.GetObject("moose.Image")));
            this.moose.Location = new System.Drawing.Point(379, 12);
            this.moose.Name = "moose";
            this.moose.Size = new System.Drawing.Size(281, 187);
            this.moose.TabIndex = 0;
            this.moose.TabStop = false;
            this.moose.Visible = false;
            // 
            // bearPicture
            // 
            this.bearPicture.Image = ((System.Drawing.Image)(resources.GetObject("bearPicture.Image")));
            this.bearPicture.Location = new System.Drawing.Point(379, 12);
            this.bearPicture.Name = "bearPicture";
            this.bearPicture.Size = new System.Drawing.Size(281, 187);
            this.bearPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bearPicture.TabIndex = 13;
            this.bearPicture.TabStop = false;
            this.bearPicture.Visible = false;
            // 
            // ticTacToePicture
            // 
            this.ticTacToePicture.Image = ((System.Drawing.Image)(resources.GetObject("ticTacToePicture.Image")));
            this.ticTacToePicture.Location = new System.Drawing.Point(379, 12);
            this.ticTacToePicture.Name = "ticTacToePicture";
            this.ticTacToePicture.Size = new System.Drawing.Size(281, 187);
            this.ticTacToePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ticTacToePicture.TabIndex = 14;
            this.ticTacToePicture.TabStop = false;
            this.ticTacToePicture.Visible = false;
            // 
            // playerOneScore
            // 
            this.playerOneScore.AutoSize = true;
            this.playerOneScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerOneScore.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOneScore.Location = new System.Drawing.Point(756, 12);
            this.playerOneScore.Name = "playerOneScore";
            this.playerOneScore.Size = new System.Drawing.Size(190, 27);
            this.playerOneScore.TabIndex = 15;
            this.playerOneScore.Text = "Player 1 Score: 0";
            this.playerOneScore.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(847, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 16;
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // playerTwoScore
            // 
            this.playerTwoScore.AutoSize = true;
            this.playerTwoScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.playerTwoScore.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTwoScore.Location = new System.Drawing.Point(756, 48);
            this.playerTwoScore.Name = "playerTwoScore";
            this.playerTwoScore.Size = new System.Drawing.Size(190, 27);
            this.playerTwoScore.TabIndex = 17;
            this.playerTwoScore.Text = "Player 2 Score: 0";
            // 
            // playAgain
            // 
            this.playAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgain.Location = new System.Drawing.Point(756, 139);
            this.playAgain.Name = "playAgain";
            this.playAgain.Size = new System.Drawing.Size(185, 30);
            this.playAgain.TabIndex = 18;
            this.playAgain.Text = "Play Again!";
            this.playAgain.UseVisualStyleBackColor = true;
            this.playAgain.Visible = false;
            this.playAgain.Click += new System.EventHandler(this.playAgain_Click);
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.resetButton.Location = new System.Drawing.Point(756, 103);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(183, 30);
            this.resetButton.TabIndex = 19;
            this.resetButton.Text = "Reset Scoreboard";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // playerOne
            // 
            this.playerOne.AutoSize = true;
            this.playerOne.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOne.Location = new System.Drawing.Point(65, 127);
            this.playerOne.Name = "playerOne";
            this.playerOne.Size = new System.Drawing.Size(86, 18);
            this.playerOne.TabIndex = 20;
            this.playerOne.Text = "Player 1:";
            // 
            // xButton
            // 
            this.xButton.AutoSize = true;
            this.xButton.Checked = true;
            this.xButton.Location = new System.Drawing.Point(68, 152);
            this.xButton.Name = "xButton";
            this.xButton.Size = new System.Drawing.Size(39, 17);
            this.xButton.TabIndex = 21;
            this.xButton.TabStop = true;
            this.xButton.Text = "X\'s";
            this.xButton.UseVisualStyleBackColor = true;
            this.xButton.CheckedChanged += new System.EventHandler(this.xButton_CheckedChanged);
            // 
            // oButton
            // 
            this.oButton.AutoSize = true;
            this.oButton.Location = new System.Drawing.Point(68, 175);
            this.oButton.Name = "oButton";
            this.oButton.Size = new System.Drawing.Size(40, 17);
            this.oButton.TabIndex = 22;
            this.oButton.Text = "O\'s";
            this.oButton.UseVisualStyleBackColor = true;
            this.oButton.CheckedChanged += new System.EventHandler(this.oButton_CheckedChanged);
            // 
            // ticTacToeBoard
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1049, 623);
            this.Controls.Add(this.oButton);
            this.Controls.Add(this.xButton);
            this.Controls.Add(this.playerOne);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.playAgain);
            this.Controls.Add(this.playerTwoScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.playerOneScore);
            this.Controls.Add(this.ticTacToePicture);
            this.Controls.Add(this.bearPicture);
            this.Controls.Add(this.moose);
            this.Controls.Add(this.ticTacBox);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.gameName);
            this.Controls.Add(this.nameButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "ticTacToeBoard";
            this.Text = "Tic Tac Toe Board";
            this.ticTacBox.ResumeLayout(false);
            this.ticTacBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.moose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bearPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticTacToePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nameButton;
        private System.Windows.Forms.Label gameName;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.GroupBox ticTacBox;
        private System.Windows.Forms.PictureBox moose;
        private System.Windows.Forms.Button oneOne;
        private System.Windows.Forms.Button threeThree;
        private System.Windows.Forms.Button threeTwo;
        private System.Windows.Forms.Button threeOne;
        private System.Windows.Forms.Button twoThree;
        private System.Windows.Forms.Button twoTwo;
        private System.Windows.Forms.Button twoOne;
        private System.Windows.Forms.Button oneThree;
        private System.Windows.Forms.Button oneTwo;
        private System.Windows.Forms.PictureBox bearPicture;
        private System.Windows.Forms.PictureBox ticTacToePicture;
        private System.Windows.Forms.Label winnerLabel;
        private System.Windows.Forms.Label playerOneScore;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label playerTwoScore;
        private System.Windows.Forms.Button playAgain;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label playerOne;
        private System.Windows.Forms.RadioButton xButton;
        private System.Windows.Forms.RadioButton oButton;
    }
}

