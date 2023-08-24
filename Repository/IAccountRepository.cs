using BussinessObject2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IAccountRepository
    {
        List<Account> GetAccounts();

        Account GetAccountByName(string name);

        void SaveAccount(Account p);
        void DeleteAccount(Account p);
        void UpdateAccount(Account p);
        List<Role> GetRoles();
        Account GetAccountByIndex(int index);
        Account GetAccountById(int id);
    }
}
