using System;
using System.Reflection;

namespace _0_is
{
    /// <summary>
    /// Provides object reflection methods.
    /// </summary>
    public class Obj
    {
        /// <summary>
        /// Prints the names of the available properties and methods of an object.
        /// </summary>
        /// <param name="myObj">The object to inspect.</param>
        public static void Print(object myObj)
        {
            TypeInfo typeInfo = myObj.GetType().GetTypeInfo();

            Console.WriteLine("Properties:");
            foreach (PropertyInfo prop in typeInfo.GetProperties())
            {
                Console.WriteLine(prop.Name);
            }

            Console.WriteLine("Methods:");
            foreach (MethodInfo method in typeInfo.GetMethods())
            {
                Console.WriteLine(method.Name);
            }
        }
    }
}