
namespace proekt1
{
    partial class main
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
            this.InstructionButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.pictureBoxWinner = new System.Windows.Forms.PictureBox();
            this.nameOfGame = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWinner)).BeginInit();
            this.SuspendLayout();
            // 
            // InstructionButton
            // 
            this.InstructionButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InstructionButton.Location = new System.Drawing.Point(74, 522);
            this.InstructionButton.Name = "InstructionButton";
            this.InstructionButton.Size = new System.Drawing.Size(152, 29);
            this.InstructionButton.TabIndex = 2;
            this.InstructionButton.Text = "Инструкция";
            this.InstructionButton.UseVisualStyleBackColor = true;
            this.InstructionButton.Click += new System.EventHandler(this.InstructionButton_Click);
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startButton.Location = new System.Drawing.Point(548, 522);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(168, 29);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "Начать все заново";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // pictureBoxWinner
            // 
            this.pictureBoxWinner.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxWinner.Location = new System.Drawing.Point(152, 66);
            this.pictureBoxWinner.MaximumSize = new System.Drawing.Size(500, 450);
            this.pictureBoxWinner.Name = "pictureBoxWinner";
            this.pictureBoxWinner.Size = new System.Drawing.Size(500, 450);
            this.pictureBoxWinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWinner.TabIndex = 4;
            this.pictureBoxWinner.TabStop = false;
            // 
            // nameOfGame
            // 
            this.nameOfGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameOfGame.AutoSize = true;
            this.nameOfGame.BackColor = System.Drawing.Color.BlueViolet;
            this.nameOfGame.Location = new System.Drawing.Point(348, 36);
            this.nameOfGame.Name = "nameOfGame";
            this.nameOfGame.Size = new System.Drawing.Size(93, 20);
            this.nameOfGame.TabIndex = 5;
            this.nameOfGame.Text = "ТОП Альпак";
            this.nameOfGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 653);
            this.Controls.Add(this.nameOfGame);
            this.Controls.Add(this.pictureBoxWinner);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.InstructionButton);
            this.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.MinimumSize = new System.Drawing.Size(800, 700);
            this.Name = "main";
            this.Text = "mainForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button InstructionButton;
        private System.Windows.Forms.Button startButton;
        public System.Windows.Forms.PictureBox pictureBoxWinner;
        private System.Windows.Forms.Label nameOfGame;
    }
}

