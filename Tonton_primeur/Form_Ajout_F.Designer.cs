namespace Tonton_primeur
{
    partial class Form_Ajout_F
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
            label1 = new Label();
            tb_nom_F = new TextBox();
            l_Nom_F = new Label();
            l_Tel_F = new Label();
            tb_Tel_F = new TextBox();
            l_Email_F = new Label();
            l_Adresse = new Label();
            tb_Email_F = new TextBox();
            tb_Adresse_F = new TextBox();
            b_Ajout_F = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(155, 20);
            label1.TabIndex = 0;
            label1.Text = "Ajout d'un Fournisseur";
            // 
            // tb_nom_F
            // 
            tb_nom_F.Location = new Point(12, 73);
            tb_nom_F.Name = "tb_nom_F";
            tb_nom_F.Size = new Size(125, 27);
            tb_nom_F.TabIndex = 1;
            // 
            // l_Nom_F
            // 
            l_Nom_F.AutoSize = true;
            l_Nom_F.Location = new Point(12, 50);
            l_Nom_F.Name = "l_Nom_F";
            l_Nom_F.Size = new Size(103, 20);
            l_Nom_F.TabIndex = 2;
            l_Nom_F.Text = "Nom Complet";
            // 
            // l_Tel_F
            // 
            l_Tel_F.AutoSize = true;
            l_Tel_F.Location = new Point(12, 103);
            l_Tel_F.Name = "l_Tel_F";
            l_Tel_F.Size = new Size(78, 20);
            l_Tel_F.TabIndex = 3;
            l_Tel_F.Text = "Téléphone";
            // 
            // tb_Tel_F
            // 
            tb_Tel_F.Location = new Point(12, 126);
            tb_Tel_F.Name = "tb_Tel_F";
            tb_Tel_F.Size = new Size(125, 27);
            tb_Tel_F.TabIndex = 4;
            // 
            // l_Email_F
            // 
            l_Email_F.AutoSize = true;
            l_Email_F.Location = new Point(12, 156);
            l_Email_F.Name = "l_Email_F";
            l_Email_F.Size = new Size(46, 20);
            l_Email_F.TabIndex = 5;
            l_Email_F.Text = "Email";
            // 
            // l_Adresse
            // 
            l_Adresse.AutoSize = true;
            l_Adresse.Location = new Point(12, 209);
            l_Adresse.Name = "l_Adresse";
            l_Adresse.Size = new Size(61, 20);
            l_Adresse.TabIndex = 6;
            l_Adresse.Text = "Adresse";
            // 
            // tb_Email_F
            // 
            tb_Email_F.Location = new Point(12, 179);
            tb_Email_F.Name = "tb_Email_F";
            tb_Email_F.Size = new Size(125, 27);
            tb_Email_F.TabIndex = 7;
            // 
            // tb_Adresse_F
            // 
            tb_Adresse_F.Location = new Point(12, 232);
            tb_Adresse_F.Name = "tb_Adresse_F";
            tb_Adresse_F.Size = new Size(125, 27);
            tb_Adresse_F.TabIndex = 8;
            // 
            // b_Ajout_F
            // 
            b_Ajout_F.Location = new Point(26, 278);
            b_Ajout_F.Name = "b_Ajout_F";
            b_Ajout_F.Size = new Size(94, 29);
            b_Ajout_F.TabIndex = 9;
            b_Ajout_F.Text = "Ajouter";
            b_Ajout_F.UseVisualStyleBackColor = true;
            b_Ajout_F.Click += b_Ajout_F_Click;
            // 
            // Form_Ajout_F
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 344);
            Controls.Add(b_Ajout_F);
            Controls.Add(tb_Adresse_F);
            Controls.Add(tb_Email_F);
            Controls.Add(l_Adresse);
            Controls.Add(l_Email_F);
            Controls.Add(tb_Tel_F);
            Controls.Add(l_Tel_F);
            Controls.Add(l_Nom_F);
            Controls.Add(tb_nom_F);
            Controls.Add(label1);
            Name = "Form_Ajout_F";
            Text = "Form_Ajout_F";
            Load += Form_Ajout_F_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_nom_F;
        private Label l_Nom_F;
        private Label l_Tel_F;
        private TextBox tb_Tel_F;
        private Label l_Email_F;
        private Label l_Adresse;
        private TextBox tb_Email_F;
        private TextBox tb_Adresse_F;
        private Button b_Ajout_F;
    }
}