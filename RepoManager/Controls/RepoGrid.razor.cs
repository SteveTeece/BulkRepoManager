using Microsoft.AspNetCore.Components;
using RepoManager.Models;

namespace RepoManager.Controls
{
    public partial class RepoGrid : ComponentBase
    {
        public List<RepoListItemModel> Repos { get; set; }

        public RepoGrid(List<RepoListItemModel> repos)
        {
            Repos = repos;
        }

        public RepoGrid()
        {

        }

        protected override void OnInitialized()
        {
            Repos = Enumerable.Range(1, 23).Select(x => new RepoListItemModel($"Test Data Repository {x}")).ToList();
        }

    }
}
