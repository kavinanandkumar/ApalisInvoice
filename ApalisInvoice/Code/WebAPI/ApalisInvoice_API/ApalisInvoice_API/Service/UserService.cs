using ApalisInvoice.DAL.Interface;
using ApalisInvoice.DAL.Model;
using ApalisInvoice.ViewModel;
using ApalisInvoice_API.Interface;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApalisInvoice_API.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }
        public AMPS_Config_UsersViewModel userByUserName(string userName)
        {
            var user = userRepository.userByUserName(userName);
            if(user == null)
            {
                return null;
            }
            return mapper.Map<AMPS_Config_UsersViewModel>(user);
        }
    }
}
