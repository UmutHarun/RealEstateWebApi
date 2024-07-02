using RealEstateWebApi.Dtos.TestimonialDtos;

namespace RealEstateWebApi.Repositories.TestimonialRepository
{
    public interface ITestimonialRepository
    {
        Task<List<ResultTestimonialDto>> GetAllTestimonialsAsync();
        void AddTestimonialAsync(AddTestimonialDto addTestimonialDto);
        void DeleteTestimonialAsync(int id);
        void UpdateTestimonialAsync(UpdateTestimonialDto updateTestimonialDto);
        Task<ResultTestimonialDto> GetTestimonialByIdAsync(int id);
    }
}
