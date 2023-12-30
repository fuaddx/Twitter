using Twitter.API.Services.Interfaces;
using Twitter.Business.Dtos.TopicDtos;
using Twitter.Business.Repositories.Interfaces;
using Twitter.CORE.Entities;

namespace Twitter.API.Services.Implements
{
    public class TopicService : ITopicService
    {
        ITopicRepository _repo { get; }
        public TopicService(ITopicRepository repo)
        {
            _repo = repo;
        }

        public Task CreateAsync(TopicCreateDto dto)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TopicListItemDto> GetAll()
        =>  _repo.GetAll().Select(t=> new TopicListItemDto
        {
            Id= t.Id,
            Name= t.Name,
        });
        

        public Task<TopicDetailDto> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
