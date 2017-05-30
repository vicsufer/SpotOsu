namespace SpotOsu
{
    partial class FormLinkable
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
            this.pnLabels = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnLabels
            // 
            this.pnLabels.Location = new System.Drawing.Point(11, 14);
            this.pnLabels.Name = "pnLabels";
            this.pnLabels.Size = new System.Drawing.Size(333, 128);
            this.pnLabels.TabIndex = 0;
            // 
            // FormLinkable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 148);
            this.Controls.Add(this.pnLabels);
            this.Name = "FormLinkable";
            this.Text = "FormLinkable";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnLabels;
    }
}