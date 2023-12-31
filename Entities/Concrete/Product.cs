﻿using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product : IEntity         //public = bu classa diğer katmanlarda(DataAccess,Business vs.)ulaşabilsin demek..
                                           //internal = sadece var olduğu katman (Entities) erişebilir demek..
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public short UnıtsInStock { get; set; }
        public decimal UnitPrice { get; set; }
        string IEntity.CategoryName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
