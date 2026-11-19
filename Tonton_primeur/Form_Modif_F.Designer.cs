namespace Tonton_primeur
{
    partial class Form_Modif_F
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
            tb_Adresse_F = new TextBox();
            tb_Email_F = new TextBox();
            l_Adresse = new Label();
            l_Email_F = new Label();
            tb_Tel_F = new TextBox();
            l_Tel_F = new Label();
            l_Nom_F = new Label();
            tb_nom_F = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // b_Modif_F
            // 
            b_Modif_F.Location = new Point(27, 278);
            b_Modif_F.Name = "b_Modif_F";
            b_Modif_F.Size = new Size(94, 29);
            b_Modif_F.TabIndex = 19;
            b_Modif_F.Text = "Modifier";
            b_Modif_F.UseVisualStyleBackColor = true;
            b_Modif_F.Click += b_modif_F_Click;
            // 
            // tb_Adresse_F
            // 
            tb_Adresse_F.Location = new Point(13, 232);
            tb_Adresse_F.Name = "tb_Adresse_F";
            tb_Adresse_F.Size = new Size(125, 27);
            tb_Adresse_F.TabIndex = 18;
            // 
            // tb_Email_F
            // 
            tb_Email_F.Location = new Point(13, 179);
            tb_Email_F.Name = "tb_Email_F";
            tb_Email_F.Size = new Size(125, 27);
            tb_Email_F.TabIndex = 17;
            // 
            // l_Adresse
            // 
            l_Adresse.AutoSize = true;
            l_Adresse.Location = new Point(13, 209);
            l_Adresse.Name = "l_Adresse";
            l_Adresse.Size = new Size(61, 20);
            l_Adresse.TabIndex = 16;
            l_Adresse.Text = "Adresse";
            // 
            // l_Email_F
            // 
            l_Email_F.AutoSize = true;
            l_Email_F.Location = new Point(13, 156);
            l_Email_F.Name = "l_Email_F";
            l_Email_F.Size = new Size(46, 20);
            l_Email_F.TabIndex = 15;
            l_Email_F.Text = "Email";
            // 
            // tb_Tel_F
            // 
            tb_Tel_F.Location = new Point(13, 126);
            tb_Tel_F.Name = "tb_Tel_F";
            tb_Tel_F.Size = new Size(125, 27);
            tb_Tel_F.TabIndex = 14;
            // 
            // l_Tel_F
            // 
            l_Tel_F.AutoSize = true;
            l_Tel_F.Location = new Point(13, 103);
            l_Tel_F.Name = "l_Tel_F";
            l_Tel_F.Size = new Size(78, 20);
            l_Tel_F.TabIndex = 13;
            l_Tel_F.Text = "Téléphone";
            // 
            // l_Nom_F
            // 
            l_Nom_F.AutoSize = true;
            l_Nom_F.Location = new Point(13, 50);
            l_Nom_F.Name = "l_Nom_F";
            l_Nom_F.Size = new Size(103, 20);
            l_Nom_F.TabIndex = 12;
            l_Nom_F.Text = "Nom Complet";
            // 
            // tb_nom_F
            // 
            tb_nom_F.Location = new Point(13, 73);
            tb_nom_F.Name = "tb_nom_F";
            tb_nom_F.Size = new Size(125, 27);
            tb_nom_F.TabIndex = 11;
            tb_nom_F.TextChanged += tb_nom_F_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 9);
            label1.Name = "label1";
            label1.Size = new Size(204, 20);
            label1.TabIndex = 10;
            label1.Text = "Modification d'un Fournisseur";
            label1.Click += label1_Click;
            // 
            // Form_Modif_F
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 450);
            Controls.Add(b_Modif_F);
            Controls.Add(tb_Adresse_F);
            Controls.Add(tb_Email_F);
            Controls.Add(l_Adresse);
            Controls.Add(l_Email_F);
            Controls.Add(tb_Tel_F);
            Controls.Add(l_Tel_F);
            Controls.Add(l_Nom_F);
            Controls.Add(tb_nom_F);
            Controls.Add(label1);
            Name = "Form_Modif_F";
            Text = "Form_Modif_F";
            Load += Form_Modif_F_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button b_Modif_F;
        private TextBox tb_Adresse_F;
        private TextBox tb_Email_F;
        private Label l_Adresse;
        private Label l_Email_F;
        private TextBox tb_Tel_F;
        private Label l_Tel_F;
        private Label l_Nom_F;
        private TextBox tb_nom_F;
        private Label label1;
    }
}