using System;

namespace FactoryPatternApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Ask the user for the phone they wish to create
            Console.WriteLine("What kind of phone do you want to create?");
            string userPhone = Console.ReadLine();

            //Choose the correct type of phone to create through the factory method that implements the ICallable interface
            var phone = PhoneFactory.GetPhone(userPhone);
            phone.Build();
            Console.ReadLine();



            //***********Example of bad practice************//

            //Console.WriteLine("What kind of phone do you want to create?");
            //string userPhone = Console.ReadLine();

            //if (userPhone.ToLower() == "android")
            //{
            //    AndroidPhone android = new AndroidPhone();
            //    android.Build();
            //    Console.ReadLine();
            //}
            //else if (userPhone.ToLower() == "apple")
            //{
            //    ApplePhone apple = new ApplePhone();
            //    apple.Build();
            //    Console.ReadLine();
            //}
            //else if (userPhone.ToLower() == "iphone")
            //{
            //    ApplePhone apple = new ApplePhone();
            //    apple.Build();
            //    Console.ReadLine();
            //}
            //else if (userPhone.ToLower() == "google")
            //{
            //    GooglePhone google = new GooglePhone();
            //    google.Build();
            //    Console.ReadLine();
            //}
            //else
            //{
            //    AndroidPhone android = new AndroidPhone();
            //    android.Build();
            //    Console.ReadLine();
            //}
        }
    }
}
