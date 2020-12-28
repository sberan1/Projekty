using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seznam
{
    class Item
    {
        public TextBox Text { get; set; }
        public CheckBox Check { get; set; }
        public Button Button { get; set; }

    }
    public partial class Form1 : Form
    {
        int id;
        int poziceX = 75;
        int poziceY = 25;
        public Form1()
        {
            InitializeComponent();
        }

        private void pridat_Click(object sender, EventArgs e)
        {


            //poziceX += 50;
            poziceY += 40;
            id++;

            TextBox polozka1 = new TextBox();
            polozka1.Location = new Point(poziceX, poziceY);
            polozka1.Width = 400;
            polozka1.Height = 20;
            this.Controls.Add(polozka1);
            polozka1.Name = id.ToString();

            CheckBox koupeno1 = new CheckBox();
            koupeno1.Location = new Point(poziceX + 450, poziceY);
            koupeno1.Width = 15;
            koupeno1.Height = 14;
            this.Controls.Add(koupeno1);
            koupeno1.Name = id.ToString();

            Button smazat1 = new Button();
            smazat1.Location = new Point(poziceX + 525, poziceY);
            smazat1.Width = 100;
            smazat1.Height = 25;
            smazat1.Text = "Smazat";
            this.Controls.Add(smazat1);
            smazat1.Name = id.ToString();

            smazat1.Click += new EventHandler(smazatClick);
        }

        private void delete_Click(object sender, EventArgs e)
        {
          //  this.Controls.Remove()
        }

        private void smazatClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int id = Convert.ToInt32(btn.Name);

           // this.Controls.Remove();
           // this.Controls.Remove();  
            this.Controls.Remove(btn);
        }

        }
}
