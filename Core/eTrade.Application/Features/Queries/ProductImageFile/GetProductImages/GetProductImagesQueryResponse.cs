﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTrade.Application.Features.Queries.ProductImageFile.GetProductImages
{
    public class GetProductImagesQueryResponse
    {
        public string Path { get; set; }
        public Guid Id { get; set; }
        public string FileName { get; set; }
    }
}
