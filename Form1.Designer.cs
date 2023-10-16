namespace FrmBasicThread1
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
            this.bsThread = new System.Windows.Forms.Label();
            this.run1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bsThread
            // 
            this.bsThread.AutoSize = true;
            this.bsThread.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsThread.Location = new System.Drawing.Point(31, 37);
            this.bsThread.Name = "bsThread";
            this.bsThread.Size = new System.Drawing.Size(223, 24);
            this.bsThread.TabIndex = 0;
            this.bsThread.Text = "-Before starting thread-";
            // 
            // run1
            // 
            this.run1.BackColor = System.Drawing.Color.Aqua;
            this.run1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.run1.Location = new System.Drawing.Point(81, 81);
            this.run1.Name = "run1";
            this.run1.Size = new System.Drawing.Size(103, 46);
            this.run1.TabIndex = 1;
            this.run1.Text = "Run";
            this.run1.UseVisualStyleBackColor = false;
            this.run1.Click += new System.EventHandler(this.run1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(271, 146);
            this.Controls.Add(this.run1);
            this.Controls.Add(this.bsThread);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label bsThread;
        private System.Windows.Forms.Button run1;
    }
}

