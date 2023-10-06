using GameProjectSimulation.Concrete;
using GameProjectSimulation.Entities;
using System;

class Program
{
    static void Main()
    {
        Customer customer1 = new Customer();
        customer1.Id = 123;
        customer1.FirstName = "Yusuf Ali";
        customer1.LastName = "Öztürk";
        customer1.DateOfBirth = new DateTime(1995, 1, 1); // Corrected to a valid DateTime
        customer1.Identity = "1234567890";

        Campaign campaign1 = new Campaign()
        {
            CampaingnName = "%45 İndirim!", // Corrected the property name
            DiscountRate = 50
        };

        Sale sale1 = new Sale()
        {
            OrderNo = 1,
            GameName = "Counter Strike Global Offensive",
            Price = 110
        };

        CustomerManager customerManager1 = new CustomerManager(new UserValidationManager());
        customerManager1.Add(customer1);

        CampaignManager campaignManager1 = new CampaignManager();
        campaignManager1.Update(campaign1);

        SaleManager saleManager1 = new SaleManager();
        saleManager1.Sale(customer1, campaign1, sale1);
    }
}
