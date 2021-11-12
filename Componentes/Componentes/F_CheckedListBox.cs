using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class F_CheckedListBox : Form
    {
        public F_CheckedListBox()
        {
            InitializeComponent();
        }

        private void btn_mostrarSelecionados_Click(object sender, EventArgs e)
        {
            string txt = "";
            foreach (string t in clb_Transportes.CheckedItems)
            {
                txt += t + ", ";
            }
            MessageBox.Show(txt);
        }

        private void btn_limparLista_Click(object sender, EventArgs e)
        {
            clb_Transportes.Items.Clear();
        }

        private void btn_resetarLista_Click(object sender, EventArgs e)
        {
            clb_Transportes.Items.Clear();
            List<string> tr = new List<string>();
            tr.Add("Carro");
            tr.Add("Avião");
            tr.Add("Navio");
            tr.Add("Ônibus");
            tr.Add("Trem");
            clb_Transportes.Items.AddRange(tr.ToArray());
        }

        private void btn_AdiNovoTransporte_Click(object sender, EventArgs e)
        {
            if (tb_NovoTransporte.Text != "")
            {
                clb_Transportes.Items.Add(tb_NovoTransporte.Text);
                tb_NovoTransporte.Clear();
                tb_NovoTransporte.Focus();
            }
        }
    }
}
