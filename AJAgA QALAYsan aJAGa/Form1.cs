using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AJAgA_QALAYsan_aJAGa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sana = 0;
        void X_0(Button btN)
         
        {
            if (sana%2 == 0)
            {
                btN.Text = "X";
            }
            
            else
            {
                btN.Text = "0";
            }
            sana++;
            btN.Enabled = false;
        }
        
       
        private void button2_Click(object sender, EventArgs e)
        {
            Button ajaga= (Button)sender;
            X_0(ajaga);
            utti();
         
        }

        void utti()
        {
            knopka(a1, a2, a3);
            knopka(a4, a5, a6);
            knopka(a7, a8, a9);
            knopka(a1, a2, a3);
            knopka(a1, a4, a7);
            knopka(a2, a5, a8);
            knopka(a1, a5, a9);
            knopka(a3, a5, a7);
        }
        void knopka(Button b1, Button b2, Button b3)
        {
            if (b1.Text == "X" && b1.Text == b2.Text && b2.Text == b3.Text)
            {
                b1.BackColor = Color.Green;
                b2.BackColor = Color.Green;
                b3.BackColor = Color.Green;
                this.BackgroundImage = Properties.Resources.photo_2023_05_10_19_17_23;
                basilmaydi();

            }
            else if (b1.Text == "X" && b1.Text == b2.Text && b2.Text == b3.Text)
            {
                b1.BackColor = Color.Red;
                b2.BackColor = Color.Red;
                b3.BackColor = Color.Red;
                this.BackgroundImage = Properties.Resources.nolik;
                basilmaydi();

            }
        }
        void basilmaydi()
        {
            Button[]ati=flowLayoutPanel2.Controls.OfType<Button>().ToArray();
            foreach(Button btn in ati)
            { btn.Enabled = false; }

        }

       
    }
}
