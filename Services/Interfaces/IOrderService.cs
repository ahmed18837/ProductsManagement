﻿using Products_Management_API.Models.DTO.Order;

namespace Products_Management_API.Services.Interfaces
{
    public interface IOrderService
    {
        //Task<IEnumerable<OrderDto>> GetAllAsync();
        // Task<OrderDto> GetByIdAsync(int id);
        Task AddAsync(OrderCreateDto entity);
        Task DeleteAsync(int id);
        Task UpdateAsync(int id, OrderUpdateDto orderUpdateDto);

        Task<IEnumerable<OrderDto>> GetOrdersAddedInLastDay(int days);

        Task<IEnumerable<OrderDto>> GetAllOrdersAsync();
        Task<OrderDto> GetOrderByIdAsync(int id);
        Task<IEnumerable<OrderDto>> GetFilteredOrdersAsync(OrderFilterDto filter);
    }
}
