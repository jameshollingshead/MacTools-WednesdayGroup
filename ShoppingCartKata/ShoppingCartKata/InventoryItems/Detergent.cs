﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartKata.InventoryItems
{
    public class Detergent : IInventory
    {
        
        public string GetName()
        {
            throw new NotImplementedException();
        }

        public double GetPrice()
        {
            throw new NotImplementedException();
        }

        public int GetNumberForDiscount()
        {
            throw new NotImplementedException();
        }

        public double GetDiscountPrice()
        {
            throw new NotImplementedException();
        }
    }
}
