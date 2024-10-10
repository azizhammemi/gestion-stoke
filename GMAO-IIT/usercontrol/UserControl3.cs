using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GMAO_IIT.usercontrol
{
    public partial class UserControl3 : UserControl
    {
        private string connectionString = "Server=DESKTOP-9PKB179\\MSSQLSERVER1;Database=projet;Trusted_Connection=True;";

        public UserControl3()
        {
            InitializeComponent();
            InitializeUI();
            LoadInterventionsFromDatabase();
            PopulateMachineCodes(); // Call method to populate machine codes ComboBox
        }

        private void InitializeUI()
        {
            // Initialize UI controls (already implemented in the designer-generated code)
        }

        private void LoadInterventionsFromDatabase()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT NumeroDemandeIntervention, DateIntervention, CodeMachine, DescriptionIntervention, Etape FROM DemandeIntervention";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);

                    dgvInterventions.DataSource = dataTable; // Bind DataGridView to the DataTable
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading interventions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void PopulateMachineCodes()
        {
            cmbCodeMachine.Items.Clear(); // Clear existing items before repopulating

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Code FROM Machines";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbCodeMachine.Items.Add(reader["Code"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error populating machine codes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgvInterventions_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvInterventions.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvInterventions.SelectedRows[0];
                txtNumeroDemandeIntervention.Text = row.Cells["NumeroDemandeIntervention"].Value.ToString();
                dtpDateIntervention.Value = Convert.ToDateTime(row.Cells["DateIntervention"].Value);
                cmbCodeMachine.SelectedItem = row.Cells["CodeMachine"].Value.ToString(); // Use ComboBox instead of TextBox
                txtDescriptionIntervention.Text = row.Cells["DescriptionIntervention"].Value.ToString();
                cmbEtape.SelectedItem = row.Cells["Etape"].Value.ToString();
            }
        }

        private void btnAddIntervention_Click(object sender, EventArgs e)
        {
            AddDemandeInterventionToDatabase(
                txtNumeroDemandeIntervention.Text,
                dtpDateIntervention.Value,
                cmbCodeMachine.SelectedItem.ToString(), // Use ComboBox instead of TextBox
                txtDescriptionIntervention.Text,
                cmbEtape.SelectedItem.ToString()
            );
        }

        private void AddDemandeInterventionToDatabase(string numeroDemande, DateTime dateIntervention, string codeMachine, string description, string etape)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO DemandeIntervention (NumeroDemandeIntervention, DateIntervention, CodeMachine, DescriptionIntervention, Etape) " +
                               "VALUES (@NumeroDemandeIntervention, @DateIntervention, @CodeMachine, @DescriptionIntervention, @Etape)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NumeroDemandeIntervention", numeroDemande);
                command.Parameters.AddWithValue("@DateIntervention", dateIntervention);
                command.Parameters.AddWithValue("@CodeMachine", codeMachine);
                command.Parameters.AddWithValue("@DescriptionIntervention", description);
                command.Parameters.AddWithValue("@Etape", etape);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Demande d'intervention ajoutée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadInterventionsFromDatabase(); // Refresh the DataGridView after adding
                    ClearInputFields(); // Clear input fields after adding
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de l'ajout de la demande d'intervention: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ClearInputFields()
        {
            txtNumeroDemandeIntervention.Clear();
            dtpDateIntervention.Value = DateTime.Now.Date;
            cmbCodeMachine.SelectedIndex = -1; // Clear ComboBox selection
            txtDescriptionIntervention.Clear();
            cmbEtape.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateDemandeInterventionInDatabase(
                txtNumeroDemandeIntervention.Text,
                dtpDateIntervention.Value,
                cmbCodeMachine.SelectedItem.ToString(),
                txtDescriptionIntervention.Text,
                cmbEtape.SelectedItem.ToString()
            );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteDemandeInterventionFromDatabase(txtNumeroDemandeIntervention.Text);
        }

        private void UpdateDemandeInterventionInDatabase(string numeroDemande, DateTime dateIntervention, string codeMachine, string description, string etape)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE DemandeIntervention " +
                               "SET DateIntervention = @DateIntervention, " +
                               "    CodeMachine = @CodeMachine, " +
                               "    DescriptionIntervention = @DescriptionIntervention, " +
                               "    Etape = @Etape " +
                               "WHERE NumeroDemandeIntervention = @NumeroDemandeIntervention";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NumeroDemandeIntervention", numeroDemande);
                command.Parameters.AddWithValue("@DateIntervention", dateIntervention);
                command.Parameters.AddWithValue("@CodeMachine", codeMachine);
                command.Parameters.AddWithValue("@DescriptionIntervention", description);
                command.Parameters.AddWithValue("@Etape", etape);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Demande d'intervention mise à jour avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadInterventionsFromDatabase(); // Refresh the DataGridView after updating
                        ClearInputFields(); // Clear input fields after updating
                    }
                    else
                    {
                        MessageBox.Show("Aucune ligne mise à jour. Vérifiez le numéro de demande.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la mise à jour de la demande d'intervention: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DeleteDemandeInterventionFromDatabase(string numeroDemande)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM DemandeIntervention WHERE NumeroDemandeIntervention = @NumeroDemandeIntervention";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@NumeroDemandeIntervention", numeroDemande);

                try
                {
                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Demande d'intervention supprimée avec succès.", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadInterventionsFromDatabase(); // Refresh the DataGridView after deleting
                        ClearInputFields(); // Clear input fields after deleting
                    }
                    else
                    {
                        MessageBox.Show("Aucune ligne supprimée. Vérifiez le numéro de demande.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la suppression de la demande d'intervention: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RefreshMachineCodes(); // Call method to refresh machine codes ComboBox
        }

        private void RefreshMachineCodes()
        {
            cmbCodeMachine.Items.Clear(); // Clear existing items before repopulating

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Code FROM Machines";

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader;

                try
                {
                    connection.Open();
                    reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        cmbCodeMachine.Items.Add(reader["Code"].ToString());
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error refreshing machine codes: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
