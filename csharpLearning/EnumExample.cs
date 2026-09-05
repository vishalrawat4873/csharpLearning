using System;

namespace csharpLearning
{
    enum OrderStatus
    {
        Pending,
        Processing,
        Shipped,
        Delivered,
        Cancelled
    }
    class EnumExample
    {
        static void Main()
        {
            OrderStatus status = OrderStatus.Shipped;

            Console.WriteLine(status);
            Console.WriteLine((int)status);    

            if (status == OrderStatus.Shipped)
            {
                Console.WriteLine("Order is on the way");
            }
        }
    }
}