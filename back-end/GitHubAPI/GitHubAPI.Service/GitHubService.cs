using System;
using Octokit;

namespace GitHubAPI.Service
{
    public class GitHubService
    {
        private GitHubClient github;

        public GitHubService()
        {
            github = new GitHubClient(new ProductHeaderValue("MyAmazingApp"));
        }

        // Step 1-2
        public async void GetDetails(string username = "caduaguiar")
        {
            var user = await github.User.Get(username);
        }

        //  Step 1-1
        public async void GetUsersSince(DateTime since)
        {

            var request = new SearchUsersRequest("dhh")
            {
                //Created = DateRange.GreaterThanOrEquals(since)
                Created = DateRange.GreaterThanOrEquals(new DateTime(2021, 06,12))
            };

            var result = await github.Search.SearchUsers(request);

            var aux = 10;
        }

        // Step 1-3
        public async void GetRepos(string username = "caduaguiar")
        {
            var repos = await github.Repository.GetAllForUser(username);
        }

    }
}
