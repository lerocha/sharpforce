using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Json;
using System.Text;
using RestSharp.Serializers;

namespace Sharpforce
{
    internal class SalesforceSerializer : ISerializer
    {
        public string RootElement { get; set; }
        public string Namespace { get; set; }
        public string DateFormat { get; set; }
        public string ContentType { get; set; }

        public SalesforceSerializer()
        {
            ContentType = "application/json";
        }

        public string Serialize(object obj)
        {
            if (obj==null) throw new ArgumentNullException();

            // Use JsonSerializer for anonymous types.
            if (IsAnonymousType(obj.GetType()))
            {
                var serializer = new JsonSerializer();
                return serializer.Serialize(obj);
            }

            // Use DataContractJsonSerializer for other types.
            using (var stream = new MemoryStream())
            {
                var serializer = new DataContractJsonSerializer(obj.GetType());
                serializer.WriteObject(stream, obj);
                byte[] bytes = stream.ToArray();
                return Encoding.UTF8.GetString(bytes, 0, bytes.Length);
            }
        }

        /// <summary>
        /// http://www.liensberger.it/web/blog/?p=191
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        private static bool IsAnonymousType(Type type)
        {
            return Attribute.IsDefined(type, typeof(CompilerGeneratedAttribute), false)
                   && type.IsGenericType && type.Name.Contains("AnonymousType")
                   && (type.Name.StartsWith("<>") || type.Name.StartsWith("VB$"))
                   && (type.Attributes & TypeAttributes.NotPublic) == TypeAttributes.NotPublic;
        }
    }
}