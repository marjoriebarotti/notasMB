using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace notasMB
{
    public partial class notasMB : System.Web.UI.Page
    {
        public class Notas
        {
            public string id;
            public string data;
            public string valor;
            public string desc;

            public List<string> GeraID()
            {
                List<string> idnotas = new List<string>();
                for (int i =0; i <3000;i++)
                {
                    idnotas.Add("nota:" + i);
                }
                return idnotas;
            }

            public void Adicionar()
            {

            }

            public void Excluir()
            {

            }

            public void Pesquisar()
            {
                
            }
        }

        protected void btnIncluir_Click(object sender, EventArgs e)
        {
            Notas n = new Notas();

            n.id = txtid.Text;
            n.data = txtdata.Text;
            n.valor = txtvalor.Text;
            n.desc = txtdesc.Text;
        }

        //limpar os campos
        public void Limpar()
        {
            txtid.Text = "";
            txtdata.Text = "";
            txtvalor.Text = "";
            txtdesc.Text = "";
        }
    }
}