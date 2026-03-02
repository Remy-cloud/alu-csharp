using System;
using System.Reflection;

/// <summary>
/// Provides reflection methods for objects.
/// </summary>
namespace _3_type_get
{
    /// <summary>
    /// Contains methods to inspect object types.
    /// </summary>
    public class Obj
    {
        /// <summary>
        /// Prints the properties and methods of an object.
        /// </summary>
        /// <param name="myObj">The object to inspect.</param>
        public static void Print(object myObj)
        {
            Type type = myObj.GetType();

            Console.WriteLine($"{type.Name} Properties:");
            foreach (PropertyInfo property in type.GetProperties())
            {
                Console.WriteLine(property.Name);
            }

            Console.WriteLine($"{type.Name} Methods:");
            foreach (MethodInfo method in type.GetMethods())
            {
                Console.WriteLine(method.Name);
            }
        }
    }
}