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
    public partial class Form_Modif_F : Form
    {
        private readonly string connectionString;

        private int id_fournisseur; // l'id du fournisseur à modifier

        public Form_Modif_F()
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

        // Constructeur qui reçoit les données depuis la grille
        public Form_Modif_F(int id, string nom, string telephone, string email) : this()
        {
            id_fournisseur = id;
            tb_nom_F.Text = nom;
            tb_Tel_F.Text = telephone;
            tb_Email_F.Text = email;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form_Modif_F_Load(object sender, EventArgs e)
        {
        }

        private void tb_nom_F_TextChanged(object sender, EventArgs e)
        {
        }

        // Clic sur le bouton "Modifier" (b_modif_F)
        private void b_modif_F_Click(object sender, EventArgs e)
        {
            // Sécurité : si le formulaire a été ouvert sans id valide
            if (id_fournisseur <= 0)
            {
                MessageBox.Show("Aucun fournisseur sélectionné pour la modification.",
                                "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(tb_nom_F.Text))
            {
                MessageBox.Show("Le nom du fournisseur est obligatoire.",
                                "Champ manquant", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_nom_F.Focus();
                return;
            }

            try
            {
                using var connexion = new MySqlConnection(connectionString);
                connexion.Open();

                using var command = connexion.CreateCommand();
                command.CommandText = @"UPDATE fournisseur
                                        SET nom = @nom, telephone = @telephone, email = @email
                                        WHERE id_fournisseur = @id;";

                command.Parameters.AddWithValue("@nom", tb_nom_F.Text.Trim());
                command.Parameters.AddWithValue("@telephone", tb_Tel_F.Text.Trim());
                command.Parameters.AddWithValue("@email", tb_Email_F.Text.Trim());
                command.Parameters.AddWithValue("@id", id_fournisseur);

                int lignes = command.ExecuteNonQuery();

                if (lignes > 0)
                {
                    MessageBox.Show("Fournisseur modifié avec succès.", "Succès",
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