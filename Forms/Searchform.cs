using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp5.DataModells;

namespace WinFormsApp5.Forms
{
    public partial class Searchform : Form
    {
        public Searchform()
        {
            InitializeComponent();
        }

        private async void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value.Date;
            UpdateDatepicker(date);



            /*await Loader.Loading();
            List<Geometry> geometries;
            foreach (DataModells.Event c in Loader.events)
            {
                geometries = c.Geometry;

                foreach (Geometry g in geometries)
                {
                    if (g.date.Date == dateTimePicker1.Value.Date)
                    {

                        System.Windows.Forms.Label res = new System.Windows.Forms.Label();
                        res.Text = "Datum: " + g.date;
                        res.AutoSize = true;
                        flowLayoutPanel1.Controls.Add(res);
                        System.Windows.Forms.Label filler = new System.Windows.Forms.Label();
                        filler.Height = 20;
                        flowLayoutPanel1.Controls.Add(filler);
                    }
                }
            }*/
        }
        public async void UpdateDatepicker(DateTime selecteddate)
        {
            await Loader.Loading();


            var matchresults = Loader.events.SelectMany(e => e.Geometry.Select(g => new { Event = e, Geometry = g }))
            .Where(eg => eg.Geometry.date.Date == selecteddate)
            .ToList();
            

            if (matchresults.Any())
            {
                flowLayoutPanel1.Controls.Clear();

                foreach (var match in matchresults)
                {
                    

                    System.Windows.Forms.Label res = new System.Windows.Forms.Label();
                    res.Text = $"On {match.Geometry.date} a {match.Event.title} with an Magnitude Value of {match.Geometry.magnitudeValue} happend";
                    res.AutoSize = true;
                    res.ForeColor = System.Drawing.Color.FromArgb(62, 120, 138);                                       
                    flowLayoutPanel1.Controls.Add(res);
                    System.Windows.Forms.Label filler = new System.Windows.Forms.Label();
                    filler.Height = 20;
                    flowLayoutPanel1.Controls.Add(filler);



                }
            }
            else
            {
                MessageBox.Show("Keine Treffer");
            }
        }


        private void result_Click(object sender, EventArgs e)
        {

        }

        private async void category_Click(object sender, EventArgs e)
        {


        }

        private void beschreibungToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void date_Click(object sender, EventArgs e)
        {

        }
    }
}
