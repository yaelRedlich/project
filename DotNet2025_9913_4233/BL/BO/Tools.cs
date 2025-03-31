using System;
using System.Collections;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public static class Tools
    {
        public static string ToStringProperty <T>(T obj) {
            Type type = typeof(T);
            PropertyInfo[] properties = type.GetProperties();
            if(properties.Length == 0 )
                return $"Type {type.Name} has no properties.";
            string result = " ";
            foreach( PropertyInfo property in properties)
            {
                object value = property.GetValue(obj); 
                if(value is IEnumerable enumerable && value is not string)
                {
                    var items = string.Join(' ', enumerable.Cast<object>());
                    result += $"{property.Name}: [{items}]\n";
                }
                else
                {
                    result += $"{property.Name}: {value}\n";
                }

            }
            return result ;
        }
    }
}
