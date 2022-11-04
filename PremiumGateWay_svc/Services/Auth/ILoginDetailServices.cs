using PremiumGateWay_svc.DTOs.Auth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumGateWay_svc.Services.Auth
{
    public interface ILoginDetailServices
    {
        string Token { get; }

        string[] Roles { get; }

        string[] Permissions { get; }

        bool IsLogin { get; }

        LoginDetailDto GetClaim();

        bool CheckPermission(string permission);

        bool CheckRole(string role);
    }
}