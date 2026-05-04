using System;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace ListaImpressoras
{
    public partial class ImpressorasForm : Form
    {
        public string ImpressoraSelecionada { get; private set; }

        public ImpressorasForm()
        {
            InitializeComponent();
            ListarImpressoras();
            ImpressoraSelecionada = ImpressoraService.ObterImpressoraPadrao();
        }

        private void ListarImpressoras()
        {
            ListBoxImpressoras.Items.Clear();
            ListBoxImpressoras.Items.AddRange(ImpressoraService.ListarImpressoras());
        }

        private void BtnAtualizarLista_Click(object sender, EventArgs e)
        {
            ListarImpressoras();
        }

        private void BtnBuscarImpressoraPadrao_Click(object sender, EventArgs e)
        {
            string padrao = ImpressoraService.ObterImpressoraPadrao();
            ImpressoraSelecionada = new PrinterSettings().PrinterName;
            MessageBox.Show($"Impressora padrão: {padrao}");
        }

        private void BtnDefinirComoPadrao_Click(object sender, EventArgs e)
        {
            if (ListBoxImpressoras.SelectedItem == null)
            {
                MessageBox.Show("Selecione uma impressora!");
                return;
            }

            bool sucesso = ImpressoraService.DefinirComoPadrao(ListBoxImpressoras.SelectedItem.ToString());

            MessageBox.Show(sucesso
                ? "Impressora definida como padrão!"
                : "Erro ao definir impressora!");
        }

        private void ImpressorasForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }

        private void BtnConfirmar_Click(object sender, EventArgs e)
        {
            ImpressoraSelecionada = new PrinterSettings().PrinterName;
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
