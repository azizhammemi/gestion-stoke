using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GMAO_IIT.usercontrol
{
    public partial class UserControl2 : UserControl
    {
        private string connectionString = "Server=DESKTOP-9PKB179\\MSSQLSERVER1;Database=projet;Trusted_Connection=True;";

        public UserControl2()
        {
            InitializeComponent();
            LoadMachines();
        }

        private void btnAddMachine_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Machines (Code, Designation, Localisation, NumeroSerie, Etat, Marque, DateAcquisition, DateMiseEnService) VALUES (@Code, @Designation, @Localisation, @NumeroSerie, @Etat, @Marque, @DateAcquisition, @DateMiseEnService)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Code", txtMachineCode.Text);
                command.Parameters.AddWithValue("@Designation", txtMachineDesignation.Text);
                command.Parameters.AddWithValue("@Localisation", cmbLocalisation.SelectedItem.ToString());
                command.Parameters.AddWithValue("@NumeroSerie", txtNumeroSerie.Text);
                command.Parameters.AddWithValue("@Etat", cmbEtat.SelectedItem.ToString());
                command.Parameters.AddWithValue("@Marque", txtMarque.Text);
                command.Parameters.AddWithValue("@DateAcquisition", dtpDateAcquisition.Value);
                command.Parameters.AddWithValue("@DateMiseEnService", dtpDateMiseEnService.Value);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Machine ajoutée avec succès !");
                LoadMachines();
            }
        }

        private void btnUpdateMachine_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Machines SET Designation = @Designation, Localisation = @Localisation, NumeroSerie = @NumeroSerie, Etat = @Etat, Marque = @Marque, DateAcquisition = @DateAcquisition, DateMiseEnService = @DateMiseEnService WHERE Code = @Code";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Code", txtMachineCode.Text);
                command.Parameters.AddWithValue("@Designation", txtMachineDesignation.Text);
                command.Parameters.AddWithValue("@Localisation", cmbLocalisation.SelectedItem.ToString());
                command.Parameters.AddWithValue("@NumeroSerie", txtNumeroSerie.Text);
                command.Parameters.AddWithValue("@Etat", cmbEtat.SelectedItem.ToString());
                command.Parameters.AddWithValue("@Marque", txtMarque.Text);
                command.Parameters.AddWithValue("@DateAcquisition", dtpDateAcquisition.Value);
                command.Parameters.AddWithValue("@DateMiseEnService", dtpDateMiseEnService.Value);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Machine mise à jour avec succès !");
                LoadMachines();
            }
        }

        private void btnDeleteMachine_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Machines WHERE Code = @Code";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Code", txtMachineCode.Text);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

                MessageBox.Show("Machine supprimée avec succès !");
                LoadMachines();
            }
        }

        private void LoadMachines()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Machines";

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                dgvMachines.DataSource = dataTable;
            }
        }

        private void dgvMachines_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvMachines.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvMachines.SelectedRows[0];
                txtMachineCode.Text = row.Cells["Code"].Value.ToString();
                txtMachineDesignation.Text = row.Cells["Designation"].Value.ToString();
                cmbLocalisation.SelectedItem = row.Cells["Localisation"].Value.ToString();
                txtNumeroSerie.Text = row.Cells["NumeroSerie"].Value.ToString();
                cmbEtat.SelectedItem = row.Cells["Etat"].Value.ToString();
                txtMarque.Text = row.Cells["Marque"].Value.ToString();
                dtpDateAcquisition.Value = Convert.ToDateTime(row.Cells["DateAcquisition"].Value);
                dtpDateMiseEnService.Value = Convert.ToDateTime(row.Cells["DateMiseEnService"].Value);
            }
        }
    }
}
