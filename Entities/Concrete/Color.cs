using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    internal class Color : IEntity
    {
        public int ColorId { get; set; }
        public int ColorName { get; set; }
    }
}
