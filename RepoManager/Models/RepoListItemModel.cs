namespace RepoManager.Models
{
    public class RepoListItemModel
    {
        public bool IsSelected { get; set; } = false;
        public string RepoName { get; set; } = "";

        public RepoListItemModel(string name)
        {
            RepoName = name;
        }
        public RepoListItemModel()
        {

        }
    }
}
