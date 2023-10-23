using System.Runtime.CompilerServices;
using WinFormsApp5;
using WinFormsApp5.Forms;
using System.Net.Http;
using System.Net.Http.Json;

namespace WinFormsApp5
{
    
    public partial class Form1 : Form
    {
        private Form? Currentform;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void dashboard_Click(object sender, EventArgs e)
        {
            if (Currentform != null)
            {
                Currentform.Close();
            }

            WinFormsApp5.Forms.Form2 _form2 = new WinFormsApp5.Forms.Form2();
            _form2.TopLevel = false;
            _form2.FormBorderStyle = FormBorderStyle.None;
            dimension.Controls.Add(_form2);
            _form2.Show();
            Currentform = _form2;



            panel4.Height = dashboard.Height;
            panel4.Top = dashboard.Top;
        }

        private void seller_Click(object sender, EventArgs e)
        {
            if (Currentform != null) {
                Currentform.Close();
            }

            Forms.Searchform _searchform = new Forms.Searchform();
            
            _searchform.TopLevel = false;
            _searchform.FormBorderStyle = FormBorderStyle.None;
            dimension.Controls.Add(_searchform);
            _searchform.Show();
            Currentform = _searchform;
            
            seller.Height = panel4.Height;
            panel4.Top = seller.Top;
        }

        private void tasks_Click(object sender, EventArgs e)
        {
            panel4.Height = tasks.Height;
            panel4.Top = tasks.Top;
        }


    }
}