using MySqlConnector;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace Tonton_primeur
{
    public partial class Form_Modif_A : Form
    {
        private readonly string connectionString;
        private readonly int _id;

        public Form_Modif_A(int id, string nom, string type, decimal prix_unitaire, int quantite_stock, int id_fournisseur)
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

            _id = id;
            tb_nom_A.Text = nom;
            cb_Type_A.Text = type;
            tb_Prix_A.Text = prix_unitaire.ToString(CultureInfo.CurrentCulture);
            tb_Quantité_A.Text = quantite_stock.ToString();

            ChargerFournisseursCombo();
            cb_Fournisseur_A.SelectedValue = id_fournisseur;
        }

        private void ChargerFournisseursCombo()
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT id_fournisseur, nom FROM fournisseur ORDER BY nom ASC;";

                    using (var cmd = new MySqlCommand(query, conn))
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        var table = new DataTable();
                        adapter.Fill(table);

                        cb_Fournisseur_A.DataSource = table;
                        cb_Fournisseur_A.DisplayMember = "nom";
                        cb_Fournisseur_A.ValueMember = "id_fournisseur";
                        cb_Fournisseur_A.SelectedIndex = -1;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur lors du chargement des fournisseurs : " + ex.Message,
                                "Erreur base de données", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form_Modif_A_Load(object sender, EventArgs e)
        {
        }

        private void b_Modif_F_Click(object sender, EventArgs e)
        {
            if (_id <= 0)
            {
                MessageBox.Show("Aucun article sélectionné pour la modification.",
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(tb_nom_A.Text))
            {
                MessageBox.Show("Le nom de l'article est obligatoire.",
                                "Champ manquant", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_nom_A.Focus();
                return;
            }

            if (!decimal.TryParse(tb_Prix_A.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, out decimal prix))
            {
                MessageBox.Show("Le prix unitaire n'est pas valide.",
                                "Champ invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_Prix_A.Focus();
                return;
            }

            if (!int.TryParse(tb_Quantité_A.Text.Trim(), out int quantite))
            {
                MessageBox.Show("La quantité en stock n'est pas valide.",
                                "Champ invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_Quantité_A.Focus();
                return;
            }

            if (cb_Fournisseur_A.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner un fournisseur.",
                                "Champ manquant", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cb_Fournisseur_A.Focus();
                return;
            }

            try
            {
                using var connexion = new MySqlConnection(connectionString);
                connexion.Open();

                using var command = connexion.CreateCommand();
                command.CommandText = @"UPDATE article
                                        SET nom = @nom,
                                            type = @type,
                                            prix_unitaire = @prix_unitaire,
                                            quantite_stock = @quantite_stock,
                                            id_fournisseur = @id_fournisseur
                                        WHERE id_article = @id_article;";

                command.Parameters.AddWithValue("@nom", tb_nom_A.Text.Trim());
                command.Parameters.AddWithValue("@type", cb_Type_A.Text.Trim());
                command.Parameters.AddWithValue("@prix_unitaire", prix);
                command.Parameters.AddWithValue("@quantite_stock", quantite);
                command.Parameters.AddWithValue("@id_fournisseur", cb_Fournisseur_A.SelectedValue);
                command.Parameters.AddWithValue("@id_article", _id);

                int lignes = command.ExecuteNonQuery();

                if (lignes > 0)
                {
                    MessageBox.Show("Article modifié avec succès.", "Succès",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK; // ferme le formulaire modal et prévient la grille
                    Close();
                }
                else
                {
                    MessageBox.Show("Aucune modification effectuée.", "Information",
                                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur lors de la modification : " + ex.Message,
                                "Erreur base de données", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}