using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Tonton_primeur
{
    internal class fournisseur
    {
        private int id_fournisseur;
        private string nom;
        private string telephone;
        private string email;
        private string adresse;

        public fournisseur(int id_fournisseur, string nom, string telephone, string email, string adresse)
        {
            this.id_fournisseur = id_fournisseur;
            this.nom = nom;
            this.telephone = telephone;
            this.email = email;
            this.adresse = adresse;
        }

        public int getId() { return this.id_fournisseur; }
        public string getnom() { return this.nom; }
        public string gettelephone() { return this.telephone; }
        public string getemail() { return this.email; }
        public string getadresse() { return this.adresse; }


        public void setId(int id_fournisseur) { this.id_fournisseur = id_fournisseur; }
        public void setnom(string nom) { this.nom = nom; }
        public void settelephone(string telephone) { this.telephone = telephone; }
        public void setemail(string email) { this.email = email; }
        public void setadresse(string adresse) { this.adresse = adresse; }
    }
}
