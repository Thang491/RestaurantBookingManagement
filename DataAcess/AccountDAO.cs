using BussinessObject2;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess
{
    public class AccountDAO
    {
        public static List<Account> GetAccounts()
        {
            List<Account> listAcc = new List<Account>();
            try
            {
                using (var context = new restaurant2Context())
                {
                    listAcc = context.Accounts.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return listAcc;
        }

        public static Account GetAccountByName(string name)
        {
            Account account = new Account();
            try
            {
                using (var context = new restaurant2Context())
                {
                    account = GetAccounts().FirstOrDefault(x => x.Username == name);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return account;
        }

        public static void SaveAccount(Account account)
        {
            try
            {
                using (var context = new restaurant2Context())
                {
                    context.Accounts.Add(account);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void DeleteAccount(Account account)
        {
            try
            {
                using (var context = new restaurant2Context())
                {
                    var p1 = context.Accounts.SingleOrDefault(m => m.Aid == account.Aid);
                    context.Accounts.Remove(p1);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void UpdateAccount(Account account)
        {
            try
            {
                using (var context = new restaurant2Context())
                {
                    context.Entry<Account>(account).State = EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Account GetAccountById(int id)
        {
            Account account = new Account();
            try
            {
                using (var context = new restaurant2Context())
                {
                    account = context.Accounts

                        .SingleOrDefault(m => m.Aid == id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return account;
        }

        public static Account GetAccountByIndex(int index)
        {

            Account account = null;
            try
            {
                using (var context = new restaurant2Context())
                {
                    List<Account> listaccount = context.Accounts.ToList();
                    account = listaccount[index];
                }
                return account;
            }


            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

    }
}
