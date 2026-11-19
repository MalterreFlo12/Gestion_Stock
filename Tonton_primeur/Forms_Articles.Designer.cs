namespace Tonton_primeur
{
    partial class Forms_Articles
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
            b_supr_F = new Button();
            b_Modifier_A = new Button();
            b_Ajouter_A = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(811, 356);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // b_supr_F
            // 
            b_supr_F.Location = new Point(215, 374);
            b_supr_F.Name = "b_supr_F";
            b_supr_F.Size = new Size(94, 29);
            b_supr_F.TabIndex = 6;
            b_supr_F.Text = "Supprimer";
            b_supr_F.UseVisualStyleBackColor = true;
            b_supr_F.Click += b_supr_F_Click;
            // 
            // b_Modifier_A
            // 
            b_Modifier_A.Location = new Point(115, 374);
            b_Modifier_A.Name = "b_Modifier_A";
            b_Modifier_A.Size = new Size(94, 29);
            b_Modifier_A.TabIndex = 5;
            b_Modifier_A.Text = "Modifier";
            b_Modifier_A.UseVisualStyleBackColor = true;
            b_Modifier_A.Click += b_Modifier_A_Click;
            // 
            // b_Ajouter_A
            // 
            b_Ajouter_A.Location = new Point(15, 374);
            b_Ajouter_A.Name = "b_Ajouter_A";
            b_Ajouter_A.Size = new Size(94, 29);
            b_Ajouter_A.TabIndex = 4;
            b_Ajouter_A.Text = "Ajouter";
            b_Ajouter_A.UseVisualStyleBackColor = true;
            b_Ajouter_A.Click += b_Ajouter_A_Click;
            // 
            // Forms_Articles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 466);
            Controls.Add(b_supr_F);
            Controls.Add(b_Modifier_A);
            Controls.Add(b_Ajouter_A);
            Controls.Add(dataGridView1);
            Name = "Forms_Articles";
            Text = "Forms_Articles";
            Load += Forms_Articles_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button b_supr_F;
        private Button b_Modifier_A;
        private Button b_Ajouter_A;
    }
}