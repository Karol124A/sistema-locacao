using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projeto_locadora_2022
{
    public class codigosGerais
    {
        public bool campoVazio(Control controle, string campo)
        {
            if (controle.Text == null)
            {
                MessageBox.Show("O campo " + campo + " é obrigatório!");
                controle.Focus();
                return true;
            }

            else
            {
                return false;
            }
        }

    }
}