using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        Random random = new Random();
        List<Customer> customerList = new List<Customer>();
        int amountOfCustomers;
        int want;
        int determineCustomers;

        public Customer()
        {
            this.determineCustomers = 0;
            this.want = 0;
            
        }

        public List<Customer> GetCustomersToBuy(Weather weather)
        {
            SetWantForLemonade(weather);
            DetermineCustomers(weather);
            CreateCustomers(weather);
            return customerList;
        }

        public int SetWantForLemonade(Weather weather)
        {
            int wantRandom = random.Next(1,90);
            switch (weather.GetWeatherCondition())
            {
                case "rainy":
                    return wantRandom -= 55;
                case "cloudy":
                    return wantRandom -= 30;
                case "sunny":
                    return wantRandom += 35;
                default:
                    return wantRandom;
            }
        }

        public int DetermineCustomers(Weather weather)
        {
            switch (weather.GetWeatherCondition())
            {
                case "rainy":
                    return amountOfCustomers = random.Next(1,30);
                case "cloudy":
                    return amountOfCustomers = random.Next(25,50);
                case "sunny":
                    return amountOfCustomers = random.Next(50,100);
                default:
                    return amountOfCustomers;
            }
        }
        public List<Customer> CreateCustomers(Weather weather)
        {
            for (int i = 0; i < amountOfCustomers; i++)
            {
                Customer customer = new Customer();
                customer.determineCustomers = DetermineCustomers(weather);
                customer.want = SetWantForLemonade(weather);
                if (customer.want >= 25)
                {
                    customerList.Add(customer);
                }
            }
            return customerList;
        }

    }
        
}
