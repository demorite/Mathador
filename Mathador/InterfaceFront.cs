using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mathador
{




    public partial class InterfaceFront : Form
    {
        private Button waitingNumber = null;
        private Button waitingOperator = null;
        private bool gamestart = false;

        private Button b_genereate;
        private Label pseudo;
        private IContainer components;
        private Button dice1;
        private Button dice2;
        private Button dice3;
        private Button dice4;
        private Button dice5;
        private Button plus_op;
        private Button moins_op;
        private Button mult_op;
        private Button div_op;
        private Label target_num;
        private Label solution;
        private Save save;

        public InterfaceFront()
        {
            InitializeComponent();
        }

       
        private void b_genereate_Click(object sender, EventArgs e)
        {
            resetAll();



            getPseudo formPseudo = new getPseudo();
            formPseudo.b_pseudo.Click += delegate (object o, EventArgs args)
            {
                Generateur generated = new Generateur();

                save = new Save(formPseudo.text_pseudo.Text, generated.Tirage(), generated.TargetNumber);
                pseudo.Text = formPseudo.text_pseudo.Text != "" ? formPseudo.text_pseudo.Text  : "guest"+new Random().Next();
                setDices(generated);
                target_num.Text = Convert.ToString(generated.TargetNumber);
                gamestart = true;
                solution.Text = generated.solution;
            };
            formPseudo.Show();
        }

        private void setDices(Generateur g)
        {
            List<int> alldices = g.getDices();
            dice1.Text = Convert.ToString(alldices[0]);
            dice2.Text = Convert.ToString(alldices[1]);
            dice3.Text = Convert.ToString(alldices[2]);
            dice4.Text = Convert.ToString(alldices[3]);
            dice5.Text = Convert.ToString(alldices[4]);
        }


        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InterfaceFront));
            this.b_genereate = new System.Windows.Forms.Button();
            this.pseudo = new System.Windows.Forms.Label();
            this.dice1 = new System.Windows.Forms.Button();
            this.dice2 = new System.Windows.Forms.Button();
            this.dice3 = new System.Windows.Forms.Button();
            this.dice4 = new System.Windows.Forms.Button();
            this.dice5 = new System.Windows.Forms.Button();
            this.plus_op = new System.Windows.Forms.Button();
            this.moins_op = new System.Windows.Forms.Button();
            this.mult_op = new System.Windows.Forms.Button();
            this.div_op = new System.Windows.Forms.Button();
            this.target_num = new System.Windows.Forms.Label();
            this.solution = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // b_genereate
            // 
            this.b_genereate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.b_genereate.Location = new System.Drawing.Point(937, 13);
            this.b_genereate.Name = "b_genereate";
            this.b_genereate.Size = new System.Drawing.Size(75, 23);
            this.b_genereate.TabIndex = 1;
            this.b_genereate.Text = "Générer";
            this.b_genereate.UseVisualStyleBackColor = false;
            this.b_genereate.Click += new System.EventHandler(this.b_genereate_Click);
            // 
            // pseudo
            // 
            this.pseudo.AutoSize = true;
            this.pseudo.Location = new System.Drawing.Point(12, 13);
            this.pseudo.Name = "pseudo";
            this.pseudo.Size = new System.Drawing.Size(0, 13);
            this.pseudo.TabIndex = 2;
            // 
            // dice1
            // 
            this.dice1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dice1.Location = new System.Drawing.Point(294, 184);
            this.dice1.MaximumSize = new System.Drawing.Size(70, 70);
            this.dice1.MinimumSize = new System.Drawing.Size(70, 70);
            this.dice1.Name = "dice1";
            this.dice1.Size = new System.Drawing.Size(70, 70);
            this.dice1.TabIndex = 3;
            this.dice1.UseVisualStyleBackColor = false;
            this.dice1.Click += new System.EventHandler(this.check_click);
            // 
            // dice2
            // 
            this.dice2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dice2.Location = new System.Drawing.Point(375, 184);
            this.dice2.MaximumSize = new System.Drawing.Size(70, 70);
            this.dice2.MinimumSize = new System.Drawing.Size(70, 70);
            this.dice2.Name = "dice2";
            this.dice2.Size = new System.Drawing.Size(70, 70);
            this.dice2.TabIndex = 4;
            this.dice2.UseVisualStyleBackColor = false;
            this.dice2.Click += new System.EventHandler(this.check_click);
            // 
            // dice3
            // 
            this.dice3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dice3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dice3.Location = new System.Drawing.Point(456, 184);
            this.dice3.MaximumSize = new System.Drawing.Size(70, 70);
            this.dice3.MinimumSize = new System.Drawing.Size(70, 70);
            this.dice3.Name = "dice3";
            this.dice3.Size = new System.Drawing.Size(70, 70);
            this.dice3.TabIndex = 5;
            this.dice3.UseVisualStyleBackColor = false;
            this.dice3.Click += new System.EventHandler(this.check_click);
            // 
            // dice4
            // 
            this.dice4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dice4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dice4.Location = new System.Drawing.Point(537, 184);
            this.dice4.MaximumSize = new System.Drawing.Size(70, 70);
            this.dice4.MinimumSize = new System.Drawing.Size(70, 70);
            this.dice4.Name = "dice4";
            this.dice4.Size = new System.Drawing.Size(70, 70);
            this.dice4.TabIndex = 6;
            this.dice4.UseVisualStyleBackColor = false;
            this.dice4.Click += new System.EventHandler(this.check_click);
            // 
            // dice5
            // 
            this.dice5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dice5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dice5.Location = new System.Drawing.Point(618, 184);
            this.dice5.MaximumSize = new System.Drawing.Size(70, 70);
            this.dice5.MinimumSize = new System.Drawing.Size(70, 70);
            this.dice5.Name = "dice5";
            this.dice5.Size = new System.Drawing.Size(70, 70);
            this.dice5.TabIndex = 7;
            this.dice5.UseVisualStyleBackColor = false;
            this.dice5.Click += new System.EventHandler(this.check_click);
            // 
            // plus_op
            // 
            this.plus_op.BackColor = System.Drawing.Color.WhiteSmoke;
            this.plus_op.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus_op.Location = new System.Drawing.Point(336, 330);
            this.plus_op.MaximumSize = new System.Drawing.Size(70, 70);
            this.plus_op.MinimumSize = new System.Drawing.Size(70, 70);
            this.plus_op.Name = "plus_op";
            this.plus_op.Size = new System.Drawing.Size(70, 70);
            this.plus_op.TabIndex = 8;
            this.plus_op.Text = "+";
            this.plus_op.UseVisualStyleBackColor = false;
            this.plus_op.Click += new System.EventHandler(this.check_click);
            // 
            // moins_op
            // 
            this.moins_op.BackColor = System.Drawing.Color.WhiteSmoke;
            this.moins_op.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moins_op.Location = new System.Drawing.Point(417, 330);
            this.moins_op.MaximumSize = new System.Drawing.Size(70, 70);
            this.moins_op.MinimumSize = new System.Drawing.Size(70, 70);
            this.moins_op.Name = "moins_op";
            this.moins_op.Size = new System.Drawing.Size(70, 70);
            this.moins_op.TabIndex = 9;
            this.moins_op.Text = "-";
            this.moins_op.UseVisualStyleBackColor = false;
            this.moins_op.Click += new System.EventHandler(this.check_click);
            // 
            // mult_op
            // 
            this.mult_op.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mult_op.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mult_op.Location = new System.Drawing.Point(498, 330);
            this.mult_op.MaximumSize = new System.Drawing.Size(70, 70);
            this.mult_op.MinimumSize = new System.Drawing.Size(70, 70);
            this.mult_op.Name = "mult_op";
            this.mult_op.Size = new System.Drawing.Size(70, 70);
            this.mult_op.TabIndex = 10;
            this.mult_op.Text = "x";
            this.mult_op.UseVisualStyleBackColor = false;
            this.mult_op.Click += new System.EventHandler(this.check_click);
            // 
            // div_op
            // 
            this.div_op.BackColor = System.Drawing.Color.WhiteSmoke;
            this.div_op.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div_op.Location = new System.Drawing.Point(579, 330);
            this.div_op.MaximumSize = new System.Drawing.Size(70, 70);
            this.div_op.MinimumSize = new System.Drawing.Size(70, 70);
            this.div_op.Name = "div_op";
            this.div_op.Size = new System.Drawing.Size(70, 70);
            this.div_op.TabIndex = 11;
            this.div_op.Text = ":";
            this.div_op.UseVisualStyleBackColor = false;
            this.div_op.Click += new System.EventHandler(this.check_click);
            // 
            // target_num
            // 
            this.target_num.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.target_num.AutoSize = true;
            this.target_num.BackColor = System.Drawing.Color.WhiteSmoke;
            this.target_num.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.target_num.Location = new System.Drawing.Point(455, 41);
            this.target_num.MaximumSize = new System.Drawing.Size(70, 70);
            this.target_num.MinimumSize = new System.Drawing.Size(70, 70);
            this.target_num.Name = "target_num";
            this.target_num.Size = new System.Drawing.Size(70, 70);
            this.target_num.TabIndex = 12;
            this.target_num.Text = "Cible";
            this.target_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // solution
            // 
            this.solution.AutoSize = true;
            this.solution.Location = new System.Drawing.Point(417, 431);
            this.solution.Name = "solution";
            this.solution.Size = new System.Drawing.Size(43, 13);
            this.solution.TabIndex = 13;
            this.solution.Text = "solution";
            // 
            // InterfaceFront
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 700);
            this.Controls.Add(this.solution);
            this.Controls.Add(this.target_num);
            this.Controls.Add(this.div_op);
            this.Controls.Add(this.mult_op);
            this.Controls.Add(this.moins_op);
            this.Controls.Add(this.plus_op);
            this.Controls.Add(this.dice5);
            this.Controls.Add(this.dice4);
            this.Controls.Add(this.dice3);
            this.Controls.Add(this.dice2);
            this.Controls.Add(this.dice1);
            this.Controls.Add(this.pseudo);
            this.Controls.Add(this.b_genereate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "InterfaceFront";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private bool isDice(Object sender)
            => (sender == dice1 || sender == dice2 || sender == dice3 || sender == dice4 || sender == dice5);

        private bool isOp(Object sender)
            => (sender == plus_op || sender == moins_op || sender == mult_op || sender == div_op);

        private void check_click(Object sender, EventArgs e)
        {
            if (gamestart)
            {
                Button b_sender = (Button)sender;

                
                if (isDice(sender) && waitingOperator == null && waitingNumber == null)
                {
                    waitingNumber = b_sender;
                    waitingNumber.BackColor = Color.BlueViolet;
                }
                else if (isOp(sender) && waitingOperator == null && waitingNumber != null)
                {
                    waitingOperator = b_sender;
                    waitingOperator.BackColor = Color.BlueViolet;
                }
                else if (isDice(sender) && waitingNumber != null && waitingOperator != null && waitingNumber != b_sender)
                {
                    string operateur = waitingOperator.Text == "x" ? "*" : waitingOperator.Text == ":" ? "/" : waitingOperator.Text;

                    string expression = waitingNumber.Text + operateur + b_sender.Text;

                    int result = -1;
                    switch (waitingOperator.Text)
                    {
                        case "+":
                            result = Convert.ToInt32(waitingNumber.Text) + Convert.ToInt32(b_sender.Text);
                            break;

                        case "x":
                            result = Convert.ToInt32(waitingNumber.Text) * Convert.ToInt32(b_sender.Text);
                            break;

                        case "-":
                            if (Convert.ToInt32(b_sender.Text) <= Convert.ToInt32(waitingNumber.Text))
                            {
                                result = Convert.ToInt32(waitingNumber.Text) - Convert.ToInt32(b_sender.Text);
                            }
                            break;

                        case ":":
                            if (Convert.ToInt32(b_sender.Text) > 0 && Convert.ToInt32(waitingNumber.Text) % Convert.ToInt32(b_sender.Text) == 0)
                            {
                                result = Convert.ToInt32(waitingNumber.Text) / Convert.ToInt32(b_sender.Text);
                            }
                            break;
                    }

                    if (result != -1)
                    {
                        b_sender.Text = Convert.ToString(result);
                        waitingNumber.Hide();
                    }
                    waitingNumber = null;
                    waitingOperator = null;
                    resetButton();
                    resetOp();
                }
                else
                {

                    waitingNumber = null;
                    waitingOperator = null;
                    resetButton();
                    resetOp();
                }
            }
        }

        private void resetButton()
        {
            dice1.BackColor = Color.WhiteSmoke;
            dice2.BackColor = Color.WhiteSmoke;
            dice3.BackColor = Color.WhiteSmoke;
            dice4.BackColor = Color.WhiteSmoke;
            dice5.BackColor = Color.WhiteSmoke;
            
        }

        private void resetOp()
        {
            plus_op.BackColor = Color.WhiteSmoke;
            moins_op.BackColor = Color.WhiteSmoke;
            mult_op.BackColor = Color.WhiteSmoke;
            div_op.BackColor = Color.WhiteSmoke;
        }

        private void resetAll()
        {
            waitingNumber = null;
            waitingOperator = null;
            resetButton();
            resetOp();
            dice1.Text = "";
            dice2.Text = "";
            dice3.Text = "";
            dice4.Text = "";
            dice5.Text = "";
            dice1.Show();
            dice2.Show();
            dice3.Show();
            dice4.Show();
            dice5.Show();

        }
    }
}
