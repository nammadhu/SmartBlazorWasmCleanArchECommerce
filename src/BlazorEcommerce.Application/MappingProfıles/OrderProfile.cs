﻿using BlazorEcommerce.Shared.Order;

namespace BlazorEcommerce.Application.MappingProfıles;

public class OrderProfile : Profile
{
    public OrderProfile()
    {
        CreateMap<Order, OrderDto>();
        CreateMap<OrderItem, OrderItemDto>();
    }
}
