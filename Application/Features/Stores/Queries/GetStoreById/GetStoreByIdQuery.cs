using Application.Exceptions;
using Application.Interfaces.Repositories;
using Application.Wrappers;
using Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.stores.Queries.GetstoreById
{
    public class GetStoreByIdQuery : IRequest<Response<Store>>
    {
        public int Id { get; set; }
        public class GetStoreByIdQueryHandler : IRequestHandler<GetStoreByIdQuery, Response<Store>>
        {
            private readonly IStoreRepositoryAsync _storeRepository;
            public GetStoreByIdQueryHandler(IStoreRepositoryAsync storeRepository)
            {
                _storeRepository = storeRepository;
            }
            public async Task<Response<Store>> Handle(GetStoreByIdQuery query, CancellationToken cancellationToken)
            {
                var store = await _storeRepository.GetByIdAsync(query.Id);
                if (store == null) throw new ApiException($"store Not Found.");
                return new Response<Store>(store);
            }
        }
    }
}
