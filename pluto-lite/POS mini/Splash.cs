using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace POS_mini
{
    public partial class Splash : Form
    {
        List<Color> ccc = new List<Color>();
        Models.DBEntities db = new Models.DBEntities();

        public Splash()
        {
            ccc.Add(Color.FromArgb(52, 121, 94));
            ccc.Add(Color.FromArgb(177, 103, 6));
            ccc.Add(Color.FromArgb(9, 118, 247));
            ccc.Add(Color.FromArgb(3, 76, 70));
            ccc.Add(Color.FromArgb(241, 9, 48));
            InitializeComponent();
            brandNameTxt.Text = db.PlutoSettings.First().CompanyName;
            Thread th = new Thread(new ThreadStart(delegate
            {
                Home h = new Home();
                try { Application.Run(h); } catch (Exception t) { MessageBox.Show(t.Message); Application.Exit(); }
            }));
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }



        int cColor = 0;
        int loop = 0;
        private void fader_Tick(object sender, EventArgs e)
        {
            fader.Enabled = false;
            if (cColor < ccc.Count - 1)
            {
                this.BackColor = Bunifu.Framework.UI.BunifuColorTransition.getColorScale(loop, ccc[cColor], ccc[cColor + 1]);
                if (loop < 100)
                {
                    loop++;
                }
                else
                {
                    loop = 0;
                    cColor++;
                }
                fader.Enabled = true;
            }
            else
            {

                this.Hide();
            }

        }

        private void Splash_Load(object sender, EventArgs e)
        {

        }

        private void brandNameTxt_Click(object sender, EventArgs e)
        {

        }
    }
}
