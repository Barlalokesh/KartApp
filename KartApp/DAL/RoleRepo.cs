using KartApp.Models;

namespace KartApp.DAL
{
    public class RoleRepo
    {
        private readonly KartDbContext _kartDbContext;

        public RoleRepo(KartDbContext kartDbContext)
        {
            _kartDbContext = kartDbContext;
        }
        public List<Role> getRoles()
        {
            var data = _kartDbContext.Roles.ToList();
            return data;
        }
        public Role ? getRoleById(int id) 
        {
            var data= _kartDbContext.Roles.FirstOrDefault(r => r.Id == id);
            return data;
        }
        public bool AddRoles(Role role)
        {
            try
            {
                _kartDbContext.Roles.Add(role);
                _kartDbContext.SaveChanges();
                return true;
            }
            catch(Exception ) 
            { 
                return false;
            }
        }

    } 
}
