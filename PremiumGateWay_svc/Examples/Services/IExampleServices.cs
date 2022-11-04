using PremiumGateWay_svc.Examples.DTOs;
using PremiumGateWay_svc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumGateWay_svc.Examples.Services
{
    public interface IExampleServices
    {
        ServiceResponse<GetExampleReponseDto> GetExample(GetExampleRequestDto dto);
    }
}
