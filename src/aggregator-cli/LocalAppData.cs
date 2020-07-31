﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace aggregator.cli
{
    public static class LocalAppData
    {
        public static string GetDirectory()
        {
            string dir = Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData,
                    Environment.SpecialFolderOption.Create),
                        "aggregator-cli");
            Directory.CreateDirectory(dir);
            return dir;
        }

        public static string GetPath(string filename)
        {
            return Path.Combine(GetDirectory(), filename);
        }
    }
}
