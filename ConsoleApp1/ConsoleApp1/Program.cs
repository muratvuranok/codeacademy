﻿using System.Reflection;
using System.Text;

namespace ConsoleApplication9
{

    public static class ReflectionExtensions
    {
        public static string GetAllProperties(this object obj)
        {
            return obj.GetType().GetProperties()
                .Select(info => (info.Name, Value: info.GetValue(obj, null) ?? "(null)"))
                .Aggregate(
                    new StringBuilder(),
                    (sb, pair) => sb.AppendLine($"{pair.Name}: {pair.Value}"),
                    sb => sb.ToString());
        }
    }

    class Program
    {

        class MyObject
        {
            public string Name { get; set; }
        }

        public static void CallWhereMethod()
        {
            List<MyObject> myObjects = new List<MyObject>() {
                new MyObject { Name = "Jon Simpson" },
                new MyObject { Name = "Jeff Atwood" }
            };


            Func<MyObject, bool> NameEquals = BuildEqFuncFor<MyObject>("Name", "Jon Simpson");


            // The Where method lives on the Enumerable type in System.Linq
            var whereMethods = typeof(System.Linq.Enumerable)
                .GetMethods(BindingFlags.Static | BindingFlags.Public)
                .Where(mi => mi.Name == "Where");

            Console.WriteLine(whereMethods.Count());
            // 2 (There are 2 methods that are called Where)

            MethodInfo whereMethod = null;
            foreach (var methodInfo in whereMethods)
            {
                var paramType = methodInfo.GetParameters()[1].ParameterType;
                if (paramType.GetGenericArguments().Count() == 2)
                {
                    // we are looking for  Func<TSource, bool>, the other has 3
                    whereMethod = methodInfo;
                }
            }

            // we need to specialize it 
            whereMethod = whereMethod.MakeGenericMethod(typeof(MyObject));

            var ret = whereMethod.Invoke(myObjects, new object[] { myObjects, NameEquals }) as IEnumerable<MyObject>;

            foreach (var item in ret)
            {
                Console.WriteLine(item.Name);
            }
            // outputs "Jon Simpson"

        }

        public static Func<T, bool> BuildEqFuncFor<T>(string prop, object val)
        {
            return t => t.GetType().InvokeMember(prop, BindingFlags.GetProperty,
                                                 null, t, null) == val;
        }

        static void Main(string[] args)
        {
            //CallWhereMethod();
            //Console.ReadKey();
            MyObject b = new MyObject();b.Name = "sdf0";
            Console.WriteLine(ReflectionExtensions.GetAllProperties(b));

            var fields = b.GetType().GetFields(BindingFlags.Instance |
                                                     BindingFlags.NonPublic |
                                                     BindingFlags.Public);


            foreach (var personFieldValue in fields)
            {
                Console.WriteLine(personFieldValue);
            }


        }
    }
}