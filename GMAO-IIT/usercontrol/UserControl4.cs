using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GMAO_IIT.usercontrol
{
    public partial class UserControl4 : UserControl
    {
        private string connectionString = "Server=DESKTOP-9PKB179\\MSSQLSERVER1;Database=projet;Trusted_Connection=True;";

        public UserControl4()
        {
            InitializeComponent();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            LoadInterventionsFromDatabase();
        }

        private void LoadInterventionsFromDatabase()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT NumeroDemandeIntervention, DateIntervention, CodeMachine, DescriptionIntervention, Etape " +
                               "FROM DemandeIntervention " +
                               "WHERE DateIntervention BETWEEN @startDate AND @endDate";

                if (!string.IsNullOrEmpty(textBoxCode.Text))
                {
                    query += " AND CodeMachine = @codeMachine";
                }

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@startDate", dateTimePickerStart.Value);
                command.Parameters.AddWithValue("@endDate", dateTimePickerEnd.Value);

                if (!string.IsNullOrEmpty(textBoxCode.Text))
                {
                    command.Parameters.AddWithValue("@codeMachine", textBoxCode.Text);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    connection.Open();
                    adapter.Fill(dataTable);
                    dataGridViewInterventions.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading interventions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
