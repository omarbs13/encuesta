using System.Security.Principal;

namespace WebEncuesta.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
    }

    public class MyPrincipal : IPrincipal
    {
        public MyPrincipal(IIdentity identity)
        {
            Identity = identity;
        }
        public IIdentity Identity
        {
            get;
            private set;
        }
        public User User { get; set; }
        public bool IsInRole(string role)
        {
            return true;
        }
    }
}