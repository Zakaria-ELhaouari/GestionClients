using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ClientGestion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool check = false;
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = @"Data Source=DESKTOP-122P6H8\SQLEXPRESS;Initial Catalog=GestionClients;Integrated Security=True";
            string QuerySelect = "Select * FROM Clients";
            SqlCommand cmd = new SqlCommand(QuerySelect, cnx);
            cnx.Open();
            SqlDataReader data = cmd.ExecuteReader();
            if (data.HasRows)
            {
                this.ClientsView.Rows.Clear();
                while (data.Read())
                {
                    this.ClientsView.Rows.Add(data[0], data[1], data[2], data[3] , data[4]);
                }
                cnx.Close();
            }
            else
            {
                MessageBox.Show("nous avons aucun clients");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = @"Data Source=DESKTOP-122P6H8\SQLEXPRESS;Initial Catalog=GestionClients;Integrated Security=True";
            string QuerInsert = "INSERT INTO Clients(Id, Nom, Prenom, Adress, Ville) VALUES ((SELECT ISNULL(MAX(id) + 1, 0) FROM Clients), '" + this.name_input.Text.Trim()+"' ,  '"+this.input_prenom.Text.Trim()+ "' , '"+this.input_adress.Text.Trim()+ "' , '"+this.input_ville.Text.Trim()+"')";
            
            SqlCommand cmd = new SqlCommand(QuerInsert, cnx);
            if(cnx.State == System.Data.ConnectionState.Open)
            {
                cnx.Close();
            }
            cnx.Open();
            if (this.name_input.Text.Equals(string.Empty) || this.input_prenom.Text.Equals(string.Empty) || this.input_adress.Text.Equals(string.Empty) ||  this.input_ville.Text.Equals(string.Empty) || check == false)
            {
                MessageBox.Show("Inserer tout les donnes");
            }
            else
            {
                cmd.ExecuteNonQuery();
                this.name_input.Text = String.Empty;
                this.input_prenom.Text = String.Empty;
                this.input_adress.Text = String.Empty;
                this.input_ville.Text = String.Empty;
            }
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int position = -1;
        int idClients;
        private void ClientsView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void ClientsView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            check = false;
            position = this.ClientsView.CurrentRow.Index;
            idClients = int.Parse(this.ClientsView.Rows[position].Cells[0].Value.ToString());
            this.name_input.Text = this.ClientsView.Rows[position].Cells[1].Value.ToString();
            this.input_prenom.Text = this.ClientsView.Rows[position].Cells[2].Value.ToString();
            this.input_adress.Text = this.ClientsView.Rows[position].Cells[3].Value.ToString();
            this.input_ville.Text = this.ClientsView.Rows[position].Cells[4].Value.ToString();

        }

        private void suprimer_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = @"Data Source=DESKTOP-122P6H8\SQLEXPRESS;Initial Catalog=GestionClients;Integrated Security=True";
            string QueryDelet = "DELETE FROM Clients WHERE id = " + idClients;
            SqlCommand cmd = new SqlCommand(QueryDelet, cnx);
            cnx.Open();
            cmd.ExecuteNonQuery();
        }

        private void modifier_Click(object sender, EventArgs e)
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = @"Data Source=DESKTOP-122P6H8\SQLEXPRESS;Initial Catalog=GestionClients;Integrated Security=True";
            string QuerUpdate = "UPDATE Clients SET Nom = '" + this.name_input.Text.Trim() + "', Prenom = '"+ this.input_prenom.Text.Trim() + "', Adress = '" + this.input_adress.Text.Trim() + "', Ville = '" + this.input_ville.Text.Trim() + "' WHERE ID = " + idClients;

            SqlCommand cmd = new SqlCommand(QuerUpdate, cnx);
            cnx.Open();
            if(check == false)
            {
                cmd.ExecuteNonQuery();
            }
            
            this.name_input.Text = String.Empty;
            this.input_prenom.Text = String.Empty;
            this.input_adress.Text = String.Empty;
            this.input_ville.Text = String.Empty;

        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            check = true;
            this.name_input.Text = String.Empty;
            this.input_prenom.Text = String.Empty;
            this.input_adress.Text = String.Empty;
            this.input_ville.Text = String.Empty;
        }
    }
}
