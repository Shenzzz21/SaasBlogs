using Microsoft.AspNetCore.Http;
using SaasBlogs.Application.DTOs.Blog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaasBlogs.Application.Contracts.Repositories
{
    public interface IBlogRepository
    {
        Task<BlogDetailsDto> CreateBlogAsync(BlogCreateRequestDto blogCreateRequestDto, IFormFile image);

        Task<BlogDetailsDto> GetBlogByIdAsync(string id);

        Task<IEnumerable<BlogDetailsDto>> GetAllBlogsAsync();

        Task<BlogDetailsDto> UpdateBlogAsync(string id, BlogUpdateRequestDto blogUpdateRequestDto);

        Task<bool> DeleteBlogAsync(string id);

    }
}
