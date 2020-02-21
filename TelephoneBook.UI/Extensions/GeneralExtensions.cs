using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelephoneBook.UI.Extensions
{
    public static class GeneralExtensions
    {
        // Parameters:
        //   value:
        //     The object to serialize.
        public static string SerializeJSON(object value)
        {
            var list = JsonConvert.SerializeObject(value,
                Formatting.None,
                new JsonSerializerSettings()
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });

            return list;
        }

    }
}