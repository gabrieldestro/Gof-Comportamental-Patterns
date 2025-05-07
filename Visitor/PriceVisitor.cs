using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class PriceVisitor : IVisitor
    {
        private const int CAR_DISCOUNT = 12;

        public void Accept(Car car)
        {
            decimal priceCarAfterDiscount = car.Price - ((car.Price / 100) * CAR_DISCOUNT);

            Console.WriteLine($"{car.Model} {car.Name} : {priceCarAfterDiscount}.");
        }
    }
}
