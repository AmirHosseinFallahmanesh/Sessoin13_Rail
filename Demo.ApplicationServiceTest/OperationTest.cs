using Demo.ApplicationService;
using System;
using Xunit;

namespace Demo.ApplicationServiceTest
{
    public class OperationTest
    {
        [Fact]
        public void Should_return_5_when_Input2and3()
        {
            Operation operation = new Operation(); //arrange
            int sum=operation.Sum(2, 3);//act
            Assert.Equal(5, sum);//assert


        }


        [Fact]
        public void Should_throwException_when_input0()
        {
            Operation operation = new Operation();

            Assert.Throws<DivideByZeroException>(()=>operation.Divide(4, 0));

            

        }

        [Fact]
        public void Should_return_2_when_input10and5()
        {
            Operation operation = new Operation();
            double result = operation.Divide(10, 5);
            Assert.Equal(2, result);

        }

       



    }
}
