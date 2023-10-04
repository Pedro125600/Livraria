using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     class DTO_Livro
    {
        int id, id_livro;

        string titulo, descricao;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public  int ID_livro
        {
            get { return id_livro; }
            set { id_livro = value; }
        }

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

    }
}
