
namespace proekt1
{
    partial class evaluationForm
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
            this.choose1 = new System.Windows.Forms.RadioButton();
            this.choose2 = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // choose1
            // 
            this.choose1.AutoSize = true;
            this.choose1.Location = new System.Drawing.Point(179, 335);
            this.choose1.Name = "choose1";
            this.choose1.Size = new System.Drawing.Size(119, 24);
            this.choose1.TabIndex = 0;
            this.choose1.TabStop = true;
            this.choose1.Text = "имя альпаки";
            this.choose1.UseVisualStyleBackColor = true;
            this.choose1.CheckedChanged += new System.EventHandler(this.choose1_CheckedChanged);
            // 
            // choose2
            // 
            this.choose2.AutoSize = true;
            this.choose2.Location = new System.Drawing.Point(469, 335);
            this.choose2.Name = "choose2";
            this.choose2.Size = new System.Drawing.Size(173, 24);
            this.choose2.TabIndex = 1;
            this.choose2.TabStop = true;
            this.choose2.Text = "имя второй альпаки";
            this.choose2.UseVisualStyleBackColor = true;
            this.choose2.CheckedChanged += new System.EventHandler(this.choose2_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(146, 115);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(178, 161);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(469, 115);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(179, 161);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // evaluationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.choose2);
            this.Controls.Add(this.choose1);
            this.Name = "evaluationForm";
            this.Text = "evaluationForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton choose1;
        private System.Windows.Forms.RadioButton choose2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}