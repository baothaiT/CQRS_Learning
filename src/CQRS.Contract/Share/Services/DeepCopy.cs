using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace CQRS.Contract.Share.Services
{
    public static class Deep
    {
        // Deep copy using reflection
        public static T DeepCopy<T>(this T obj)
        {
            if (obj == null)
                return default(T);

            var type = obj.GetType();

            // For value types or strings, simply return the object itself
            if (type.IsValueType || type == typeof(string))
                return obj;

            // Create an instance of the same type
            var copy = Activator.CreateInstance(type);

            // Copy all fields and properties
            foreach (var field in type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
            {
                var fieldValue = field.GetValue(obj);
                field.SetValue(copy, fieldValue.DeepCopy());  // Recursively copy field values
            }

            //foreach (var prop in type.GetProperties(BindingFlags.Public | BindingFlags.Instance))
            //{
            //    if (prop.CanRead && prop.CanWrite)
            //    {
            //        var propValue = prop.GetValue(obj);
            //        prop.SetValue(copy, propValue.DeepCopy());  // Recursively copy property values
            //    }
            //}

            return (T)copy;
        }
    }
}
