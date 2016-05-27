﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneTrueError.App.Tests
{
    static class ObjectExtensions
    {
        public static void SetId(this object instance, object id)
        {
            instance.GetType().GetProperty("Id").SetValue(instance, id);
        }
    }
}
