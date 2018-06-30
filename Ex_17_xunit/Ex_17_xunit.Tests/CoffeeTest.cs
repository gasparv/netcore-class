using System;
using Xunit;
using Moq;
using Ex_17_xunit.Models;
using Ex_17_xunit.Definitions;
using Ex_17_xunit.Services;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Ex_17_xunit.Exceptions;

namespace Ex_2_2_DependencyInjectionTests
{
    public class CoffeeTest
    {
        [Fact]
        public void EmployeeMakeCoffee_CoffeeMakerLaunch_CoffeeMakerWorks()
        {
            //arrange
            var mockCoffeeMaker = new Mock<ICoffeeMaker>();
            var mockEmployee = new Mock<Employee>(mockCoffeeMaker.Object);
            //var mockEmployee = new Mock<Employee>(It.IsAny<CapsuleCoffeemaker>());

            //act
            mockEmployee.Object.MakeCoffee();

            //assert
            mockCoffeeMaker.Verify(x => x.MakeCoffee(), Times.Once());
        }

        [Fact]
        public void CanMakePressoCoffee_CoffeeTypeNotAllowed()
        {
            //arrange
            var mockCoffeeMaker = new Mock<PressoMachine>();
            var mockEmployee = new Mock<Employee>(mockCoffeeMaker.Object);
            
            //act
            //assert
            Assert.Throws<CoffeeTypeNotAllowedException>(()=> mockEmployee.Object.MakeCoffee());
        }
    }
}
