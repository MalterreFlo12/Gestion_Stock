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
    public partial class Form_Ajout_A : Form
    {
        private readonly string connectionString =
            "Server=localhost;User ID=root;Password=floflo12;Database=stock_fruits_legumes;";
        public Form_Ajout_A()
        {
            InitializeComponent();
            ChargerFournisseursCombo();
        }

        private void cb_Fournisseur_A_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ChargerFournisseursCombo()
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT nom FROM fournisseur ORDER BY nom ASC;";

                    using (var cmd = new MySqlCommand(query, conn))
                    using (var adapter = new MySqlDataAdapter(cmd))
                    {
                        var table = new DataTable();
                        adapter.Fill(table);

                        cb_Fournisseur_A.DataSource = table;
                        cb_Fournisseur_A.DisplayMember = "nom";
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

        // Prérequête : récupère l'id du fournisseur à partir de son nom
        private int? RecupererIdFournisseur(string nomFournisseur)
        {
            try
            {
                using (var conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = "SELECT id_fournisseur FROM fournisseur WHERE nom = @nom LIMIT 1;";

                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@nom", nomFournisseur);

                        object result = cmd.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                            return Convert.ToInt32(result);

                        return null;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erreur lors de la récupération de l'id : " + ex.Message,
                                "Erreur base de données", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void b_Ajout_F_Click(object sender, EventArgs e)
        {
            Ajout();
        }

        private void cb_Type_A_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Ajout()
        {
            string nom = tb_nom_A.Text.Trim();
            string type = cb_Type_A.Text.Trim();
            string prix_unitaire = tb_Prix_A.Text.Trim();
            string quantite_stock = tb_Quantité_A.Text.Trim();

            // Vérifications avant l'insertion
            if (cb_Fournisseur_A.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez sélectionner un fournisseur.",
                                "Champ manquant", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(prix_unitaire, out decimal prix) ||
                !int.TryParse(quantite_stock, out int quantite))
            {
                MessageBox.Show("Le prix et la quantité doivent être des nombres valides.",
                                "Valeur invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Prérequête : id du fournisseur grâce au nom sélectionné
            int? id_fournisseur = RecupererIdFournisseur(cb_Fournisseur_A.Text.Trim());

            if (!id_fournisseur.HasValue)
            {
                MessageBox.Show("Fournisseur introuvable dans la base de données.",
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using var connexion = new MySqlConnection(connectionString);
                connexion.Open();

                using var command = connexion.CreateCommand();
                command.CommandText =
                    "INSERT INTO article (nom, type, prix_unitaire, quantite_stock, id_fournisseur) " +
                    "VALUES (@nom, @type, @prix_unitaire, @quantite_stock, @id_fournisseur);";

                command.Parameters.AddWithValue("@nom", nom);
                command.Parameters.AddWithValue("@type", type);
                command.Parameters.AddWithValue("@prix_unitaire", prix);
                command.Parameters.AddWithValue("@quantite_stock", quantite);
                command.Parameters.AddWithValue("@id_fournisseur", id_fournisseur.Value);

                int lignesAffectees = command.ExecuteNonQuery();

                if (lignesAffectees > 0)
                {
                    MessageBox.Show("Article ajouté avec succès.",
                                     "Succès",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                    tb_nom_A.Clear();
                    cb_Type_A.SelectedIndex = -1;
                    tb_Prix_A.Clear();
                    tb_Quantité_A.Clear();
                    cb_Fournisseur_A.SelectedIndex = -1;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erreur lors de l'insert de l'article : {ex.Message}",
                                 "Erreur base de données",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }
    }
}