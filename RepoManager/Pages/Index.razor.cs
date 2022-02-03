using Microsoft.AspNetCore.Components;
using RepoManager.Models;

namespace RepoManager.Pages
{
    public partial class Index : ComponentBase
    {
        public List<TreeViewItemModel> Tree { get; set; } = new(); // List to hold the User/Organisation tree data
        public List<RepoListItemModel> RepoList { get; set; } = new(); // List of the repositories for the User / Organisation

        

        protected override void OnInitialized()
        {
            base.OnInitialized();
            LoadDummyData();
        }

        public void GitHubLogin()
        {
            // Place code to commence OAuth flow to GitHub

        }

        private void LoadDummyData()
        {
            // This method populates the controls with dummy data for testing
            LoadDummyUserTree();
            LoadDummyRepoSamples();
        }

        private void LoadDummyRepoSamples()
        {
            for (int i = 1; i < 23; i++)
            {
                RepoList.Add(new RepoListItemModel { IsSelected = false, RepoName = $"Repository Sample {i}" });
            }
        }

        private void LoadDummyUserTree()
        {
            Tree.Add(new TreeViewItemModel { Id = "1", FolderName = "Tree Root", HasSubFolders = true, Expanded = true });
            Tree.Add(new TreeViewItemModel { Id = "2", FolderName = "Branch 1", ParentId = "1" });
            Tree.Add(new TreeViewItemModel { Id = "3", FolderName = "Branch 2", ParentId = "1" });
            Tree.Add(new TreeViewItemModel { Id = "4", FolderName = "Branch 3", ParentId = "1" });
        }

    }
}
