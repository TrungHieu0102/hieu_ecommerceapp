using System;
using System.Collections.Generic;
using System.Text;

namespace HieuEcommerce.Orders
{
    public enum TransactionType
    {
        ConfirmOrder,
        StartProcessing,
        FinishOrder,
        CancelOrder
    }
}
