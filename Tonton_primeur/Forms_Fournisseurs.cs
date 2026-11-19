using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Tonton_primeur
{
    public partial class Forms_Fournisseurs : Form
    {
        private readonly string connectionString;

        public Forms_Fournisseurs()
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

        private void Fournisseurs_Load(object sender, EventArgs e)
        {
            ChargerFournisseurs();
        }

        public void ChargerFournisseurs()
        {
            try
            {
                using var connexion = new MySqlConnection(connectionString);
                connexion.Open();
                using var command = connexion.CreateCommand();
                command.CommandText = @"SELECT id_fournisseur, nom, telephone, email, adresse FROM fournisseur ORDER BY id_fournisseur ASC;";

                using var adapter = new MySqlDataAdapter(command);
                var table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erreur lors du chargement des fournisseurs : {ex.Message}",
                                "Erreur base de données",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void b_Ajouter_Click(object sender, EventArgs e)
        {
            using (var F = new Form_Ajout_F())
            {
                F.ShowDialog();
            }
            ChargerFournisseurs(); // rafraîchit après l'ajout
        }

        private void b_supr_F_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un fournisseur à supprimer.",
                                "Aucune sélection",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridView1.SelectedRows[0];
            int id_fournisseur = Convert.ToInt32(selectedRow.Cells["id_fournisseur"].Value);
            string nom = selectedRow.Cells["nom"].Value?.ToString() ?? "";

            var confirmation = MessageBox.Show(
                $"Voulez-vous vraiment supprimer le fournisseur \"{nom}\" ?",
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
                command.CommandText = "DELETE FROM fournisseur WHERE id_fournisseur = @id;";
                command.Parameters.AddWithValue("@id", id_fournisseur);

                int lignesAffectees = command.ExecuteNonQuery();

                if (lignesAffectees > 0)
                {
                    MessageBox.Show("Fournisseur supprimé avec succès.",
                                    "Succès",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                    ChargerFournisseurs();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erreur lors de la suppression du fournisseur : {ex.Message}",
                                "Erreur base de données",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        public void b_Modifier_F_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un fournisseur à modifier.",
                                "Aucune sélection",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            // Récupère les valeurs de la ligne sélectionnée
            var ligne = dataGridView1.SelectedRows[0];
            int id = Convert.ToInt32(ligne.Cells["id_fournisseur"].Value);
            string nom = ligne.Cells["nom"].Value?.ToString() ?? "";
            string telephone = ligne.Cells["telephone"].Value?.ToString() ?? "";
            string email = ligne.Cells["email"].Value?.ToString() ?? "";

            // Les 4 arguments correspondent au constructeur (int, string, string, string)
            using (var F = new Form_Modif_F(id, nom, telephone, email))
            {
                if (F.ShowDialog() == DialogResult.OK)
                {
                    ChargerFournisseurs(); // rafraîchit la grille
                }
            }
        }

        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}