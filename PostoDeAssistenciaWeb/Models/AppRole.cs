using Microsoft.AspNet.Identity.EntityFramework;

namespace PostoDeAssistenciaWeb.Models
{
    public class AppRole : IdentityRole
    {
        public AppRole() : base() { }
        public AppRole(string name) : base(name) { }
    }
}