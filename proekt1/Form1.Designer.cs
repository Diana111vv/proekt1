
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
            this.name = new System.Windows.Forms.TextBox();
            this.InstructionButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.pictureBoxWinner = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWinner)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.name.BackColor = System.Drawing.Color.MediumPurple;
            this.name.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.name.Location = new System.Drawing.Point(245, 36);
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Size = new System.Drawing.Size(277, 27);
            this.name.TabIndex = 0;
            this.name.Text = "                        Топ Альпак";
            // 
            // InstructionButton
            // 
            this.InstructionButton.Location = new System.Drawing.Point(90, 378);
            this.InstructionButton.Name = "InstructionButton";
            this.InstructionButton.Size = new System.Drawing.Size(152, 29);
            this.InstructionButton.TabIndex = 2;
            this.InstructionButton.Text = "Инструкция";
            this.InstructionButton.UseVisualStyleBackColor = true;
            this.InstructionButton.Click += new System.EventHandler(this.InstructionButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(523, 378);
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
            this.pictureBoxWinner.Location = new System.Drawing.Point(245, 81);
            this.pictureBoxWinner.Name = "pictureBoxWinner";
            this.pictureBoxWinner.Size = new System.Drawing.Size(277, 243);
            this.pictureBoxWinner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxWinner.TabIndex = 4;
            this.pictureBoxWinner.TabStop = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBoxWinner);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.InstructionButton);
            this.Controls.Add(this.name);
            this.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.Name = "main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWinner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button InstructionButton;
        private System.Windows.Forms.Button startButton;
        public System.Windows.Forms.PictureBox pictureBoxWinner;
    }
}

