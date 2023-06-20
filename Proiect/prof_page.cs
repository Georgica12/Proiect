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
    public partial class prof_page : Form
    {
        public prof_page()
        {
            InitializeComponent();

            this.CenterToScreen();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            String ac = label1.Text;

            label1.Text = "Logged in as Employee#" + ac + '.';

            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-FHFL8DI\SQLEXPRESS;Initial Catalog=UniCatalog;Integrated Security=True");
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("Select Discipline_titl_acrn from cadre_didactice where ID_Angajat = @id", conn);
                cmd.Parameters.AddWithValue("@id", ac);
                SqlDataReader reader = cmd.ExecuteReader();

                String aux = reader.GetString(0);

                MessageBox.Show(aux);


                /*while (reader.Read()){
                    lista_materii.Items.Add(reader[""]);
                }*/

                //conn.Close();

            }
            catch (Exception s)
            {
                MessageBox.Show(s.Message);
            }

        }
        private void prof_page_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
