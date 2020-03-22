using System;
using System.Collections.Generic;
using System.Text;

namespace DataContract
{
    public interface IDataContract
    {
        ///params: int a, int b
        ///returns: sum of a and b
        int Sum(int a, int b);

        ///params: a sale object
        ///returns: a boolean value, describing if the sale violates the 'subscription suspended' rule
        bool IsSubscriptionSuspended(object sale);
    }
}
