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
            public int Codigo { get; set; }
            public string id { get; set; }
            public string data { get; set; }
            public string valor { get; set; } 
            public string desc { get; set; }
        }

        //lista de clientes que será manipulada
        private List<Notas> notas = new List<Notas>();

        //váriavel de controle para saber se esta atualizando ou adicionando
        private int i = -1;

        private int Obter()
        {
            int retorno = 0;
            if(notas.Count == 0)
            {
                retorno = 1;
                return retorno;
            }
            else
            {
                retorno = notas.Max(x => x.Codigo) + 1;
                return retorno;
            }
        }

        private void Limpar()
        {
            txtid.Text = "";
            txtdata.Text = "";
            txtvalor.Text = "";
            txtdesc.Text = "";
        }




        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnIncluir_Click(object sender, EventArgs e)
        {
            //se i=-1 é porque é uma nova nota
            if (i==-1)
            {
                var nota = new Notas(); //instância novo cliente
                nota.Codigo = Obter();
                nota.id = txtid.Text;
                nota.data = txtdata.Text;
                nota.valor = txtvalor.Text;
                nota.desc = txtdesc.Text;

                notas.Add(nota);

                Limpar();
            }
        }
    }
}