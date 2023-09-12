using NomeiaAi.Classes;

namespace NomeiaAi
{
    public partial class FrmNomeiaAi : Form
    {
        public FrmNomeiaAi()
        {
            InitializeComponent();
        }

        private void CkbController_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                CkbBusinessObjects.CheckedChanged -= CkbBusinessObjects_CheckedChanged;
                CkbBusinessObjects.Checked = !CkbController.Checked;
                CkbBusinessObjects.CheckedChanged += CkbBusinessObjects_CheckedChanged;
                BtnGerar.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CkbBusinessObjects_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                CkbController.CheckedChanged -= CkbController_CheckedChanged;
                CkbController.Checked = !CkbBusinessObjects.Checked;
                CkbController.CheckedChanged += CkbController_CheckedChanged;
                BtnGerar.PerformClick();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BtnGerar_Click(object sender, EventArgs e)
        {
            try
            {
                //DgvResultado.DataSource = null;
                //DataTable dadosResultado = new();
                //dadosResultado.Columns.Add("Nome", typeof(string));
                //for (int i = 65; i < 100; i++)
                //{
                //    dadosResultado.Rows.Add(new string(Convert.ToChar(i), 20));
                //}
                //DgvResultado.DataSource = dadosResultado;
                //DgvResultado.Columns[0].Width = DgvResultado.Width - 20;

                TxbResultadoSimples.Text = Formatar.RemoverAcentosEspacosPreposicoes(TxbNome.Text);

                if (CkbBusinessObjects.Checked)
                {
                    TxbResultadoSimples.Text += "BO";
                }
                else
                {
                    TxbResultadoSimples.Text += "Controller";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            try
            {
                if (DgvResultado.RowCount > 0 && DgvResultado.CurrentRow != null)
                {
                    Clipboard.SetText(DgvResultado.Rows[DgvResultado.CurrentRow.Index].Cells[0].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}