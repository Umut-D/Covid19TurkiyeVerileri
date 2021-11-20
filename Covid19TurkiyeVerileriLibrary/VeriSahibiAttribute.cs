using System;

namespace Covid19TurkiyeVerileriLibrary
{
    [AttributeUsage(AttributeTargets.Class)]
    public class VeriSahibiAttribute : Attribute
    {
        public string Repo { get; set; }
        public string Link { get; set; }
    }
}