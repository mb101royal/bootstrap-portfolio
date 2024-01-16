using AutoMapper;
using bootstrap_portfolio.Business.ViewModels.AuthViewModels;
using bootstrap_portfolio.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bootstrap_portfolio.Business.Profiles
{
    public class AuthMappingProfile : Profile
    {
        public AuthMappingProfile()
        {
            CreateMap<RegisterViewModel, User>();
        }
    }
}
