using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;

namespace BLL
{
    class BLL_Livro
    {
        Conexao bd = new Conexao();

        public void InserirLivro(DTO_Livro l)
        {
            try
            {
                string comando = "INSERT INTO Livro VALUES (NULL, '" + l.Titulo + "','"
                                                                           + l.Descricao + "');";
                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
