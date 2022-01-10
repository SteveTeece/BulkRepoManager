using Microsoft.AspNetCore.Components;
using RepoManager.Models;

namespace RepoManager.Controls
{
    public partial class OrgTree : ComponentBase
    {
        UserModel user = new();
        string username = "";
        List<string> Organisations = new List<string>();    

        public OrgTree()
        {
            // Create test display user
            user.Name = "Dummy User";
            user.Organisations.Add("Organisation 1");
            user.Organisations.Add("Organisation 2");
            user.Organisations.Add("Organisation 3");

        }
    }
}
