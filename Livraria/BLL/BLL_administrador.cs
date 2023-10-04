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
     class BLL_administrador
    {
        Conexao bd = new Conexao();

        public void InserirAdmin(DTO_Admin ad)
        {
            try
            {
                string comando = "INSERT INTO administrador VALUES (NULL, '" + ad.Email + "','"
                                                             
                                                                           + ad.Senha + "');";
                bd.ExecutarComandos(comando);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



    }
}
