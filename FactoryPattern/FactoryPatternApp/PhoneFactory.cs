using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPatternApp
{
    /// <summary>
    /// Creates different types of phone objects
    /// </summary>
    static class PhoneFactory
    {
        /// <summary>
        /// Takes the users input and returns a phone type that conforms to the ICallable interface
        /// </summary>
        /// <param name="phoneType"></param>
        /// <returns>
        /// ICallable
        /// </returns>
        public static ICallable GetPhone(string phoneType)
        {
            switch (phoneType.ToLower())
            {
                case "android":
                    return new AndroidPhone();                    
                case "apple":                    
                case "iphone":
                    return new ApplePhone();
                case "google":
                    return new GooglePhone();
                default:
                    return new AndroidPhone();                    
            }
        }
    }
}
