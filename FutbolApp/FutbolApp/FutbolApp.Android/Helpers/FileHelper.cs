﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace FutbolApp.Droid.Helpers
{
    public class FileHelper
    {
        public static string ObtenerRutaLocal(string archivo)
        {
            string ruta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return Path.Combine(ruta, archivo);
        }
    }
}