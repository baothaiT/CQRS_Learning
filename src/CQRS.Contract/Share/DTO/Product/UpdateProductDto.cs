﻿namespace CQRS.Contract.Share.DTO
{
    public class UpdateProductDto: ProductBase
    {
        public Guid Id { get; set; }
    }
}
