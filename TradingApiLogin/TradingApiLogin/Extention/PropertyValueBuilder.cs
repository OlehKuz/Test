using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using Newtonsoft.Json;

namespace TradingApiLogin.Extention
{
    public static class ClassExtention
    {
        public static string ConcatenatePropertyValue<TClass>(this TClass obj) where TClass : class, new()
        {
            StringBuilder query = new StringBuilder();
            var properties = typeof(TClass).GetProperties();

            foreach (var prop in properties)
            {
                var pair = prop.GetDescription();

                query.Append(prop.GetDescription() + "=" + GetPropertyValue(prop, obj) + "&");
            }
            return query.ToString(0, query.Length - 1);

        }

        private static string GetPropertyValue<TClass>(PropertyInfo property, TClass obj) where TClass : class, new()
        {
            Type type = property.PropertyType;
            var value = property.GetValue(obj);
            if (value == null)return string.Empty;
            return value.ToString();
        }
        public static (string, string) GetDescription(this PropertyInfo property) 
        {
            var jsonAttrName =  property.GetCustomAttributes(typeof(JsonPropertyAttribute), false)
                .Cast<JsonPropertyAttribute>()
                .FirstOrDefault()?.PropertyName
                ?? property.Name;

            var propertyName = property.Name;

            return (jsonAttrName, propertyName);
        }
        
    }
}
