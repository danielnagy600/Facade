using Facade.Services;

namespace Facade
{
    public class DiscountFacade
    {
        private readonly OrderService _orderService = new OrderService();
        private readonly CustomerDiscountBaseService customerDiscountBaseService = new CustomerDiscountBaseService();
        private readonly DayOfTheWeekFactorService dayOfTheWeekFactorService = new DayOfTheWeekFactorService(); 

        public double CalculateDiscountPercentage(int customerId)
        {
            if (!_orderService.HasEnoughOrders(customerId)) 
            {
                return 0;
            }
            return customerDiscountBaseService.CalculateDiscountBase(customerId)
                * dayOfTheWeekFactorService.CalculateDayOfTheWeekFactor();
        }

    }
}
