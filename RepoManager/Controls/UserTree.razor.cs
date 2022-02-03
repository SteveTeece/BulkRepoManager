using Microsoft.AspNetCore.Components;
using RepoManager.Models;

namespace RepoManager.Controls
{
    public partial class UserTree : ComponentBase
    {
        [Parameter]
        public List<TreeViewItemModel> TreeSourceData { get; set; } = new();

    }
}
