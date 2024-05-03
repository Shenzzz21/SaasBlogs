using SaasBlogs.Application.DTOs.Response;
using SaasBlogs.Application.DTOs.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaasBlogs.Application.Contracts.Identity
{
    public interface ISignInManager
    {
        Task<ResponseWithJwtDto> LoginAsync(UserLoginRequestDto userLoginRequestDto);

        Task<ResponseDto> LogOutAsync();
    }
}
