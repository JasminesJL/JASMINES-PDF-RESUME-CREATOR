namespace JASMINES__PDF_RESUME_CREATOR
{
    partial class F1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F1));
            this.LblTITLE = new System.Windows.Forms.Label();
            this.ButtGEN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblTITLE
            // 
            this.LblTITLE.AutoSize = true;
            this.LblTITLE.Font = new System.Drawing.Font("Britannic Bold", 18F);
            this.LblTITLE.Location = new System.Drawing.Point(12, 24);
            this.LblTITLE.Name = "LblTITLE";
            this.LblTITLE.Size = new System.Drawing.Size(157, 27);
            this.LblTITLE.TabIndex = 0;
            this.LblTITLE.Text = "Generate PDF";
            // 
            // ButtGEN
            // 
            this.ButtGEN.BackColor = System.Drawing.Color.Khaki;
            this.ButtGEN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ButtGEN.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtGEN.Location = new System.Drawing.Point(302, 254);
            this.ButtGEN.Name = "ButtGEN";
            this.ButtGEN.Size = new System.Drawing.Size(109, 38);
            this.ButtGEN.TabIndex = 1;
            this.ButtGEN.Text = "Generate";
            this.ButtGEN.UseVisualStyleBackColor = false;
            this.ButtGEN.Click += new System.EventHandler(this.ButtGEN_Click);
            // 
            // F1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(436, 317);
            this.Controls.Add(this.ButtGEN);
            this.Controls.Add(this.LblTITLE);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F1";
            this.Text = "PDF RESUME CREATOR";
            this.Load += new System.EventHandler(this.F1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LblTITLE;
        private Button ButtGEN;
    }
}