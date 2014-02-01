using System;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace Sharpforce
{
    public static class Extensions
    {
        /// <summary>
        /// Extends Type class with IsAnonymous method:
        /// http://www.liensberger.it/web/blog/?p=191
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>
        ///   <c>true</c> if the specified type is anonymous; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsAnonymous(this Type type)
        {
            return Attribute.IsDefined(type, typeof(CompilerGeneratedAttribute), false)
                   && type.IsGenericType && type.Name.Contains("AnonymousType")
                   && (type.Name.StartsWith("<>") || type.Name.StartsWith("VB$"))
                   && (type.Attributes & TypeAttributes.NotPublic) == TypeAttributes.NotPublic;
        }
    }
}