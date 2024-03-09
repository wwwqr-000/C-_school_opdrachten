using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Opdracht_1 {
    public partial class Form1 : Form {

        List<string> klasgenoten = new List<string>();


        public Form1() {
            InitializeComponent();
        }

        public static string connString = @"Server=GAMING-LAPTOP-W\SQLEXPRESS;Initial Catalog=opdracht_1;Persist Security Info=False;Integrated Security=true;MultipleActiveResultSets=True;Encrypt=false;TrustServerCertificate=true;Connection Timeout=30";

        public SqlConnection cnn = new SqlConnection(connString);

        private void Form1_Load(object sender, EventArgs e) {

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e) {

        }

        private void tabPage2_Click(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            string name = naam.Text;



            try {
                cnn.Open();
            }
            catch (Exception ex) {
                MessageBox.Show("Oof!" + ex);
                return;
            }

            string sql = "INSERT INTO Table_1(name, aantal_fruit, week_sport) VALUES ('" + name + "', 1, 1)";

            SqlCommand Insert = new SqlCommand(sql, cnn);
            Insert.ExecuteNonQuery();
            cnn.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e) {

        }

        private void progressBar1_Click(object sender, EventArgs e) {

        }

        private void groupBox1_Enter(object sender, EventArgs e) {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e) {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e) {

        }
    }
}
