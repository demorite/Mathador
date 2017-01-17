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
        private Panel panel1;
        private Panel panel2;
        private Label highScore;
        private Save save;
        private int score;
        private Label homelabel;
        private string mathadorOp;
        public Timer timer1;
        private Label timer;
        private Panel sablier;
        private int countDown = 10;

        public InterfaceFront()
        {
            InitializeComponent();

            dice1    .Hide();
            dice2    .Hide();
            dice3    .Hide();
            dice4    .Hide();
            dice5    .Hide();
            plus_op  .Hide();
            moins_op .Hide();
            mult_op  .Hide();
            div_op   .Hide();


            b_genereate.TabStop = false;
            b_genereate.FlatStyle = FlatStyle.Flat;
            b_genereate.FlatAppearance.BorderSize = 0;


            dice1.TabStop = false;
            dice1.FlatStyle = FlatStyle.Flat;
            dice1.FlatAppearance.BorderSize = 0;


            dice2.TabStop = false;
            dice2.FlatStyle = FlatStyle.Flat;
            dice2.FlatAppearance.BorderSize = 0;

            dice3.TabStop = false;
            dice3.FlatStyle = FlatStyle.Flat;
            dice3.FlatAppearance.BorderSize = 0;

            dice4.TabStop = false;
            dice4.FlatStyle = FlatStyle.Flat;
            dice4.FlatAppearance.BorderSize = 0;

            dice5.TabStop = false;
            dice5.FlatStyle = FlatStyle.Flat;
            dice5.FlatAppearance.BorderSize = 0;

            plus_op.TabStop = false;
            plus_op.FlatStyle = FlatStyle.Flat;
            plus_op.FlatAppearance.BorderSize = 0;

            moins_op.TabStop = false;
            moins_op.FlatStyle = FlatStyle.Flat;
            moins_op.FlatAppearance.BorderSize = 0;

            mult_op.TabStop = false;
            mult_op.FlatStyle = FlatStyle.Flat;
            mult_op.FlatAppearance.BorderSize = 0;

            div_op.TabStop = false;
            div_op.FlatStyle = FlatStyle.Flat;
            div_op.FlatAppearance.BorderSize = 0;

        }

        private void mainMenu()
        {
            dice1.Hide();
            dice2.Hide();
            dice3.Hide();
            dice4.Hide();
            dice5.Hide();
            plus_op.Hide();
            moins_op.Hide();
            mult_op.Hide();
            div_op.Hide();
            b_genereate.TabStop = false;
            b_genereate.FlatStyle = FlatStyle.Flat;
            b_genereate.FlatAppearance.BorderSize = 0;


            dice1.TabStop = false;
            dice1.FlatStyle = FlatStyle.Flat;
            dice1.FlatAppearance.BorderSize = 0;


            dice2.TabStop = false;
            dice2.FlatStyle = FlatStyle.Flat;
            dice2.FlatAppearance.BorderSize = 0;

            dice3.TabStop = false;
            dice3.FlatStyle = FlatStyle.Flat;
            dice3.FlatAppearance.BorderSize = 0;

            dice4.TabStop = false;
            dice4.FlatStyle = FlatStyle.Flat;
            dice4.FlatAppearance.BorderSize = 0;

            dice5.TabStop = false;
            dice5.FlatStyle = FlatStyle.Flat;
            dice5.FlatAppearance.BorderSize = 0;

            plus_op.TabStop = false;
            plus_op.FlatStyle = FlatStyle.Flat;
            plus_op.FlatAppearance.BorderSize = 0;

            moins_op.TabStop = false;
            moins_op.FlatStyle = FlatStyle.Flat;
            moins_op.FlatAppearance.BorderSize = 0;

            mult_op.TabStop = false;
            mult_op.FlatStyle = FlatStyle.Flat;
            mult_op.FlatAppearance.BorderSize = 0;

            div_op.TabStop = false;
            div_op.FlatStyle = FlatStyle.Flat;
            div_op.FlatAppearance.BorderSize = 0;
        }
       
        private void b_genereate_Click(object sender, EventArgs e)
        {
            if (pseudo.Text != "")
                startGame();
            else
            {
                getPseudo formPseudo = new getPseudo();
                formPseudo.b_pseudo.Click += delegate (object o, EventArgs args)
                {
                    resetAll();


                    pseudo.Text = formPseudo.text_pseudo.Text != "" ? formPseudo.text_pseudo.Text : "guest" + new Random().Next();

                    startGame();
                };
                formPseudo.Show();

            }
        }

        private void startGame()
        {
            Generateur generated = new Generateur();

            save = new Save(pseudo.Text, generated.Tirage(), generated.TargetNumber);
            setDices(generated);
            target_num.Text = Convert.ToString(generated.TargetNumber);
            gamestart = true;
            dice1.Show();
            dice2.Show();
            dice3.Show();
            dice4.Show();
            dice5.Show();
            plus_op.Show();
            moins_op.Show();
            mult_op.Show();
            div_op.Show();
            timer1.Enabled = true;
            timer.Enabled = true;
            timer1.Start();
            timer.Visible = true;
            sablier.Visible = true;

            b_genereate.BackgroundImage = Image.FromFile(@"C:\Users\dylan\documents\visual studio 2015\Projects\Mathador\Mathador\assets\images\home.png");
            homelabel.Text = "ReStart";
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
            this.components = new System.ComponentModel.Container();
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.highScore = new System.Windows.Forms.Label();
            this.homelabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer = new System.Windows.Forms.Label();
            this.sablier = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // b_genereate
            // 
            this.b_genereate.BackColor = System.Drawing.Color.Transparent;
            this.b_genereate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("b_genereate.BackgroundImage")));
            this.b_genereate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.b_genereate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.b_genereate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.b_genereate.Location = new System.Drawing.Point(67, 65);
            this.b_genereate.Name = "b_genereate";
            this.b_genereate.Size = new System.Drawing.Size(131, 73);
            this.b_genereate.TabIndex = 1;
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
            this.dice1.BackColor = System.Drawing.Color.Transparent;
            this.dice1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dice1.FlatAppearance.BorderSize = 0;
            this.dice1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dice1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dice1.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dice1.Image = ((System.Drawing.Image)(resources.GetObject("dice1.Image")));
            this.dice1.Location = new System.Drawing.Point(86, 214);
            this.dice1.MaximumSize = new System.Drawing.Size(70, 70);
            this.dice1.MinimumSize = new System.Drawing.Size(150, 150);
            this.dice1.Name = "dice1";
            this.dice1.Size = new System.Drawing.Size(150, 150);
            this.dice1.TabIndex = 3;
            this.dice1.UseVisualStyleBackColor = false;
            this.dice1.Click += new System.EventHandler(this.check_click);
            // 
            // dice2
            // 
            this.dice2.BackColor = System.Drawing.Color.Transparent;
            this.dice2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dice2.FlatAppearance.BorderSize = 0;
            this.dice2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dice2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dice2.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dice2.Image = ((System.Drawing.Image)(resources.GetObject("dice2.Image")));
            this.dice2.Location = new System.Drawing.Point(261, 214);
            this.dice2.MaximumSize = new System.Drawing.Size(70, 70);
            this.dice2.MinimumSize = new System.Drawing.Size(150, 150);
            this.dice2.Name = "dice2";
            this.dice2.Size = new System.Drawing.Size(150, 150);
            this.dice2.TabIndex = 4;
            this.dice2.UseVisualStyleBackColor = false;
            this.dice2.Click += new System.EventHandler(this.check_click);
            // 
            // dice3
            // 
            this.dice3.BackColor = System.Drawing.Color.Transparent;
            this.dice3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dice3.FlatAppearance.BorderSize = 0;
            this.dice3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dice3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dice3.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dice3.Image = ((System.Drawing.Image)(resources.GetObject("dice3.Image")));
            this.dice3.Location = new System.Drawing.Point(440, 214);
            this.dice3.MaximumSize = new System.Drawing.Size(70, 70);
            this.dice3.MinimumSize = new System.Drawing.Size(150, 150);
            this.dice3.Name = "dice3";
            this.dice3.Size = new System.Drawing.Size(150, 150);
            this.dice3.TabIndex = 5;
            this.dice3.UseVisualStyleBackColor = false;
            this.dice3.Click += new System.EventHandler(this.check_click);
            // 
            // dice4
            // 
            this.dice4.BackColor = System.Drawing.Color.Transparent;
            this.dice4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dice4.FlatAppearance.BorderSize = 0;
            this.dice4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dice4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dice4.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dice4.Image = ((System.Drawing.Image)(resources.GetObject("dice4.Image")));
            this.dice4.Location = new System.Drawing.Point(610, 214);
            this.dice4.MaximumSize = new System.Drawing.Size(70, 70);
            this.dice4.MinimumSize = new System.Drawing.Size(150, 150);
            this.dice4.Name = "dice4";
            this.dice4.Size = new System.Drawing.Size(150, 150);
            this.dice4.TabIndex = 6;
            this.dice4.UseVisualStyleBackColor = false;
            this.dice4.Click += new System.EventHandler(this.check_click);
            // 
            // dice5
            // 
            this.dice5.BackColor = System.Drawing.Color.Transparent;
            this.dice5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.dice5.FlatAppearance.BorderSize = 0;
            this.dice5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dice5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dice5.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dice5.Image = ((System.Drawing.Image)(resources.GetObject("dice5.Image")));
            this.dice5.Location = new System.Drawing.Point(779, 214);
            this.dice5.MaximumSize = new System.Drawing.Size(70, 70);
            this.dice5.MinimumSize = new System.Drawing.Size(150, 150);
            this.dice5.Name = "dice5";
            this.dice5.Size = new System.Drawing.Size(150, 150);
            this.dice5.TabIndex = 7;
            this.dice5.UseVisualStyleBackColor = false;
            this.dice5.Click += new System.EventHandler(this.check_click);
            // 
            // plus_op
            // 
            this.plus_op.BackColor = System.Drawing.Color.Transparent;
            this.plus_op.FlatAppearance.BorderSize = 0;
            this.plus_op.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.plus_op.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.plus_op.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plus_op.ForeColor = System.Drawing.Color.Black;
            this.plus_op.Image = ((System.Drawing.Image)(resources.GetObject("plus_op.Image")));
            this.plus_op.Location = new System.Drawing.Point(164, 430);
            this.plus_op.MaximumSize = new System.Drawing.Size(70, 70);
            this.plus_op.MinimumSize = new System.Drawing.Size(150, 150);
            this.plus_op.Name = "plus_op";
            this.plus_op.Size = new System.Drawing.Size(150, 150);
            this.plus_op.TabIndex = 8;
            this.plus_op.Text = "+";
            this.plus_op.UseVisualStyleBackColor = false;
            this.plus_op.Click += new System.EventHandler(this.check_click);
            // 
            // moins_op
            // 
            this.moins_op.BackColor = System.Drawing.Color.Transparent;
            this.moins_op.FlatAppearance.BorderSize = 0;
            this.moins_op.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.moins_op.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.moins_op.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moins_op.ForeColor = System.Drawing.Color.Black;
            this.moins_op.Image = ((System.Drawing.Image)(resources.GetObject("moins_op.Image")));
            this.moins_op.Location = new System.Drawing.Point(343, 430);
            this.moins_op.MaximumSize = new System.Drawing.Size(70, 70);
            this.moins_op.MinimumSize = new System.Drawing.Size(150, 150);
            this.moins_op.Name = "moins_op";
            this.moins_op.Size = new System.Drawing.Size(150, 150);
            this.moins_op.TabIndex = 9;
            this.moins_op.Text = "-";
            this.moins_op.UseVisualStyleBackColor = false;
            this.moins_op.Click += new System.EventHandler(this.check_click);
            // 
            // mult_op
            // 
            this.mult_op.BackColor = System.Drawing.Color.Transparent;
            this.mult_op.FlatAppearance.BorderSize = 0;
            this.mult_op.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.mult_op.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.mult_op.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mult_op.ForeColor = System.Drawing.Color.Black;
            this.mult_op.Image = ((System.Drawing.Image)(resources.GetObject("mult_op.Image")));
            this.mult_op.Location = new System.Drawing.Point(532, 430);
            this.mult_op.MaximumSize = new System.Drawing.Size(70, 70);
            this.mult_op.MinimumSize = new System.Drawing.Size(150, 150);
            this.mult_op.Name = "mult_op";
            this.mult_op.Size = new System.Drawing.Size(150, 150);
            this.mult_op.TabIndex = 10;
            this.mult_op.Text = "x";
            this.mult_op.UseVisualStyleBackColor = false;
            this.mult_op.Click += new System.EventHandler(this.check_click);
            // 
            // div_op
            // 
            this.div_op.BackColor = System.Drawing.Color.Transparent;
            this.div_op.FlatAppearance.BorderSize = 0;
            this.div_op.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.div_op.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.div_op.Font = new System.Drawing.Font("Microsoft Sans Serif", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.div_op.ForeColor = System.Drawing.Color.Black;
            this.div_op.Image = ((System.Drawing.Image)(resources.GetObject("div_op.Image")));
            this.div_op.Location = new System.Drawing.Point(712, 430);
            this.div_op.MaximumSize = new System.Drawing.Size(70, 70);
            this.div_op.MinimumSize = new System.Drawing.Size(150, 150);
            this.div_op.Name = "div_op";
            this.div_op.Size = new System.Drawing.Size(150, 150);
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
            this.target_num.BackColor = System.Drawing.Color.Transparent;
            this.target_num.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.target_num.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.target_num.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.target_num.Location = new System.Drawing.Point(440, 141);
            this.target_num.Name = "target_num";
            this.target_num.Size = new System.Drawing.Size(150, 27);
            this.target_num.TabIndex = 12;
            this.target_num.Text = "Cible";
            this.target_num.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Location = new System.Drawing.Point(712, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 73);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Location = new System.Drawing.Point(461, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(102, 125);
            this.panel2.TabIndex = 14;
            // 
            // highScore
            // 
            this.highScore.BackColor = System.Drawing.Color.Transparent;
            this.highScore.Font = new System.Drawing.Font("Algerian", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highScore.Location = new System.Drawing.Point(712, 141);
            this.highScore.Name = "highScore";
            this.highScore.Size = new System.Drawing.Size(164, 27);
            this.highScore.TabIndex = 0;
            this.highScore.Text = "0";
            this.highScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // homelabel
            // 
            this.homelabel.BackColor = System.Drawing.Color.Transparent;
            this.homelabel.Font = new System.Drawing.Font("Algerian", 20F);
            this.homelabel.Location = new System.Drawing.Point(67, 141);
            this.homelabel.Name = "homelabel";
            this.homelabel.Size = new System.Drawing.Size(131, 27);
            this.homelabel.TabIndex = 15;
            this.homelabel.Text = "Start";
            this.homelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer
            // 
            this.timer.BackColor = System.Drawing.Color.Transparent;
            this.timer.Enabled = false;
            this.timer.Font = new System.Drawing.Font("Algerian", 20F);
            this.timer.Location = new System.Drawing.Point(306, 141);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(72, 27);
            this.timer.TabIndex = 13;
            this.timer.Text = "60";
            this.timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timer.Visible = false;
            // 
            // sablier
            // 
            this.sablier.BackColor = System.Drawing.Color.Transparent;
            this.sablier.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sablier.BackgroundImage")));
            this.sablier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sablier.Location = new System.Drawing.Point(306, 65);
            this.sablier.Name = "sablier";
            this.sablier.Size = new System.Drawing.Size(72, 73);
            this.sablier.TabIndex = 14;
            this.sablier.Visible = false;
            // 
            // InterfaceFront
            // 
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 702);
            this.Controls.Add(this.homelabel);
            this.Controls.Add(this.highScore);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sablier);
            this.Controls.Add(this.timer);
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
            this.DoubleBuffered = true;
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
                            if(!checkMathador("+")) score += 1;
                            break;

                        case "x":
                            result = Convert.ToInt32(waitingNumber.Text) * Convert.ToInt32(b_sender.Text);
                            if (!checkMathador("x")) score += 1;
                            break;

                        case "-":
                            if (Convert.ToInt32(b_sender.Text) <= Convert.ToInt32(waitingNumber.Text))
                            {
                                result = Convert.ToInt32(waitingNumber.Text) - Convert.ToInt32(b_sender.Text);
                                if (!checkMathador("-")) score += 2;
                            }
                            break;

                        case ":":
                            if (Convert.ToInt32(b_sender.Text) > 0 && Convert.ToInt32(waitingNumber.Text) % Convert.ToInt32(b_sender.Text) == 0)
                            {
                                result = Convert.ToInt32(waitingNumber.Text) / Convert.ToInt32(b_sender.Text);
                                if (!checkMathador(":")) score += 3;
                            }
                            break;
                    }

                    if (result != -1)
                    {
                        b_sender.Text = Convert.ToString(result);
                        highScore.Text = score.ToString();
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

        private bool checkMathador(string s)
        {
            if (mathadorOp == null)
                mathadorOp = s;
            else if (mathadorOp.IndexOf(s) < 0)
                mathadorOp += s;
            if (mathadorOp.IndexOf('+') >= 0 && mathadorOp.IndexOf('-') >= 0 && mathadorOp.IndexOf('x') >= 0 && mathadorOp.IndexOf(':') >= 0)
            {
                score = 13;
                return true;
            }

            return false;
        }

        private void resetButton()
        {
            dice1.BackColor = Color.Transparent;
            dice2.BackColor = Color.Transparent;
            dice3.BackColor = Color.Transparent;
            dice4.BackColor = Color.Transparent;
            dice5.BackColor = Color.Transparent;

        }

        private void resetOp()
        {
            plus_op.BackColor = Color.Transparent;
            moins_op.BackColor = Color.Transparent;
            mult_op.BackColor = Color.Transparent;
            div_op.BackColor = Color.Transparent;
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
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            countDown--;
            if (countDown == 0)
            {
                mainMenu();
                timer1.Stop();
            }
            timer.Text = countDown.ToString();
            
        }
        
    }
}
