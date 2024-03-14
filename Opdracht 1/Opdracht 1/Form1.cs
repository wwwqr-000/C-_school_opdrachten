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
using System.Security.Cryptography.X509Certificates;

namespace Opdracht_1 {
    public partial class Form1 : Form {

        List<string> klasgenoten = new List<string>();


        public Form1() {
            InitializeComponent();
        }

        public static string connString = @"Server=GAMING-LAPTOP-W\SQLEXPRESS;Initial Catalog=opdracht_1;Persist Security Info=False;Integrated Security=true;MultipleActiveResultSets=True;Encrypt=false;TrustServerCertificate=true;Connection Timeout=30";

        public SqlConnection cnn = new SqlConnection(connString);


        private void updateData() {
            try {
                cnn.Open();
            }
            catch (Exception ex) {
                MessageBox.Show("Kan momenteel geen verbinding maken met database. Probeer het later opnieuw.\n" + ex);
                return;
            }

            SqlCommand cmd = new SqlCommand("SELECT COUNT(ID) FROM Table_1", cnn);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read()) {
                aantalDeelnemerslabel.Text = reader.GetValue(0).ToString();
            }
            cnn.Close();
        }

        private void Form1_Load(object sender, EventArgs e) {
            updateData();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e) {

        }

        private void tabPage2_Click(object sender, EventArgs e) {

        }

        private void closeCnn(bool isOpen) {
            if (isOpen) {
                cnn.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            string name = naam.Text;


            bool isOpen = false;
            try {
                cnn.Open();
                isOpen = true;
            }
            catch (Exception ex) {
                MessageBox.Show("Kon geen verbinding maken met de database. Probeer het later opnieuw.\n" + ex);
                return;
            }

            if (name == "") {
                MessageBox.Show("Je bent vergeten je naam in te voeren. Probeer het opnieuw.");
                closeCnn(isOpen);
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

        private void label6_Click(object sender, EventArgs e) {

        }

        private void label7_Click(object sender, EventArgs e) {

        }

        private void label8_Click(object sender, EventArgs e) {

        }

        private void overzicht_Click(object sender, EventArgs e) {

        }
    }
}
