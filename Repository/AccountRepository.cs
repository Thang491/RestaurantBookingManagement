using BussinessObject2;
using DataAcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AccountRepository : IAccountRepository
    {
        public List<Account> GetAccounts() => AccountDAO.GetAccounts();

        public Account GetAccountByName(string name) => AccountDAO.GetAccountByName(name);
        public void SaveAccount(Account p) => AccountDAO.SaveAccount(p);


        public void DeleteAccount(Account p) => AccountDAO.DeleteAccount(p);


        public void UpdateAccount(Account p) => AccountDAO.UpdateAccount(p);


        public Account GetAccountById(int id) => AccountDAO.GetAccountById(id);

        public List<Role> GetRoles() => RoleDAO.GetRoles();

        public Account GetAccountByIndex(int index) => AccountDAO.GetAccountByIndex(index);
    }
}
