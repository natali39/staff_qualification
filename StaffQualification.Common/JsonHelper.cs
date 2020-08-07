using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace staff_qualification_Forms
{
    public class JsonHelper
    {
        public static TValue Deserialize<TValue>(string value)
        {
            return JsonConvert.DeserializeObject<TValue>(value);
        }

        public static string Serialize<TValue>(TValue value)
        {
            return JsonConvert.SerializeObject(value, Formatting.Indented);
        }
    }
}
