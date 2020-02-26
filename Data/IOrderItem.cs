using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public interface IOrderItem
    {
        public double Price { get; }

        public List<string> SpecialInstructions { get;  }



    }
}
