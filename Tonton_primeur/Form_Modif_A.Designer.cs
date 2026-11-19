namespace Tonton_primeur
{
    partial class Form_Modif_A
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
            b_Modif_F = new Button();
            cb_Fournisseur_A = new ComboBox();
            label2 = new Label();
            cb_Type_A = new ComboBox();
            tb_Quantité_A = new TextBox();
            tb_Prix_A = new TextBox();
            l_Quantité = new Label();
            l_Prix_A = new Label();
            l_Type_A = new Label();
            l_Nom_A = new Label();
            tb_nom_A = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // b_Modif_F
            // 
            b_Modif_F.Location = new Point(29, 339);
            b_Modif_F.Name = "b_Modif_F";
            b_Modif_F.Size = new Size(94, 29);
            b_Modif_F.TabIndex = 29;
            b_Modif_F.Text = "Modifier";
            b_Modif_F.UseVisualStyleBackColor = true;
            b_Modif_F.Click += b_Modif_F_Click;
            // 
            // cb_Fournisseur_A
            // 
            cb_Fournisseur_A.FormattingEnabled = true;
            cb_Fournisseur_A.Location = new Point(12, 290);
            cb_Fournisseur_A.Name = "cb_Fournisseur_A";
            cb_Fournisseur_A.Size = new Size(151, 28);
            cb_Fournisseur_A.TabIndex = 40;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 267);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 39;
            label2.Text = "Fournisseur";
            // 
            // cb_Type_A
            // 
            cb_Type_A.FormattingEnabled = true;
            cb_Type_A.Items.AddRange(new object[] { "Fruit", "Légume" });
            cb_Type_A.Location = new Point(12, 129);
            cb_Type_A.Name = "cb_Type_A";
            cb_Type_A.Size = new Size(151, 28);
            cb_Type_A.TabIndex = 38;
            // 
            // tb_Quantité_A
            // 
            tb_Quantité_A.Location = new Point(12, 235);
            tb_Quantité_A.Name = "tb_Quantité_A";
            tb_Quantité_A.Size = new Size(125, 27);
            tb_Quantité_A.TabIndex = 37;
            // 
            // tb_Prix_A
            // 
            tb_Prix_A.Location = new Point(12, 182);
            tb_Prix_A.Name = "tb_Prix_A";
            tb_Prix_A.Size = new Size(125, 27);
            tb_Prix_A.TabIndex = 36;
            // 
            // l_Quantité
            // 
            l_Quantité.AutoSize = true;
            l_Quantité.Location = new Point(12, 212);
            l_Quantité.Name = "l_Quantité";
            l_Quantité.Size = new Size(66, 20);
            l_Quantité.TabIndex = 35;
            l_Quantité.Text = "Quantité";
            // 
            // l_Prix_A
            // 
            l_Prix_A.AutoSize = true;
            l_Prix_A.Location = new Point(12, 159);
            l_Prix_A.Name = "l_Prix_A";
            l_Prix_A.Size = new Size(33, 20);
            l_Prix_A.TabIndex = 34;
            l_Prix_A.Text = "Prix";
            // 
            // l_Type_A
            // 
            l_Type_A.AutoSize = true;
            l_Type_A.Location = new Point(12, 106);
            l_Type_A.Name = "l_Type_A";
            l_Type_A.Size = new Size(40, 20);
            l_Type_A.TabIndex = 33;
            l_Type_A.Text = "Type";
            // 
            // l_Nom_A
            // 
            l_Nom_A.AutoSize = true;
            l_Nom_A.Location = new Point(12, 53);
            l_Nom_A.Name = "l_Nom_A";
            l_Nom_A.Size = new Size(42, 20);
            l_Nom_A.TabIndex = 32;
            l_Nom_A.Text = "Nom";
            // 
            // tb_nom_A
            // 
            tb_nom_A.Location = new Point(12, 76);
            tb_nom_A.Name = "tb_nom_A";
            tb_nom_A.Size = new Size(125, 27);
            tb_nom_A.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(173, 20);
            label1.TabIndex = 30;
            label1.Text = "Modification d'un Article";
            // 
            // Form_Modif_A
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 450);
            Controls.Add(cb_Fournisseur_A);
            Controls.Add(label2);
            Controls.Add(cb_Type_A);
            Controls.Add(tb_Quantité_A);
            Controls.Add(tb_Prix_A);
            Controls.Add(l_Quantité);
            Controls.Add(l_Prix_A);
            Controls.Add(l_Type_A);
            Controls.Add(l_Nom_A);
            Controls.Add(tb_nom_A);
            Controls.Add(label1);
            Controls.Add(b_Modif_F);
            Name = "Form_Modif_A";
            Text = "Form_Modif_A";
            Load += Form_Modif_A_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button b_Modif_F;
        private ComboBox cb_Fournisseur_A;
        private Label label2;
        private ComboBox cb_Type_A;
        private TextBox tb_Quantité_A;
        private TextBox tb_Prix_A;
        private Label l_Quantité;
        private Label l_Prix_A;
        private Label l_Type_A;
        private Label l_Nom_A;
        private TextBox tb_nom_A;
        private Label label1;
    }
}