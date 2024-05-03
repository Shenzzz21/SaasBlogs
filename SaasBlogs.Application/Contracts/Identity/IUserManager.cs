using SaasBlogs.Application.DTOs.Response;
using SaasBlogs.Application.DTOs.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaasBlogs.Application.Contracts.Identity
{
    public interface IUserManager
    {
        Task<ResponseDto> RegisterUserAsync(UserRegisterRequestDTO userRegisterRequestDto);

        Task<IEnumerable<UserDetailsDto>> GetAllUsersAsync();

        Task<UserDetailsDto> UpdateUserAsync(string id, UserUpdateRequestDto userUpdateRequestDto);

        Task<ResponseDto> DeleteUserAsync(string id);

        Task<UserDetailsDto> GetUserByIdAsync(string id);

        Task<bool> ChangePasswordAsync(string userId, ChangePasswordDto changePasswordDto);
    }
}
