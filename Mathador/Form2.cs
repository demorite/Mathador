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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void setListe(List<User> ul)
        {
            List<string> l = new List<string>();
            ul.ForEach(delegate (User user) {l.Add("Pseudo: "+user.pseudo+" / Nombres de parties: "+user.games_nb+" / HighScore: "+user.highscore);});
            listBox1.DataSource = l;
        }
    }
}
