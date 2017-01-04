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
        private Button b_genereate;
        private Label pseudo;
        private IContainer components;
        private Save save;

        public InterfaceFront()
        {
            InitializeComponent();

            generateur.Text = new Generateur().ToString();

        }

       
        private void b_genereate_Click(object sender, EventArgs e)
        {

            Generateur generated = new Generateur();
            string t_pseudo = "aaa";

            getPseudo formPseudo = new getPseudo();
            formPseudo.b_pseudo.Click += delegate (object o, EventArgs args)
            {
                save = new Save(formPseudo.text_pseudo.Text, generated.Tirage(), generated.TargetNumber);
                pseudo.Text = formPseudo.text_pseudo.Text != "" ? formPseudo.text_pseudo.Text  : "guest"+new Random().Next();
            };
            formPseudo.Show();
            generateur.Text = generated.ToString();
        }


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfaceFront));
            this.generateur = new System.Windows.Forms.Label();
            this.b_genereate = new System.Windows.Forms.Button();
            this.pseudo = new System.Windows.Forms.Label();
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
            // b_genereate
            // 
            this.b_genereate.Location = new System.Drawing.Point(937, 13);
            this.b_genereate.Name = "b_genereate";
            this.b_genereate.Size = new System.Drawing.Size(75, 23);
            this.b_genereate.TabIndex = 1;
            this.b_genereate.Text = "Générer";
            this.b_genereate.UseVisualStyleBackColor = true;
            this.b_genereate.Click += new System.EventHandler(this.b_genereate_Click);
            // 
            // pseudo
            // 
            this.pseudo.AutoSize = true;
            this.pseudo.Location = new System.Drawing.Point(461, 13);
            this.pseudo.Name = "pseudo";
            this.pseudo.Size = new System.Drawing.Size(0, 13);
            this.pseudo.TabIndex = 2;
            // 
            // InterfaceFront
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 700);
            this.Controls.Add(this.pseudo);
            this.Controls.Add(this.b_genereate);
            this.Controls.Add(this.generateur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InterfaceFront";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    }
}
