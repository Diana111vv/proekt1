
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
            this.readPictures1 = new System.Windows.Forms.PictureBox();
            this.picture2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.readPictures1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).BeginInit();
            this.SuspendLayout();
            // 
            // choose1
            // 
            this.choose1.AutoSize = true;
            this.choose1.Location = new System.Drawing.Point(277, 566);
            this.choose1.Name = "choose1";
            this.choose1.Size = new System.Drawing.Size(53, 24);
            this.choose1.TabIndex = 0;
            this.choose1.TabStop = true;
            this.choose1.Text = "Эта";
            this.choose1.UseVisualStyleBackColor = true;
            this.choose1.Click += new System.EventHandler(this.choose1_Click);
            // 
            // choose2
            // 
            this.choose2.AutoSize = true;
            this.choose2.Location = new System.Drawing.Point(785, 566);
            this.choose2.Name = "choose2";
            this.choose2.Size = new System.Drawing.Size(82, 24);
            this.choose2.TabIndex = 1;
            this.choose2.TabStop = true;
            this.choose2.Text = "Нет Эта";
            this.choose2.UseVisualStyleBackColor = true;
            this.choose2.Click += new System.EventHandler(this.choose2_Click);
            // 
            // readPictures1
            // 
            this.readPictures1.Location = new System.Drawing.Point(77, 128);
            this.readPictures1.MaximumSize = new System.Drawing.Size(500, 400);
            this.readPictures1.Name = "readPictures1";
            this.readPictures1.Size = new System.Drawing.Size(500, 400);
            this.readPictures1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.readPictures1.TabIndex = 2;
            this.readPictures1.TabStop = false;
            this.readPictures1.Click += new System.EventHandler(this.readPictures1_Click);
            // 
            // picture2
            // 
            this.picture2.Location = new System.Drawing.Point(605, 128);
            this.picture2.MinimumSize = new System.Drawing.Size(500, 400);
            this.picture2.Name = "picture2";
            this.picture2.Size = new System.Drawing.Size(500, 400);
            this.picture2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture2.TabIndex = 3;
            this.picture2.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(558, 600);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Далее";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // evaluationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picture2);
            this.Controls.Add(this.readPictures1);
            this.Controls.Add(this.choose2);
            this.Controls.Add(this.choose1);
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.Name = "evaluationForm";
            this.Text = "evaluationForm";
            this.Load += new System.EventHandler(this.evaluationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.readPictures1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton choose1;
        private System.Windows.Forms.RadioButton choose2;
        private System.Windows.Forms.PictureBox readPictures1;
        private System.Windows.Forms.PictureBox picture2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
    }
}