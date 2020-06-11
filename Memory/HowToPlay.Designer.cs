namespace Memory
{
    partial class HowToPlay
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
            this.btnTutorial1 = new System.Windows.Forms.Button();
            this.btnTutorial2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTutorial1
            // 
            this.btnTutorial1.Location = new System.Drawing.Point(43, 88);
            this.btnTutorial1.Name = "btnTutorial1";
            this.btnTutorial1.Size = new System.Drawing.Size(64, 64);
            this.btnTutorial1.TabIndex = 0;
            this.btnTutorial1.UseVisualStyleBackColor = true;
            this.btnTutorial1.Click += new System.EventHandler(this.btnTutorial1_Click);
            // 
            // btnTutorial2
            // 
            this.btnTutorial2.Location = new System.Drawing.Point(154, 88);
            this.btnTutorial2.Name = "btnTutorial2";
            this.btnTutorial2.Size = new System.Drawing.Size(64, 64);
            this.btnTutorial2.TabIndex = 1;
            this.btnTutorial2.UseVisualStyleBackColor = true;
            this.btnTutorial2.Click += new System.EventHandler(this.btnTutorial2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Memory.Properties.Resources.Atlanta_Reign;
            this.pictureBox1.Location = new System.Drawing.Point(43, 88);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Memory.Properties.Resources.Atlanta_Reign;
            this.pictureBox2.Location = new System.Drawing.Point(154, 88);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Memory!";
            // 
            // HowToPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 174);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTutorial2);
            this.Controls.Add(this.btnTutorial1);
            this.Name = "HowToPlay";
            this.Text = "HowToPlay";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HowToPlay_FormClosing);
            this.Load += new System.EventHandler(this.HowToPlay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTutorial1;
        private System.Windows.Forms.Button btnTutorial2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}