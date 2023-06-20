using Microsoft.Azure.Documents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Proiect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            schema.Visible = false;
        }

        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            String username = user.Text;
            String password = pass.Text;

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-FHFL8DI\SQLEXPRESS;Initial Catalog=UniCatalog;Integrated Security=True");
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("Select post, id_angajat, Discipline_titl_acrn from cadre_didactice Where un = @user  and pw = @password", conn);
                cmd.Parameters.AddWithValue("@user", username);
                cmd.Parameters.AddWithValue("@password", password);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {

                    String s = reader.GetString(0);
                    int id = reader.GetInt32(1);
                    String mm = ($"{id}");

                    if (s.Equals("Profesor universitar"))
                    {
                        this.Visible = false;
                        prof_page page1 = new prof_page();
                        page1.Visible = true;

                        page1.label1.Text = mm;
                    }
                    else if (s.Equals("Secretar"))
                    {
                        this.Visible = false;
                        sec_page page2 = new sec_page();
                        page2.Visible = true;

                        page2.label1.Text = mm;
                    }
                    else if (s.Equals("Administrator"))
                    {
                        this.Visible = false;
                        ad_page page3 = new ad_page();
                        page3.Visible = true;

                        //page3.label1.Text = mm;
                    }

                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Date gresite!");
                }
            }
            catch(Exception s)
            {
                MessageBox.Show(s.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
