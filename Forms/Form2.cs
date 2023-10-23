using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Json;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using WinFormsApp5.DataModells;
using System.Reflection.Emit;

namespace WinFormsApp5.Forms
{

    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
        }


        private async void Form2_Load(object sender, EventArgs e)
        {


            int red = 62;
            int green = 120;
            int blue = 138;
            System.Drawing.Color color = System.Drawing.Color.FromArgb(red, green, blue);

            System.Windows.Forms.Label load = new System.Windows.Forms.Label();
            load.Text = "Loading...";
            load.Font = new System.Drawing.Font("Bahnschrift", 12);
            load.ForeColor = color;
            load.AutoSize = true;
            flowLayoutPanel1.Controls.Add(load);

            await Loader.Loading();


            flowLayoutPanel1.Controls.Remove(load);
            List<Category> categories;
            for (int i = 0; i < 50 && i < Loader.events.Count; i++)
            {
                Event ev = Loader.events[i];

                categories = ev.Categories;
                

                foreach (Category c in categories)
                {
                    System.Windows.Forms.Label idlabel = new System.Windows.Forms.Label();
                    idlabel.Text = "ID:" + ev.Id;
                    idlabel.AutoSize = true;

                    System.Windows.Forms.Label titlelabel = new System.Windows.Forms.Label();
                    titlelabel.Text = "Category Title:" + c.title;
                    titlelabel.AutoSize = true;
                    titlelabel.Left = idlabel.Right + 5;

                    flowLayoutPanel1.Controls.Add(idlabel);

                    System.Windows.Forms.Label filler = new System.Windows.Forms.Label();
                    filler.Height = 20;
                    flowLayoutPanel1.Controls.Add(filler);

                    flowLayoutPanel1.Controls.Add(titlelabel);
                    flowLayoutPanel1.Controls.Add(filler);
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
