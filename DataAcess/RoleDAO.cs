using BussinessObject2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess
{
    public class RoleDAO
    {

        public static List<Role> GetRoles()
        {
            List<Role> listRole = new List<Role>();
            try
            {
                using (var context = new restaurant2Context())
                {
                    listRole = context.Roles.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return listRole;

        }
    }
}
