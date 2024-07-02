using Dapper;
using RealEstateWebApi.Dtos.CategoryDtos;
using RealEstateWebApi.Dtos.TestimonialDtos;
using RealEstateWebApi.Models.DapperContext;

namespace RealEstateWebApi.Repositories.TestimonialRepository
{
    public class TestimonialRepository : ITestimonialRepository
    {
        private readonly Context _context;

        public TestimonialRepository(Context context)
        {
            _context = context;
        }

        public void AddTestimonialAsync(AddTestimonialDto addTestimonialDto)
        {
            throw new NotImplementedException();
        }

        public void DeleteTestimonialAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ResultTestimonialDto>> GetAllTestimonialsAsync()
        {
            string query = "Select * From Testimonial";
            using var connection = _context.CreateConnection();
            var values = await connection.QueryAsync<ResultTestimonialDto>(query);
            return values.ToList();
        }

        public Task<ResultTestimonialDto> GetTestimonialByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateTestimonialAsync(UpdateTestimonialDto updateTestimonialDto)
        {
            throw new NotImplementedException();
        }
    }
}
