using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace HashLib
{
    [DebuggerStepThrough]
    internal static class TypeExtensions
    {
        public static bool IsDerivedFrom(this Type a_type, Type a_baseType)
        {
            Debug.Assert(a_type != null);
            Debug.Assert(a_baseType != null);
            Debug.Assert(a_type.GetTypeInfo().IsClass);
            Debug.Assert(a_baseType.GetTypeInfo().IsClass);

            return a_baseType.GetTypeInfo().IsAssignableFrom(a_type);
        }

        public static bool IsImplementInterface(this Type a_type, Type a_interfaceType)
        {
            Debug.Assert(a_type != null);
            Debug.Assert(a_interfaceType != null);
            Debug.Assert(a_type.GetTypeInfo().IsClass || a_type.GetTypeInfo().IsInterface || a_type.GetTypeInfo().IsValueType);
            Debug.Assert(a_interfaceType.GetTypeInfo().IsInterface);

            return a_interfaceType.GetTypeInfo().IsAssignableFrom(a_type);
        }
    }
}