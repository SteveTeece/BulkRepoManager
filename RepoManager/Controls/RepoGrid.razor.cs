﻿using Microsoft.AspNetCore.Components;
using RepoManager.Models;

namespace RepoManager.Controls
{
    public partial class RepoGrid : ComponentBase
    {
        [Parameter]
        public List<RepoListItemModel> RepoList { get; set; } = new();

    }
}
