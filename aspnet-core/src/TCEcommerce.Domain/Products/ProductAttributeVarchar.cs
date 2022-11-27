﻿using System;
using Volo.Abp.Domain.Entities;

namespace TCEcommerce.Products
{
    public class ProductAttributeVarchar : Entity<Guid>
    {
        public Guid AttributeId { get; set; }
        public Guid ProductId { get; set; }
        public string Value { get; set; }
    }
}