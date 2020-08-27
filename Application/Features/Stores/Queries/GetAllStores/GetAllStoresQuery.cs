using Application.Filters;
using Application.Interfaces.Repositories;
using Application.Wrappers;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Features.Stores.Queries.GetAllStores
{
    // public class GetAllStoresQuery : IRequest<PagedResponse<IEnumerable<GetAllStoresViewModel>>>
    // {
    //     public int PageNumber { get; set; }
    //     public int PageSize { get; set; }
    // }
    // public class GetAllStoresQueryHandler : IRequestHandler<GetAllStoresQuery, PagedResponse<IEnumerable<GetAllStoresViewModel>>>
    // {
    //     private readonly IStoreRepositoryAsync _productRepository;
    //     private readonly IMapper _mapper;
    //     public GetAllStoresQueryHandler(IStoreRepositoryAsync productRepository, IMapper mapper)
    //     {
    //         _productRepository = productRepository;
    //         _mapper = mapper;
    //     }

    //     // public async Task<PagedResponse<IEnumerable<GetAllStoresViewModel>>> Handle(GetAllStoresQuery request, CancellationToken cancellationToken)
    //     // {
    //     //     var validFilter = _mapper.Map<GetAllStoresParameter>(request);
    //     //     var product = await _productRepository.GetPagedReponseAsync(validFilter.PageNumber,validFilter.PageSize);
    //     //     var productViewModel = _mapper.Map<IEnumerable<GetAllStoresViewModel>>(product);
    //     //     return new PagedResponse<IEnumerable<GetAllStoresViewModel>>(productViewModel, validFilter.PageNumber, validFilter.PageSize);           
    //     // }
    // }
}
