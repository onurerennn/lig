using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lig
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int gspuan = 0;
        int fbpuan = 0;
        int bjkpuan = 0;
        int tspuan = 0;

    
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;//butona sadece 1 kere tıklansın (pasif olsun)
            int a = rnd.Next(0,5);//gs
            int b = rnd.Next(0, 5);//fb
            int c = rnd.Next(0, 5);//bjk
            int d = rnd.Next(0, 5);//ts
            label4.Text = a.ToString();
            label5.Text = b.ToString();
            label8.Text = c.ToString();
            label6.Text = d.ToString();

            if (Convert.ToInt32(label4.Text) > Convert.ToInt32(label5.Text))
            {
                gspuan += 3;
                lbl_gs_puann .Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label5.Text) > Convert.ToInt32(label4.Text))
            {
                fbpuan += 3;
                lbl_fb_puann.Text = fbpuan.ToString();
            } if (Convert.ToInt32(label5.Text) == Convert.ToInt32(label4.Text))
            {
                fbpuan += 1;
                gspuan += 1;
                lbl_gs_puann.Text = gspuan.ToString();
                lbl_fb_puann.Text = fbpuan.ToString();

            }
            if (Convert.ToInt32(label8.Text) > Convert.ToInt32(label6.Text))
            {
                bjkpuan += 3;
                lbl_bjk_puann.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label6.Text) > Convert.ToInt32(label8.Text))
            {
                tspuan += 3;
                lbl_ts_puann.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label8.Text) == Convert.ToInt32(label6.Text))
            {
                bjkpuan += 1;
                tspuan += 1;
                lbl_ts_puann.Text = tspuan.ToString();
                lbl_bjk_puann.Text = bjkpuan.ToString();

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

            button2.Enabled = false;//butona sadece 1 kere tıklansın (pasif olsun)
            int a = rnd.Next(0, 5);//gs
            int b = rnd.Next(0, 5);//fb
            int c = rnd.Next(0, 5);//bjk
            int d = rnd.Next(0, 5);//ts
            label16.Text = a.ToString();//gs
            label15.Text = b.ToString();//fb
            label12.Text = c.ToString();//bjk
            label11.Text = d.ToString();//ts

            if (Convert.ToInt32(label16.Text) > Convert.ToInt32(label12.Text))
            {
                gspuan += 3;
                lbl_gs_puann.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label12.Text) > Convert.ToInt32(label16.Text))
            {
                bjkpuan += 3;
                lbl_bjk_puann.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label12.Text) == Convert.ToInt32(label16.Text))
            {
                bjkpuan += 1;
                gspuan += 1;
                lbl_gs_puann.Text = gspuan.ToString();
                lbl_bjk_puann.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label15.Text) > Convert.ToInt32(label11.Text))
            {
                fbpuan += 3;
                lbl_fb_puann.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label11.Text) > Convert.ToInt32(label15.Text))
            {
                tspuan += 3;
                lbl_ts_puann.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label11.Text) == Convert.ToInt32(label15.Text))
            {
                fbpuan += 1;
                tspuan += 1;
                lbl_ts_puann.Text = tspuan.ToString();
                lbl_fb_puann.Text = fbpuan.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

            button3.Enabled = false;//butona sadece 1 kere tıklansın (pasif olsun)
            int a = rnd.Next(0, 5);//gs
            int b = rnd.Next(0, 5);//fb
            int c = rnd.Next(0, 5);//bjk
            int d = rnd.Next(0, 5);//ts
            label26.Text = a.ToString();//fb
            label22.Text = b.ToString();//bjk
            label25.Text = c.ToString();//ts
            label21.Text = d.ToString();//gs
            
            if (Convert.ToInt32(label26.Text) > Convert.ToInt32(label22.Text))
            {
                fbpuan += 3;
                lbl_fb_puann.Text = fbpuan.ToString();
            }
            if (Convert.ToInt32(label22.Text) > Convert.ToInt32(label26.Text))
            {
                bjkpuan += 3;
                lbl_bjk_puann.Text = bjkpuan.ToString();
            }
            if (Convert.ToInt32(label22.Text) == Convert.ToInt32(label26.Text))
            {
                bjkpuan += 1;
                fbpuan += 1;
                lbl_fb_puann.Text = fbpuan.ToString();
                lbl_bjk_puann.Text = bjkpuan.ToString();
            }

            
            if (Convert.ToInt32(label25.Text) > Convert.ToInt32(label21.Text))
            {
                tspuan += 3;
                lbl_ts_puann.Text = tspuan.ToString();
            }
            if (Convert.ToInt32(label21.Text) > Convert.ToInt32(label25.Text))
            {
                gspuan += 3;
                lbl_gs_puann.Text = gspuan.ToString();
            }
            if (Convert.ToInt32(label25.Text) == Convert.ToInt32(label21.Text))
            {
                tspuan += 1;
                gspuan += 1;
                lbl_gs_puann.Text = gspuan.ToString();
                lbl_ts_puann.Text = tspuan.ToString();
            }
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if((Convert.ToInt32(lbl_bjk_puann.Text)> Convert.ToInt32(lbl_fb_puann.Text))&&(Convert.ToInt32(lbl_bjk_puann.Text)> Convert.ToInt32(lbl_ts_puann.Text))&&(Convert.ToInt32(lbl_bjk_puann.Text) > Convert.ToInt32(lbl_gs_puann.Text)))
            {
                MessageBox.Show("SAMPİYON BEŞİKTAŞ");
            }
            else if((Convert.ToInt32(lbl_fb_puann.Text) > Convert.ToInt32(lbl_bjk_puann.Text)) && (Convert.ToInt32(lbl_fb_puann.Text) > Convert.ToInt32(lbl_ts_puann.Text)) && (Convert.ToInt32(lbl_fb_puann.Text) > Convert.ToInt32(lbl_gs_puann.Text)))
            {
                MessageBox.Show("SAMPİYON FENERBAHÇE");
            }
            else if ((Convert.ToInt32(lbl_gs_puann.Text) > Convert.ToInt32(lbl_bjk_puann.Text)) && (Convert.ToInt32(lbl_gs_puann.Text) > Convert.ToInt32(lbl_ts_puann.Text)) && (Convert.ToInt32(lbl_gs_puann.Text) > Convert.ToInt32(lbl_fb_puann.Text)))
            {
                MessageBox.Show("SAMPİYON GALATASARAY");
            }
            else if ((Convert.ToInt32(lbl_ts_puann.Text) > Convert.ToInt32(lbl_bjk_puann.Text)) && (Convert.ToInt32(lbl_ts_puann.Text) > Convert.ToInt32(lbl_gs_puann.Text)) && (Convert.ToInt32(lbl_ts_puann.Text) > Convert.ToInt32(lbl_fb_puann.Text)))
            {
                MessageBox.Show("SAMPİYON TRABZONSPOR");
            }
            else
            {
                MessageBox.Show("turnuvada şampiyon yok");

            }

        }
    }
}
