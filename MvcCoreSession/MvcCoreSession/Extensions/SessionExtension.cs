﻿using Microsoft.AspNetCore.Http;
using MvcCoreSession.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreSession.Extensions
{
    public static class SessionExtension
    {
        public static void SetObject(this ISession session,string key,object value)
        {
            string data = HelperSession.SerializeObject(value);
            session.SetString(key, data);
        }

        public static T GetObject<T>(this ISession session, string key)
        {
            string data = session.GetString(key);
            if (data == null)
            {
                return default(T);
            }
            else
            {
                return HelperSession.DeserializeObject<T>(data);
            }
        }
        
    }
}
