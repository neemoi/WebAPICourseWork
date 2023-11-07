﻿using Application.DtoModels.Models.Pagination;
using Application.DtoModels.Response.Admin;
using Application.DTOModels.Models.Admin.Pagination;
using Application.DTOModels.Response.Admin;

namespace Application.Services.Interfaces.IServices
{
    public interface IPaginationService
    {
        Task<IEnumerable<RoleResponseDto>> GetRoleWithPaginationAsync(RoleQueryParametersDto parametersModel);

        Task<IEnumerable<UserResponseDto>> GetUserWithPaginationAsync(UserQueryParametersDto parametersModel);

        Task<IEnumerable<ProductResponseDto>> GetProductWithPaginationAsync(ProductQueryParametersDto parametersModel);

        Task<IEnumerable<PaymentResponseDto>> GetPaymentsWithPaginationAsync(PaymentQueryParametersDto parametersModel);

        Task<IEnumerable<CategoryResponseDto>> GetCategoryWithPaginationAsync(CategoryQueryParametersDto parametersModel);

        Task<IEnumerable<DeliveryResponseDto>> GetDeliveryWithPaginationAsync(DeliveryQueryParametersDto parametersModel);
    }
}
