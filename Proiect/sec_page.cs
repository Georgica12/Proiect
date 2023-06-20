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
    public partial class sec_page : Form
    {
        public sec_page()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            String ps = (string)lista1.SelectedItem;
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-FHFL8DI\SQLEXPRESS;Initial Catalog=UniCatalog;Integrated Security=True");
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("Select id_student, nume, prenume from studenti where ", conn);
                SqlDataReader reader = cmd.ExecuteReader();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
    }
}
