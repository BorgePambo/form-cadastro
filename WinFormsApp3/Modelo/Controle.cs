using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp3.DAO;

namespace WinFormsApp3.Modelo
{
    internal class Controle
    {
        public bool tem;
        public String mensagem;

        public bool acessar(String email, String senha) {

            LoginDaoComandos loginDao = new LoginDaoComandos();
            tem = loginDao.verificarLogin(email, senha);
            if (!loginDao.mensagem.Equals("")) {
               mensagem =  loginDao.mensagem;
            }

            return tem;
        }

        public String cadastrar(String email, String senha, String confSenha)
        {
            LoginDaoComandos loginDao = new LoginDaoComandos();
            this.mensagem = loginDao.cadastrar(email, senha, confSenha);
            if (loginDao.tem) {
                this.tem = true;
            }

            return mensagem;
        }

    }
}
