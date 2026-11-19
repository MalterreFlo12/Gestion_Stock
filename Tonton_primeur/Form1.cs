using MySqlConnector;
using System.ComponentModel.DataAnnotations.Schema;
using System.DirectoryServices;
using System.Net.Security;

namespace Tonton_primeur
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fournisseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms_Fournisseurs f = new Forms_Fournisseurs();
            f.MdiParent = this;
            f.Show();
        }

        private void articlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms_Articles f = new Forms_Articles();
            f.MdiParent = this;
            f.Show();
        }
    }
}
