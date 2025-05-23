﻿using maERP.Domain.Interfaces;

namespace maERP.Domain.Dtos.ProductSalesChannel;

public class ProductSalesChannelCreateDto : IProductSalesChannelInputModel
{
    public int ProductId { get; set; }
    public int SalesChannelId { get; set; }
    
    public int RemoteProductId { get; set; }

    public decimal Price { get; set; }

    public bool ProductImport { get; set; }

    public bool ProductExport { get; set; }
}