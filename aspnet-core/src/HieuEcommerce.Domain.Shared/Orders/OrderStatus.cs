using System;
using System.Collections.Generic;
using System.Text;

namespace HieuEcommerce.Orders
{
    public enum OrderStatus
    {
        New,
        Confirmed,
        Processing,
        Shipping,
        Finished,
        Canceled
    }
}
