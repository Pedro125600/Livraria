using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
     class DTO_Admin
    {

        private int id, admin_id;
        public string email, senha;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }


        public int adminid
        {
            get
            { 
                return admin_id;
            }

            set { 
                admin_id = value; 
            }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }

    }
}
