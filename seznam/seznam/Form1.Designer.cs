namespace seznam
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
            this.pridat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pridat
            // 
            this.pridat.Location = new System.Drawing.Point(12, 12);
            this.pridat.Name = "pridat";
            this.pridat.Size = new System.Drawing.Size(28, 26);
            this.pridat.TabIndex = 3;
            this.pridat.Text = "+";
            this.pridat.UseVisualStyleBackColor = true;
            this.pridat.Click += new System.EventHandler(this.pridat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pridat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button pridat;
    }
}

