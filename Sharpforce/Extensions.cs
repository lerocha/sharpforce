using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Json;
using System.Text;
using Newtonsoft.Json;

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
            if (type == null) return false;
            return Attribute.IsDefined(type, typeof(CompilerGeneratedAttribute), false)
                   && type.IsGenericType && type.Name.Contains("AnonymousType")
                   && (type.Name.StartsWith("<>") || type.Name.StartsWith("VB$"))
                   && (type.Attributes & TypeAttributes.NotPublic) == TypeAttributes.NotPublic;
        }

        /// <summary>
        /// Serialize this object into JSON.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ToJson(this object obj)
        {
            if (obj == null) return null;

            string json = JsonConvert.SerializeObject(obj, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            Debug.WriteLine("Serialization; type={0}; json={1}", obj.GetType(), json);
            return json;

            //// Use JsonSerializer for anonymous types.
            //if (obj.GetType().IsAnonymous())
            //{
            //    string json = JsonConvert.SerializeObject(obj, Formatting.Indented, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
            //    Debug.WriteLine("Serialization; type={0}; json={1}", obj.GetType(), json);
            //    return json;
            //}

            //// Use DataContractJsonSerializer for other types.
            //using (var stream = new MemoryStream())
            //{
            //    var serializer = new DataContractJsonSerializer(obj.GetType());
            //    serializer.WriteObject(stream, obj);
            //    byte[] bytes = stream.ToArray();
            //    return Encoding.UTF8.GetString(bytes, 0, bytes.Length);
            //}
        }

        /// <summary>
        /// Deserialize the string into an object.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="value"></param>
        /// <returns></returns>
        public static T ToObject<T>(this string value) where T : new()
        {
            if (value == null) return default(T);

            var settings = new JsonSerializerSettings();
            return JsonConvert.DeserializeObject<T>(value, settings);

            //using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(value)))
            //{
            //    var serializer = new DataContractJsonSerializer(typeof(T));
            //    return (T) serializer.ReadObject(stream);
            //}
        }
    }
}