using AutoMapper;
using PremiumGateWay_svc.Examples.Contracts;
using PremiumGateWay_svc.Examples.DTOs;
using PremiumGateWay_svc.Examples.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PremiumGateWay_svc.Examples
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<SampleMessage, ExampleModels>()
                .ForMember(_ => _.ExampleName, _ => _.MapFrom(_ => _.Name))
                .ReverseMap();

            CreateMap<ExampleModels, GetExampleReponseDto>();
        }
    }
}
