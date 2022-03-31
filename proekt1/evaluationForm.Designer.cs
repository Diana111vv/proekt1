
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
            this.pictures1 = new System.Windows.Forms.PictureBox();
            this.picture2 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.next = new System.Windows.Forms.Button();
            this.MiMiMiMetr = new System.Windows.Forms.Label();
            this.Instruction = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictures1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).BeginInit();
            this.SuspendLayout();
            // 
            // choose1
            // 
            this.choose1.Anchor = System.Windows.Forms.AnchorStyles.Left;
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
            this.choose2.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            // pictures1
            // 
            this.pictures1.Location = new System.Drawing.Point(77, 128);
            this.pictures1.MaximumSize = new System.Drawing.Size(500, 400);
            this.pictures1.Name = "pictures1";
            this.pictures1.Size = new System.Drawing.Size(500, 400);
            this.pictures1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictures1.TabIndex = 2;
            this.pictures1.TabStop = false;
            this.pictures1.Click += new System.EventHandler(this.pictures1_Click);
            // 
            // picture2
            // 
            this.picture2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
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
            // next
            // 
            this.next.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.next.Location = new System.Drawing.Point(558, 600);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(94, 29);
            this.next.TabIndex = 4;
            this.next.Text = "Далее";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // MiMiMiMetr
            // 
            this.MiMiMiMetr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MiMiMiMetr.AutoSize = true;
            this.MiMiMiMetr.Location = new System.Drawing.Point(541, 23);
            this.MiMiMiMetr.Name = "MiMiMiMetr";
            this.MiMiMiMetr.Size = new System.Drawing.Size(111, 20);
            this.MiMiMiMetr.TabIndex = 300;
            this.MiMiMiMetr.Text = "МиМиМиМетр";
            // 
            // Instruction
            // 
            this.Instruction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Instruction.AutoSize = true;
            this.Instruction.Location = new System.Drawing.Point(188, 56);
            this.Instruction.MinimumSize = new System.Drawing.Size(60, 60);
            this.Instruction.Name = "Instruction";
            this.Instruction.Size = new System.Drawing.Size(827, 60);
            this.Instruction.TabIndex = 500;
            this.Instruction.Text = "Кто же из этих альпак самый мимимишный? Давай узнаем твое мнение. Чтобы выбрать п" +
    "росто кликни по картинке";
            // 
            // evaluationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.Instruction);
            this.Controls.Add(this.MiMiMiMetr);
            this.Controls.Add(this.next);
            this.Controls.Add(this.picture2);
            this.Controls.Add(this.pictures1);
            this.Controls.Add(this.choose2);
            this.Controls.Add(this.choose1);
            this.MaximumSize = new System.Drawing.Size(1200, 800);
            this.Name = "evaluationForm";
            this.Text = "evaluationForm";
            this.Load += new System.EventHandler(this.evaluationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictures1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picture2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton choose1;
        private System.Windows.Forms.RadioButton choose2;
        private System.Windows.Forms.PictureBox pictures1;
        private System.Windows.Forms.PictureBox picture2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.Label MiMiMiMetr;
        private System.Windows.Forms.Label Instruction;
    }
}