using Twitter.Business.Dtos.TopicDtos;
using Twitter.CORE.Entities;

namespace Twitter.API.Services.Interfaces
{
    public interface ITopicService
    {
        public IQueryable<TopicListItemDto> GetAll();
        public Task<TopicDetailDto> GetByIdAsync(int id);
        public Task CreateAsync(TopicCreateDto dto);
    }
}
