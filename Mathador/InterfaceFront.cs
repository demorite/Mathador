using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mathador
{
    public partial class InterfaceFront : Form
    {
        private Label generateur;
        private IContainer components;

        public InterfaceFront()
        {
            InitializeComponent();

            generateur.Text = new Generateur().ToString();

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfaceFront));
            this.generateur = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // generateur
            // 
            this.generateur.AutoSize = true;
            this.generateur.Location = new System.Drawing.Point(13, 13);
            this.generateur.Name = "generateur";
            this.generateur.Size = new System.Drawing.Size(66, 13);
            this.generateur.TabIndex = 0;
            this.generateur.Text = "Generateur :";
            // 
            // InterfaceFront
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 700);
            this.Controls.Add(this.generateur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InterfaceFront";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
