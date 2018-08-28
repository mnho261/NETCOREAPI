using System;
using Xunit;
using CustomerAPI.Controllers;
using System.Collections.Generic;
using Moq;
using CustomerAPI.Models;
using System.Linq;


namespace CustomerAPIUnitTests
{
    public class CustomerControllerUnitTest
    {
        #region Prepare Test Data
        private IEnumerable<Customer> GetAllCustomersNoData()
        {
            List<Customer> lCustomer = new List<Customer>();

            return lCustomer.AsEnumerable();
        }

        private IEnumerable<Customer> GetAllCustomers()
        {
            List<Customer> lCustomer = new List<Customer>();
            lCustomer.Add(new Customer { FirstName = "Bob", LastName = "Sally", PhoneNumber = "1789999" });
            lCustomer.Add(new Customer { FirstName = "John", LastName = "Sally", PhoneNumber = "7789990" });
            lCustomer.Add(new Customer { FirstName = "Scott", LastName = "Sally", PhoneNumber = "7789992" });
            lCustomer.Add(new Customer { FirstName = "Joshua", LastName = "Sally", PhoneNumber = "7789993" });
            lCustomer.Add(new Customer { FirstName = "Chris", LastName = "Sally", PhoneNumber = "7789994" });
            lCustomer.Add(new Customer { FirstName = "Jill", LastName = "Sally", PhoneNumber = "7789995" });

            lCustomer.Add(new Customer { FirstName = "Bob", LastName = "Sally", PhoneNumber = "1789999" });
            lCustomer.Add(new Customer { FirstName = "John", LastName = "Sally", PhoneNumber = "7789990" });
            lCustomer.Add(new Customer { FirstName = "Scott", LastName = "Sally", PhoneNumber = "7789992" });
            lCustomer.Add(new Customer { FirstName = "Joshua", LastName = "Sally", PhoneNumber = "7789993" });
            lCustomer.Add(new Customer { FirstName = "Chris", LastName = "Sally", PhoneNumber = "7789994" });
            lCustomer.Add(new Customer { FirstName = "Jill", LastName = "Sally", PhoneNumber = "7789995" });

            lCustomer.Add(new Customer { FirstName = "Bob", LastName = "Goldern", PhoneNumber = "1789999" });
            lCustomer.Add(new Customer { FirstName = "John", LastName = "Goldern", PhoneNumber = "7789990" });
            lCustomer.Add(new Customer { FirstName = "Scott", LastName = "Goldern", PhoneNumber = "7789992" });
            lCustomer.Add(new Customer { FirstName = "Joshua", LastName = "Goldern", PhoneNumber = "7789993" });
            lCustomer.Add(new Customer { FirstName = "Chris", LastName = "Goldern", PhoneNumber = "7789994" });
            lCustomer.Add(new Customer { FirstName = "Jill", LastName = "Goldern", PhoneNumber = "7789995" });

            lCustomer.Add(new Customer { FirstName = "Bob", LastName = "Stein", PhoneNumber = "1789999" });
            lCustomer.Add(new Customer { FirstName = "John", LastName = "Stein", PhoneNumber = "7789990" });
            lCustomer.Add(new Customer { FirstName = "Scott", LastName = "Stein", PhoneNumber = "7789992" });
            lCustomer.Add(new Customer { FirstName = "Joshua", LastName = "Stein", PhoneNumber = "7789993" });
            lCustomer.Add(new Customer { FirstName = "Chris", LastName = "Stein", PhoneNumber = "7789994" });
            lCustomer.Add(new Customer { FirstName = "Jill", LastName = "Stein", PhoneNumber = "7789995" });

            lCustomer.Add(new Customer { FirstName = "Bob", LastName = "Deal", PhoneNumber = "1789999" });
            lCustomer.Add(new Customer { FirstName = "John", LastName = "Deal", PhoneNumber = "7789990" });
            lCustomer.Add(new Customer { FirstName = "Scott", LastName = "Deal", PhoneNumber = "7789992" });
            lCustomer.Add(new Customer { FirstName = "Joshua", LastName = "Deal", PhoneNumber = "7789993" });
            lCustomer.Add(new Customer { FirstName = "Chris", LastName = "Deal", PhoneNumber = "7789994" });
            lCustomer.Add(new Customer { FirstName = "Jill", LastName = "Deal", PhoneNumber = "7789995" });

            lCustomer.Add(new Customer { FirstName = "Bob", LastName = "Forest", PhoneNumber = "1789999" });
            lCustomer.Add(new Customer { FirstName = "John", LastName = "Forest", PhoneNumber = "7789990" });
            lCustomer.Add(new Customer { FirstName = "Scott", LastName = "Forest", PhoneNumber = "7789992" });
            lCustomer.Add(new Customer { FirstName = "Joshua", LastName = "Forest", PhoneNumber = "7789993" });
            lCustomer.Add(new Customer { FirstName = "Chris", LastName = "Forest", PhoneNumber = "7789994" });
            lCustomer.Add(new Customer { FirstName = "Jill", LastName = "Forest", PhoneNumber = "7789995" });

            lCustomer.Add(new Customer { FirstName = "Bob", LastName = "Gump", PhoneNumber = "1789999" });
            lCustomer.Add(new Customer { FirstName = "John", LastName = "Gump", PhoneNumber = "7789990" });
            lCustomer.Add(new Customer { FirstName = "Scott", LastName = "Gump", PhoneNumber = "7789992" });
            lCustomer.Add(new Customer { FirstName = "Joshua", LastName = "Gump", PhoneNumber = "7789993" });
            lCustomer.Add(new Customer { FirstName = "Chris", LastName = "Gump", PhoneNumber = "7789994" });
            lCustomer.Add(new Customer { FirstName = "Jill", LastName = "Gump", PhoneNumber = "7789995" });

            return lCustomer.AsEnumerable();
        }
        #endregion

        [Fact]
        public void GetAllCustomer_NoData_Fail()
        {

            //Arrange
            var mockRepo = new Mock<ICustomerRepository>();
            mockRepo.Setup(repo => repo.GetAllCustomers()).Returns(GetAllCustomersNoData());
            var controller = new CustomerController(mockRepo.Object);
            
            //setup
            var result = controller.GetAllCustomers();

            //assert
            Xunit.Assert.IsType<List<Customer>>(result.ToList());
            Xunit.Assert.Empty(result);
        }

        [Fact]
        public void GetAllCustomer_HasData_Pass()
        {

            //Arrange
            var mockRepo = new Mock<ICustomerRepository>();
            mockRepo.Setup(repo => repo.GetAllCustomers()).Returns(GetAllCustomers());
            var controller = new CustomerController(mockRepo.Object);

            //setup
            var result = controller.GetAllCustomers();

            //assert
            Xunit.Assert.IsType<List<Customer>>(result.ToList());
            Xunit.Assert.NotEmpty(result);
        }
    }
}
