using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo.ApplicationService
{
   public class PersonFacade
    {
        PersonRepository personRepository ;
        public PersonFacade()
        {
            personRepository = new PersonRepository();

        }

        public List<Person> GetActivePeople()
        {
            return personRepository.GetPeople().Where(a => a.isActive == true).ToList();
        }

        public List<Person> GetDeactivePeople()
        {
            return personRepository.GetPeople().Where(a => a.isActive == false).ToList();
        }

        public string GetPhoneNumber(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException();
            }   
        return personRepository.GetPerson(id).PhoneNumber;


        }

        public Person Get(int id)
        {
            if (id<=0)
            {
                throw new ArgumentException();
            }
            return personRepository.GetPerson(id);
        }
        public bool IsAdult(int age)
        {
            return age > 18;
        }


        public string GetPersonCode(int id)
        {

            
            if (!personRepository.PersonExist(id))
            {
                throw new NullReferenceException();
            }


            return personRepository.GetPersonCode(id);
        }


    }

    public class PersonRepository
    {
        public List<Person> GetPeople()
        {
            return new List<Person>()
            {
                new Person()
                {
                    Id=11,
                    Age=20,
                    isActive=true
                },

                new Person()
                {
                    Id=12,
                    Age=21,
                    isActive=false
                },
                new Person()
                {
                    Id=13,
                    Age=25,
                    isActive=true
                },
                new Person()
                {
                    Id=14,
                    Age=30,
                    isActive=true
                },
            };

        }

        public Person GetPerson(int id)
        {
            return id > 10?new Person() { Id=id,PersonCode="pr"+Guid.NewGuid(),PhoneNumber="09121234567"} :null;
        }
        public string GetPersonCode(int id)
        {
            return "pr" + Guid.NewGuid();
        }

        public bool PersonExist(int id)
        {
            return id > 10;
        }

    }

    public class Person
    {
        public Person()
        {
            PersonCode = "pr" + Guid.NewGuid();
        }
        public int Id { get; set; }
        public string PersonCode { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public bool isActive { get; set; }
    }
}
