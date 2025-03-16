﻿using Products_Management_API.Enums;
using Products_Management_API.Models.DTO.Review;

namespace Products_Management_API.Services.Interfaces
{
    public interface IReviewService
    {
        Task<IEnumerable<ReviewDto>> GetAllAsync();
        Task<ReviewDto> GetByIdAsync(int id);
        Task AddAsync(CreateReviewDto createReviewDto);
        Task UpdateAsync(int id, UpdateReviewDto updateReviewDto);
        Task DeleteAsync(int id);
        Task<IEnumerable<ReviewDto>> GetReviewsAddedInLastDay(int days);
        Task<IEnumerable<ReviewDto>> GetFilteredReviewsAsync(int? minRating, int? maxRating, string orderBy, OrderDirection orderDirection);

    }
}
