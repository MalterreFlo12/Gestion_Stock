namespace Tonton_primeur
{
    partial class Forms_Fournisseurs
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
            dataGridView1 = new DataGridView();
            b_Ajouter = new Button();
            b_Modifier_F = new Button();
            b_supr_F = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(909, 426);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // b_Ajouter
            // 
            b_Ajouter.Location = new Point(12, 444);
            b_Ajouter.Name = "b_Ajouter";
            b_Ajouter.Size = new Size(94, 29);
            b_Ajouter.TabIndex = 1;
            b_Ajouter.Text = "Ajouter";
            b_Ajouter.UseVisualStyleBackColor = true;
            b_Ajouter.Click += b_Ajouter_Click;
            // 
            // b_Modifier_F
            // 
            b_Modifier_F.Location = new Point(112, 444);
            b_Modifier_F.Name = "b_Modifier_F";
            b_Modifier_F.Size = new Size(94, 29);
            b_Modifier_F.TabIndex = 2;
            b_Modifier_F.Text = "Modifier";
            b_Modifier_F.UseVisualStyleBackColor = true;
            b_Modifier_F.Click += b_Modifier_F_Click;
            // 
            // b_supr_F
            // 
            b_supr_F.Location = new Point(212, 444);
            b_supr_F.Name = "b_supr_F";
            b_supr_F.Size = new Size(94, 29);
            b_supr_F.TabIndex = 3;
            b_supr_F.Text = "Supprimer";
            b_supr_F.UseVisualStyleBackColor = true;
            b_supr_F.Click += b_supr_F_Click;
            // 
            // Forms_Fournisseurs
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 598);
            Controls.Add(b_supr_F);
            Controls.Add(b_Modifier_F);
            Controls.Add(b_Ajouter);
            Controls.Add(dataGridView1);
            Name = "Forms_Fournisseurs";
            Text = "Fournisseurs";
            Load += Fournisseurs_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button b_Ajouter;
        private Button b_Modifier_F;
        private Button b_supr_F;
    }
}