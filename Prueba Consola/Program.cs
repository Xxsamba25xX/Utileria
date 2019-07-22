using LanguageToClasses.Configuration;
using LanguageToClasses.Models;
using LanguageToClasses.Parser;
using Newtonsoft.Json;
using PCRE;
using System;
using System.Collections.Generic;
using System.IO;

namespace Prueba_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            //PcreRegex document = new PcreRegex(LanguageToClasses.Models.Utils.Element, PcreOptions.IgnoreCase);

            var file = File.ReadAllText("file");

            XmlParser parser = new XmlParser(JsonConvert.DeserializeObject<XmlConfiguration>(File.ReadAllText("xmlConfiguration")));
            parser.GetClasses(file);

        }

        static XmlConfiguration GenerateConfiguration()
        {
            return new XmlConfiguration()
            {
                IgnoredAttributeTags = new List<string>(),
                UsedFloatingTypes = (FloatingTypeEnumerator)7,
                UsedIntegralTypes = (IntegralTypeEnumerator)255,
                UsedSpecialTypes = (SpecialTypeEnumerator)7,
                UseFullProperties = false,
                
            };
        }
    }
}
