﻿using Newtonsoft.Json.Linq;

namespace CoolCat.Core.Configurations
{
    public class DependanceConfiguration
    {
        public RuntimeTarget RuntimeTarget { get; set; }

        public CompilationOptions CompilationOptions { get; set; }

        public JObject Targets { get; set; }

        public JObject Libraries { get; set; }
    }

    public class RuntimeTarget
    {
        public string Name { get; set; }

        public string Signature { get; set; }
    }

    public class CompilationOptions
    {

    }

    public class LibraryConfiguration
    {
        public string Type { get; set; }

        public string Serviceable { get; set; }

        public string Sha512 { get; set; }

        public string Path { get; set; }

        public string HashPath { get; set; }
    }
}
