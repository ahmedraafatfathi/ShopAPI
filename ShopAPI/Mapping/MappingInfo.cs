using AutoMapper;
using Entities;
using ShopAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopAPI.Mapping
{
    public class MappingInfo : Profile
    {
        public MappingInfo()
        {
            CreateMap<CategoryDto, Category>();
            CreateMap<CategoryDto, Category>().ReverseMap();

            CreateMap<OrderProductDto, OrderProduct>();
            CreateMap<OrderProductDto, OrderProduct>().ReverseMap();

            CreateMap<ProductDto, Product>();
            CreateMap<ProductDto, Product>().ReverseMap();

            CreateMap<ProductDiscountDto, ProductDiscount>();
            CreateMap<ProductDiscountDto, ProductDiscount>().ReverseMap();


            CreateMap<UserDto, User>();
            CreateMap<UserDto, User>().ReverseMap();

            CreateMap<UserOrderDto, UserOrder>();
            CreateMap<UserOrderDto, UserOrder>().ReverseMap();


            CreateMap<PaggingInfo, PaggingFilter>();
            CreateMap<PaggingInfo, PaggingFilter>().ReverseMap();
        }
    }
}
