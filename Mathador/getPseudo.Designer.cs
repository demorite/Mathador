namespace Mathador
{
    partial class getPseudo
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
            this.b_pseudo = new System.Windows.Forms.Button();
            this.text_pseudo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // b_pseudo
            // 
            this.b_pseudo.Location = new System.Drawing.Point(197, 12);
            this.b_pseudo.Name = "b_pseudo";
            this.b_pseudo.Size = new System.Drawing.Size(75, 20);
            this.b_pseudo.TabIndex = 0;
            this.b_pseudo.Text = "valider";
            this.b_pseudo.UseVisualStyleBackColor = true;
            this.b_pseudo.Click += new System.EventHandler(this.b_pseudo_Click);
            // 
            // text_pseudo
            // 
            this.text_pseudo.Location = new System.Drawing.Point(12, 12);
            this.text_pseudo.Name = "text_pseudo";
            this.text_pseudo.Size = new System.Drawing.Size(179, 20);
            this.text_pseudo.TabIndex = 1;
            // 
            // getPseudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 47);
            this.Controls.Add(this.text_pseudo);
            this.Controls.Add(this.b_pseudo);
            this.Name = "getPseudo";
            this.Text = "Pseudo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button b_pseudo;
        internal System.Windows.Forms.TextBox text_pseudo;
    }
}