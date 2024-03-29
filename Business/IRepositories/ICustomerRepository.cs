﻿using Domain.Entities;

namespace Business.IRepositories
{
    public interface ICustomerRepository
    {
        Task<List<Customer>> GetAsync(CancellationToken cancellationToken = default);

        Task<Customer> GetByIdAsync(Guid userId, CancellationToken cancellationToken = default);
        Task<Customer> GetByIdWithContractAsync(Guid userId, CancellationToken cancellationToken = default);

        void Insert(Customer customer);

        void Remove(Customer customer);
    }
}
