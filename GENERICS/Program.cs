using System;

namespace Generics
{

    public class Program
    {
        static void Main(string[] args)
        {
            var person = new Person();
            var payment = new Payment();
/* 
            var context = new Datacontext<Person>();
            context.Save(person); */

             var context = new Datacontext<Person,Payment,Subscription>();
            context.Save(person);
            context.Save(payment);
        }
        public class Datacontext<T, U, V>
        where T : Person
        where  U : Payment
        where V : Subscription
        {
             
            public void Save(T entity)
            {

            }
            public void Save(U entity)
            {

            }
            public void Save(V entity)
            {

            }
        }
        public class Person
        {

        }

        public class Payment
        {

        }
        public class Subscription
        {

        }
    }
}
