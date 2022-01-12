namespace RepoManager.Models
{
    public class UserModel
    {
        public string Name { get; set; } = "";
        public List<string> Organisations { get; set; } = new ();
    }
}
