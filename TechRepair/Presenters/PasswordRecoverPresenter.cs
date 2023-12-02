using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechRepair.Models;
using TechRepair.Views;

namespace TechRepair.Presenters
{
    public class PasswordRecoverPresenter
    {
        private IPasswordRecoverForm view;
        private ILoginRepository repository;
        private readonly string sqlConnection;

        public PasswordRecoverPresenter(IPasswordRecoverForm view, ILoginRepository repository, string sqlConnection)
        {
            this.view = view;
            this.repository = repository;
            this.sqlConnection = sqlConnection;
            this.view.RecoverPasswordEvent += RecoverPassoword;
        }

        private void RecoverPassoword(object sender, EventArgs e)
        {
            var result = repository.recoverPassword(view.userOrEmail);
            view.result = result;
        }
    }
}
