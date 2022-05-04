using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExternalWebAPIPrj1;
using ExternalWebAPIPrj1.Controllers;
using ExternalWebAPIPrj1.Models;
using System.Web.Http;
using System.Web.Http.Results;

namespace ExternalTestingPrj
{
    [TestFixture]
    public class TestingController
    {
        [Test]
        public void ADDEmployessMethod()
        {
            // Arrange  
            var controller = new EmployeeController();
            Employee emp1 = new Employee
            {
                EmpType = "Permanent",  
            };
            // Act  
            IHttpActionResult actionResult = controller.AddEmp(emp1);
            // Assert  
            Assert.AreEqual("Eligible", emp1.EmpType);   

        }
    }
}
