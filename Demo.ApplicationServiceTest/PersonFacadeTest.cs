using Demo.ApplicationService;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Demo.ApplicationServiceTest
{
    public class PersonFacadeTest
    {
        [Fact]
        public void ShoudReturnFalseWhenInput15()
        {

            PersonFacade facade = new PersonFacade();
            bool result=facade.IsAdult(15);
            Assert.False(result);
            


        }

        [Fact]
        public void Shoud_throw_NullReferenceExceptoin_when_input_5()
        {
            PersonFacade facade = new PersonFacade();
            Assert.Throws<NullReferenceException>(() => facade.GetPersonCode(5));

        }


        [Fact]
        public void Shoud_return_startWith_pr_when_input_15()
        {
            PersonFacade facade = new PersonFacade();
            string result= facade.GetPersonCode(15);
            Assert.StartsWith("pr", result);
            

        }

        [Fact]
        public void ShoudReturnNullWhenInput5()
        {
            PersonFacade facade = new PersonFacade();
            var person= facade.Get(5);
            Assert.Null(person);
        }

        [Fact]
        public void ShoudThrowArgumentExceptionWhenInput0()
        {
            PersonFacade facade = new PersonFacade();
            Assert.Throws<ArgumentException>(() => facade.Get(0));
            
        }


        [Fact]
        public void ShoudReutnActivePersons()
        {
            PersonFacade personFacade = new PersonFacade();
            Assert.All(personFacade.GetActivePeople(),a=>Assert.True(a.isActive));
            personFacade.GetActivePeople();
        }


        [Fact]
        public void ShoudReutnDeactivePersons()
        {
            PersonFacade personFacade = new PersonFacade();
            Assert.All(personFacade.GetDeactivePeople(), a => Assert.False(a.isActive));
          
        }

        [Fact]
        public void ShoudMatchPatternPhoneNumberWhenInput5() 
        {
            PersonFacade facade = new PersonFacade();
            string result=facade.GetPhoneNumber(15);
            Assert.Matches(@"^09\d{9}$", result);

        }

    }
}
