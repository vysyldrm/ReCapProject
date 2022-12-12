using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    internal class Brand : IEntity
    {
        public int BrandId { get; set; }
        public int BrandName { get; set; }
    }
}
