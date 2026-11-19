using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Tonton_primeur
{
    internal class Articles
    {
        private int id_article;
        private string nom;
        private string type;
        private float prix_unitaire;
        private int quantite_stock;
        private int id_fournisseur;

        public Articles(int id_article, string nom, string type, float prix_unitaire, int quantite_stock, int id_fournisseur) {
            this.id_article = id_article;
            this.nom = nom;
            this.type = type;
            this.prix_unitaire = prix_unitaire;
            this.quantite_stock = quantite_stock;
            this.id_fournisseur = id_fournisseur;
        }

        public int getId() { return this.id_article; }
        public string getnom() { return this.nom; }
        public string gettype() { return this.type; }
        public float getprix_unitaire() { return this.prix_unitaire; }
        public int getquantite_stock() { return this.quantite_stock; }
        public int getid_fournisseur() { return this.id_fournisseur; }

        public void setId(int id_article) { this.id_article = id_article; }
        public void setnom(string nom) { this.nom = nom; }
        public void settype(string type) { this.type = type; }
        public void setprix_unitaire(float prix_unitaire) { this.prix_unitaire = prix_unitaire; }
        public void setquantite_stock(int quantite_stock) { this.quantite_stock = quantite_stock; }
        public void setid_fournisseur(int id_fournisseur) { this.id_fournisseur = id_fournisseur; }

    }
}
