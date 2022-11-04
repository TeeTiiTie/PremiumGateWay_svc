using PremiumGateWay_svc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumGateWay_svc.Examples.Contracts
{
    public class SampleMessage : IId
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

    }
}
