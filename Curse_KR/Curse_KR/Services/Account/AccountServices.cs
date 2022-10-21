using BridgesCoModels.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;

namespace Curse_KR.Services
{
    public class AccountServices : IAccountService
    {
        private readonly HttpClient httpClient;
        public AccountServices(HttpClient _httpClient)
        {
            this.httpClient= _httpClient;
        }
        public List<Account> Accounts { get; set; } = new List<Account>();
  

        public async Task GetAccount()
        {
            var result = await httpClient.GetFromJsonAsync<List<Account>>("api/Accounts");
            if (result is not null)                   
            {
                Accounts = result;
            }
        }
    }
}
