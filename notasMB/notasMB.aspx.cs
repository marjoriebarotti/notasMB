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
        }       

        //adicionar nota
        public void Adicionar()
        {
            List<Notas> lista = new List<Notas>();

            Notas n = new Notas();
            n.id = txtid.Text;
            n.data = txtdata.Text;
            n.valor = txtvalor.Text;
            n.desc = txtdesc.Text;

            bool contem = lista.Contains(id.Text);//verifica se a nota contem na lista

            if(contem)
            {
                Response.Write("<script>alert('Essa nota já foi cadastrada anteriormente.');</script>");
            }
            else
            {
                lista.Add(n);
                Limpar();
                Response.Write("<script>alert('Sua nota foi cadastrada com sucesso');</script>");                
            }   
        }

        //excluir nota
        public void Excluir()
        {            
        }

        //pesquisar nota
        public void Pesquisar()
        {                        
        }

        //editar nota
        public void Editar()
        {
        }

        protected void btnIncluir_Click(object sender, EventArgs e)
        {
            Adicionar();
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