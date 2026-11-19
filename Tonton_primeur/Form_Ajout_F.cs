using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Tonton_primeur
{
    public partial class Form_Ajout_F : Form
    {
        private readonly string connectionString =
            "Server=localhost;User ID=root;Password=floflo12;Database=stock_fruits_legumes;";

        private static readonly Regex ValidateEmailRegex =
            new Regex(@"^\S+@\S+\.\S+$", RegexOptions.Compiled);

        public Form_Ajout_F()
        {
            InitializeComponent();
        }

        private void Form_Ajout_F_Load(object sender, EventArgs e)
        {

        }

        private void b_Ajout_F_Click(object sender, EventArgs e)
        {
            Ajout();
        }

        private void Ajout()
        {
            string nom = tb_nom_F.Text.Trim();
            string telephone = tb_Tel_F.Text.Trim();
            string email = tb_Email_F.Text.Trim();
            string adresse = tb_Adresse_F.Text.Trim();

            if (string.IsNullOrEmpty(nom) || string.IsNullOrEmpty(telephone))
            {
                MessageBox.Show("Le nom et le téléphone sont obligatoires.",
                                 "Champs manquants",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                return;
            }

            if (!string.IsNullOrEmpty(email) && !ValidateEmailRegex.IsMatch(email))
            {
                MessageBox.Show("L'adresse email n'est pas valide.",
                                 "Email invalide",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Warning);
                tb_Email_F.Focus();
                return;
            }

            try
            {
                using var connexion = new MySqlConnection(connectionString);
                connexion.Open();

                using var command = connexion.CreateCommand();
                command.CommandText =
                    "INSERT INTO fournisseur (nom, telephone, email, adresse) " +
                    "VALUES (@nom, @telephone, @email, @adresse);";

                command.Parameters.AddWithValue("@nom", nom);
                command.Parameters.AddWithValue("@telephone", telephone);
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@adresse", adresse);

                int lignesAffectees = command.ExecuteNonQuery();

                if (lignesAffectees > 0)
                {
                    MessageBox.Show("Fournisseur ajouté avec succès.",
                                     "Succès",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                    tb_nom_F.Clear();
                    tb_Tel_F.Clear();
                    tb_Email_F.Clear();
                    tb_Adresse_F.Clear();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Erreur lors de l'insert du fournisseur : {ex.Message}",
                                 "Erreur base de données",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
            }
        }
    }
}