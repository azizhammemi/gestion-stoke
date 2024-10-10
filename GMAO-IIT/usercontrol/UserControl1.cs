using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace GMAO_IIT.usercontrol
{
    public partial class UserControl1 : UserControl
    {
        private string connectionString = "Server=DESKTOP-9PKB179\\MSSQLSERVER1;Database=projet;Trusted_Connection=True;";

        public UserControl1()
        {
            InitializeComponent();
            LoadArticles();
        }

        private void btnAddArticle_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Articles (Code, Designation, Famille, UniteDeMesure, Majore, PrixHT, TVA, QuantiteEnStock, QuantiteStockMin, ControleDeStock, ControleDeReservation) " +
                               "VALUES (@Code, @Designation, @Famille, @UniteDeMesure, @Majore, @PrixHT, @TVA, @QuantiteEnStock, @QuantiteStockMin, @ControleDeStock, @ControleDeReservation)";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Code", txtCode.Text);
                command.Parameters.AddWithValue("@Designation", txtDesignation.Text);
                command.Parameters.AddWithValue("@Famille", cmbFamille.SelectedItem.ToString());
                command.Parameters.AddWithValue("@UniteDeMesure", cmbUniteDeMesure.SelectedItem.ToString());
                command.Parameters.AddWithValue("@Majore", chkMajore.Checked);
                command.Parameters.AddWithValue("@PrixHT", decimal.Parse(txtPrixHT.Text));
                command.Parameters.AddWithValue("@TVA", decimal.Parse(txtTVA.Text));
                command.Parameters.AddWithValue("@QuantiteEnStock", decimal.Parse(txtQuantiteEnStock.Text));
                command.Parameters.AddWithValue("@QuantiteStockMin", decimal.Parse(txtQuantiteStockMin.Text));
                command.Parameters.AddWithValue("@ControleDeStock", chkControleDeStock.Checked);
                command.Parameters.AddWithValue("@ControleDeReservation", chkControleDeReservation.Checked);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Article ajouté avec succès !");
                    LoadArticles(); // Refresh the DataGridView after adding
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de l'ajout de l'article: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "UPDATE Articles SET Designation = @Designation, Famille = @Famille, UniteDeMesure = @UniteDeMesure, " +
                               "Majore = @Majore, PrixHT = @PrixHT, TVA = @TVA, QuantiteEnStock = @QuantiteEnStock, QuantiteStockMin = @QuantiteStockMin, " +
                               "ControleDeStock = @ControleDeStock, ControleDeReservation = @ControleDeReservation " +
                               "WHERE Code = @Code";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Code", txtCode.Text);
                command.Parameters.AddWithValue("@Designation", txtDesignation.Text);
                command.Parameters.AddWithValue("@Famille", cmbFamille.SelectedItem.ToString());
                command.Parameters.AddWithValue("@UniteDeMesure", cmbUniteDeMesure.SelectedItem.ToString());
                command.Parameters.AddWithValue("@Majore", chkMajore.Checked);
                command.Parameters.AddWithValue("@PrixHT", decimal.Parse(txtPrixHT.Text));
                command.Parameters.AddWithValue("@TVA", decimal.Parse(txtTVA.Text));
                command.Parameters.AddWithValue("@QuantiteEnStock", decimal.Parse(txtQuantiteEnStock.Text));
                command.Parameters.AddWithValue("@QuantiteStockMin", decimal.Parse(txtQuantiteStockMin.Text));
                command.Parameters.AddWithValue("@ControleDeStock", chkControleDeStock.Checked);
                command.Parameters.AddWithValue("@ControleDeReservation", chkControleDeReservation.Checked);

                try
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Article mis à jour avec succès !");
                    LoadArticles(); // Refresh the DataGridView after updating
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erreur lors de la mise à jour de l'article: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet article ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "DELETE FROM Articles WHERE Code = @Code";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Code", txtCode.Text);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Article supprimé avec succès !");
                        LoadArticles(); // Refresh the DataGridView after deleting
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erreur lors de la suppression de l'article: {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void LoadArticles()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Code, Designation, Famille, UniteDeMesure, Majore, PrixHT, TVA, QuantiteEnStock, QuantiteStockMin, ControleDeStock, ControleDeReservation FROM Articles";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgvArticles.DataSource = dataTable;
            }
        }

        private void dgvArticles_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticles.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgvArticles.SelectedRows[0];
                txtCode.Text = row.Cells["Code"].Value.ToString();
                txtDesignation.Text = row.Cells["Designation"].Value.ToString();
                cmbFamille.SelectedItem = row.Cells["Famille"].Value.ToString();
                cmbUniteDeMesure.SelectedItem = row.Cells["UniteDeMesure"].Value.ToString();
                chkMajore.Checked = Convert.ToBoolean(row.Cells["Majore"].Value);
                txtPrixHT.Text = row.Cells["PrixHT"].Value.ToString();
                txtTVA.Text = row.Cells["TVA"].Value.ToString();
                txtQuantiteEnStock.Text = row.Cells["QuantiteEnStock"].Value.ToString();
                txtQuantiteStockMin.Text = row.Cells["QuantiteStockMin"].Value.ToString();
                chkControleDeStock.Checked = Convert.ToBoolean(row.Cells["ControleDeStock"].Value);
                chkControleDeReservation.Checked = Convert.ToBoolean(row.Cells["ControleDeReservation"].Value);
            }
        }
    }
}
