using MySqlConnector;
using System;
using System.Data;
using System.Windows.Forms;

namespace Tonton_primeur
{
    public partial class Forms_Articles : Form
    {
        // Chaîne de connexion centralisée
        private readonly string connectionString;

        public Forms_Articles()
        {
            InitializeComponent();

            var builder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                UserID = "root",
                Password = "floflo12",
                Database = "stock_fruits_legumes",
            };
            connectionString = builder.ConnectionString;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Forms_Articles_Load(object sender, EventArgs e)
        {
            ChargerArticles();
        }

        public void ChargerArticles()
        {
            try
            {
                using var connexion = new MySqlConnection(connectionString);
                connexion.Open();
                using var command = connexion.CreateCommand();
                command.CommandText = @"SELECT id_article, nom, type, prix_unitaire, quantite_stock, id_fournisseur FROM article ORDER BY id_article ASC;";

                using var adapter = new MySqlDataAdapter(command);
                var table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erreur lors du chargement des articles : {ex.Message}",
                                 "Erreur base de données",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }

        private void b_Ajouter_A_Click(object sender, EventArgs e)
        {
            using (var F = new Form_Ajout_A())
            {
                F.ShowDialog();
            }
            ChargerArticles();
        }

        private void b_Modifier_A_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un article à modifier.",
                                "Aucune sélection",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Récupère les valeurs de la ligne sélectionnée
            var ligne = dataGridView1.SelectedRows[0];
            int id = Convert.ToInt32(ligne.Cells["id_article"].Value);
            string nom = ligne.Cells["nom"].Value?.ToString() ?? "";
            string type = ligne.Cells["type"].Value?.ToString() ?? "";
            decimal prix_unitaire = Convert.ToDecimal(ligne.Cells["prix_unitaire"].Value);
            int quantite_stock = Convert.ToInt32(ligne.Cells["quantite_stock"].Value);
            int id_fournisseur = Convert.ToInt32(ligne.Cells["id_fournisseur"].Value);

            // Les 6 arguments correspondent au constructeur
            // (int, string, string, decimal, int, int)
            using (var F = new Form_Modif_A(id, nom, type, prix_unitaire, quantite_stock, id_fournisseur))
            {
                if (F.ShowDialog() == DialogResult.OK)
                {
                    ChargerArticles(); // rafraîchit la grille
                }
            }
        }

        private void b_supr_F_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un article à supprimer.",
                                "Aucune sélection",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridView1.SelectedRows[0];
            int id_article = Convert.ToInt32(selectedRow.Cells["id_article"].Value);
            string nom = selectedRow.Cells["nom"].Value?.ToString() ?? "";

            var confirmation = MessageBox.Show(
                $"Voulez-vous vraiment supprimer l'article \"{nom}\" ?",
                "Confirmation de suppression",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmation != DialogResult.Yes)
                return;

            try
            {
                using var connexion = new MySqlConnection(connectionString);
                connexion.Open();
                using var command = connexion.CreateCommand();
                command.CommandText = "DELETE FROM article WHERE id_article = @id;";
                command.Parameters.AddWithValue("@id", id_article);

                int lignesAffectees = command.ExecuteNonQuery();

                if (lignesAffectees > 0)
                {
                    MessageBox.Show("Article supprimé avec succès.",
                                    "Succès",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    ChargerArticles();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erreur lors de la suppression de l'article : {ex.Message}",
                                "Erreur base de données",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
    }
}