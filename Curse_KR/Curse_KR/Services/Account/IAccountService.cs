using BridgesCoModels.Models;
using Microsoft.AspNetCore.Mvc;

namespace Curse_KR.Services
{
    public interface IAccountService
    {
        List<Account> Accounts { get; set; }
        Task GetAccount();
    }
}
