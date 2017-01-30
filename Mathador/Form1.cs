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
    public partial class Form1 : Form
    {
		List<User> datas = new List<User>();
		Database db = new Database();

        public Form1()
        {
            InitializeComponent();

			datas = db.getScores();

			if (datas != null) {

				listBox1.DataSource = datas
			}

        }
    }
}
