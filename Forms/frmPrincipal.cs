using Projeto_CShap_Com_SQL.Servicos;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_CShap_Com_SQL.Forms
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        private async void btnSincronizar_ClickAsync(object sender, EventArgs e)
        {
            var sincronizador = new SincronizadorService();

            Cursor = Cursors.WaitCursor;
            await sincronizador.Sincronizar();
            Cursor = Cursors.Default;

            MessageBox.Show("Sincronização finalizada com sucesso", "Sincronização", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            var frm = new frmControleNaves();
            frm.ShowDialog();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
