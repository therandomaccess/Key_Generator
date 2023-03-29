using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace key.Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void trackBar1_Scroll_1(object sender, EventArgs e)
        {
            lbl_length.Text=trackBar1.Value.ToString();
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {

            if (check_ABC.Checked == false && check_abcd.Checked == false && check_123.Checked == false && check_ask.Checked == false)
            {
                MessageBox.Show("Bütün seçenekler boş olamaz", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                txt_password.Text = string.Empty;
                Random rnd = new Random();
                string ABC = "QWERTYUIOPASDFGHJKLZXCVBNM";
                string abc = "qwertyuıopasdfghjklzxcvbnm";
                string number = "0123456789";
                string special = "!+%=?*-_,.;$@";
                string password = "";
                if (check_ABC.Checked)
                {
                    password += ABC;
                }
                if (check_abcd.Checked)
                {
                    password += abc;
                }
                if (check_123.Checked)
                {
                    password += number;
                }
                if (check_ask.Checked)
                {
                    password += special;
                }
                for (int i = 0; i <= trackBar1.Value; i++)
                {
                    txt_password.Text += password[rnd.Next(password.Length)];
                }
            }
        }
        
    }
}
