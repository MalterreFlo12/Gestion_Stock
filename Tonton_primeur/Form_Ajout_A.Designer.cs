namespace Tonton_primeur
{
    partial class Form_Ajout_A
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            b_Ajout_F = new Button();
            tb_Quantité_A = new TextBox();
            tb_Prix_A = new TextBox();
            l_Quantité = new Label();
            l_Prix_A = new Label();
            l_Type_A = new Label();
            l_Nom_A = new Label();
            tb_nom_A = new TextBox();
            label1 = new Label();
            cb_Type_A = new ComboBox();
            label2 = new Label();
            cb_Fournisseur_A = new ComboBox();
            SuspendLayout();
            // 
            // b_Ajout_F
            // 
            b_Ajout_F.Location = new Point(27, 349);
            b_Ajout_F.Name = "b_Ajout_F";
            b_Ajout_F.Size = new Size(94, 29);
            b_Ajout_F.TabIndex = 19;
            b_Ajout_F.Text = "Ajouter";
            b_Ajout_F.UseVisualStyleBackColor = true;
            b_Ajout_F.Click += b_Ajout_F_Click;
            // 
            // tb_Quantité_A
            // 
            tb_Quantité_A.Location = new Point(12, 237);
            tb_Quantité_A.Name = "tb_Quantité_A";
            tb_Quantité_A.Size = new Size(125, 27);
            tb_Quantité_A.TabIndex = 18;
            // 
            // tb_Prix_A
            // 
            tb_Prix_A.Location = new Point(12, 184);
            tb_Prix_A.Name = "tb_Prix_A";
            tb_Prix_A.Size = new Size(125, 27);
            tb_Prix_A.TabIndex = 17;
            // 
            // l_Quantité
            // 
            l_Quantité.AutoSize = true;
            l_Quantité.Location = new Point(12, 214);
            l_Quantité.Name = "l_Quantité";
            l_Quantité.Size = new Size(66, 20);
            l_Quantité.TabIndex = 16;
            l_Quantité.Text = "Quantité";
            // 
            // l_Prix_A
            // 
            l_Prix_A.AutoSize = true;
            l_Prix_A.Location = new Point(12, 161);
            l_Prix_A.Name = "l_Prix_A";
            l_Prix_A.Size = new Size(33, 20);
            l_Prix_A.TabIndex = 15;
            l_Prix_A.Text = "Prix";
            // 
            // l_Type_A
            // 
            l_Type_A.AutoSize = true;
            l_Type_A.Location = new Point(12, 108);
            l_Type_A.Name = "l_Type_A";
            l_Type_A.Size = new Size(40, 20);
            l_Type_A.TabIndex = 13;
            l_Type_A.Text = "Type";
            // 
            // l_Nom_A
            // 
            l_Nom_A.AutoSize = true;
            l_Nom_A.Location = new Point(12, 55);
            l_Nom_A.Name = "l_Nom_A";
            l_Nom_A.Size = new Size(42, 20);
            l_Nom_A.TabIndex = 12;
            l_Nom_A.Text = "Nom";
            // 
            // tb_nom_A
            // 
            tb_nom_A.Location = new Point(12, 78);
            tb_nom_A.Name = "tb_nom_A";
            tb_nom_A.Size = new Size(125, 27);
            tb_nom_A.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 14);
            label1.Name = "label1";
            label1.Size = new Size(124, 20);
            label1.TabIndex = 10;
            label1.Text = "Ajout d'un Article";
            // 
            // cb_Type_A
            // 
            cb_Type_A.FormattingEnabled = true;
            cb_Type_A.Items.AddRange(new object[] { "Fruit", "Légume" });
            cb_Type_A.Location = new Point(12, 131);
            cb_Type_A.Name = "cb_Type_A";
            cb_Type_A.Size = new Size(151, 28);
            cb_Type_A.TabIndex = 20;
            cb_Type_A.SelectedIndexChanged += cb_Type_A_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 269);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 21;
            label2.Text = "Fournisseur";
            // 
            // cb_Fournisseur_A
            // 
            cb_Fournisseur_A.FormattingEnabled = true;
            cb_Fournisseur_A.Location = new Point(12, 292);
            cb_Fournisseur_A.Name = "cb_Fournisseur_A";
            cb_Fournisseur_A.Size = new Size(151, 28);
            cb_Fournisseur_A.TabIndex = 22;
            cb_Fournisseur_A.SelectedIndexChanged += cb_Fournisseur_A_SelectedIndexChanged;
            // 
            // Form_Ajout_A
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(283, 412);
            Controls.Add(cb_Fournisseur_A);
            Controls.Add(label2);
            Controls.Add(cb_Type_A);
            Controls.Add(b_Ajout_F);
            Controls.Add(tb_Quantité_A);
            Controls.Add(tb_Prix_A);
            Controls.Add(l_Quantité);
            Controls.Add(l_Prix_A);
            Controls.Add(l_Type_A);
            Controls.Add(l_Nom_A);
            Controls.Add(tb_nom_A);
            Controls.Add(label1);
            Name = "Form_Ajout_A";
            Text = "Form_Ajout_A";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button b_Ajout_F;
        private TextBox tb_Quantité_A;
        private TextBox tb_Prix_A;
        private Label l_Quantité;
        private Label l_Prix_A;
        private Label l_Type_A;
        private Label l_Nom_A;
        private TextBox tb_nom_A;
        private Label label1;
        private ComboBox cb_Type_A;
        private Label label2;
        private ComboBox cb_Fournisseur_A;
    }
}