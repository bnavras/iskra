using System;
using System.Collections.Generic;
using System.Reflection;

namespace Iskra.Infrastructure
{
	public class ValueType<TValueType> where TValueType: class
	{
	    private readonly PropertyInfo[] properties;
	    private readonly string className;
        public ValueType()
        {
            var type = typeof(TValueType);
            properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
            className = type.Name;
        }
        public bool Equals(TValueType name)
        {
            if (ReferenceEquals(null, name)) return false;
            if (ReferenceEquals(this, name)) return true;

            foreach (var property in properties)
            {
                var otherProperty = property.GetValue(name);
                var thisProperty = property.GetValue(this);
                if (thisProperty == null && otherProperty == null) continue;
                if (thisProperty == null) return false;
                if (!thisProperty.Equals(otherProperty)) return false;
            }
            return true;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as TValueType);
        }
        public override string ToString()
        {
            List<string> propertyBuilder = new List<string>();

            foreach (var property in properties)
                propertyBuilder.Add($"{property.Name}: {property.GetValue(this)}");

            propertyBuilder.Sort();
            return $"{className}({String.Join("; ", propertyBuilder)})";
        }
	    public override int GetHashCode()
	    {
	        int hashCode = 0;

            foreach (var property in properties)
                hashCode += property.GetValue(this).GetHashCode();

	        return hashCode;
	    }
	}
}