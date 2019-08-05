using Serializers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using UtileriaFramework.Extensions;
using System.Globalization;
using UtileriaFramework.ObjectUtils;
using UtileriaFramework.Utils;
using System.Xml;
using Newtonsoft.Json;
using UtileriaFramework.Contracts.Json;
using LanguageToObjectLibrary.Parser;
using tuvi;

namespace UtileriaFramework
{

    internal class Program
    {
        private static void Main(string[] args)
        {
            //TestDeserialize();

            XmlParser parser = new XmlParser(new LanguageToObjectLibrary.Parser.Configuration.XmlConfiguration()
            {
                maxArrayDepth = 0,
                ArrayAsList = true,
                UseFullProperties = true,
                PropertiesAsClasses = true,
                UsedFloatingTypes = (LanguageToObjectLibrary.Parser.Models.FloatingTypeEnumerator)7,
                HideName = true,
                HideNamespace = true
            });

            parser.GetClasses(File.ReadAllText("file"));

            //Console.WriteLine(GetException(new Exception("easdaea", new Exception("qqq"))));
            string prueba = "asdasda<si";

            Regex regex = new Regex(@"^(([^<""'])*?)((?<quoted>([""][^""]*?[""])|(['][^']*?[']))(([^<""'])*?))*?<", RegexOptions.Multiline);

            var matches = regex.Matches(prueba);

            TestMail();
        }

        #region charGenerator

        #endregion


        private static void TestMail()
        {
            //Envia mails usando el smtp de google
            SmtpClient mailClient = new SmtpClient();
            mailClient.EnableSsl = true;
            mailClient.UseDefaultCredentials = false;
            mailClient.Port = 587;
            mailClient.Host = "smtp.gmail.com";
            mailClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            mailClient.Credentials = new NetworkCredential("samba25leo@gmail.com", "samba025");
            MailMessage message = new MailMessage();
            message.IsBodyHtml = true;
            message.From = new MailAddress("samba25leo@gmail.com");
            message.To.Add("leonardo.ramallo@juantoselli.com");
            message.Subject = "Boludeando con el cliente de mail";
            message.Body = "Hola bestia, como estas?<img src=\"C:\\Users\\Lautaro\\Pictures\\saldaa.jpg\">";
            mailClient.Send(message);
        }

        private static void TestDeserialize()
        {
            var file = File.ReadAllText("file");
            var serializator = new XmlSerializer();
            var deserialized = serializator.DeserializeObject<A>(file);
            var serialized = serializator.SerializeObject(deserialized);
            Console.WriteLine("Se deserializó");
        }

        private static void TestDeserializeJson()
        {
            var file = File.ReadAllText("fileJson");
            var deserialized = JsonConvert.DeserializeObject<Rootobject>(file);
            Console.WriteLine("Se deserializó");
        }

        private static string GenerateString(string seed, string capsuleIni = "{", string capsuleEnd = "}", string separator = ",")
        {
            return Regex.Replace(seed, @"(?<before>[^\\])([" + capsuleIni + @"])((?<min>\d+?)[" + separator + @"]?(?<max>\d+?)?)([" + capsuleEnd + @"])", match =>
             {
                 var min = 0;
                 var max = 0;

                 if (!Int32.TryParse(match.Groups["min"]?.Value, out min))
                     min = 0;
                 if (!Int32.TryParse(match.Groups["max"]?.Value, out max))
                     max = min;

                 Random r = new Random();

                 var characters = new char[r.Next(min, max)];

                 for (int i = 0; i < characters.Length; i++)
                 {
                     do
                     {
                         characters[i] = Convert.ToChar(r.Next(0, 256));
                     } while (!IsLetterOrDigitReworked(characters[i]));
                 }

                 var cadenaGenerada = new string(characters.Select(x => Convert.ToChar(x)).ToArray());

                 return $"{match.Groups["before"].Value}{cadenaGenerada}";

             }, RegexOptions.IgnoreCase);
        }

        private static bool IsLetterOrDigitReworked(char character)
        {
            var numeric = (int)character;
            if (numeric >= 48 && numeric <= 57) return true;//Numbers
            if (numeric >= 65 && numeric <= 90) return true;//Upper
            if (numeric >= 97 && numeric <= 122) return true;//Lower
            return false;
        }

        public static string GetException(Exception ex)
        {
            StringBuilder sb = new StringBuilder();


            return "";
        }

        public static void aux<Tasda>()
             where Tasda : IEnumerable<object>
        {

        }

        public static void ChangeDirectorySubFileNames(string directoryPath, string from, string to, string extension = ".cs")
        {
            foreach (var file in Directory.EnumerateFiles(directoryPath, $"*{extension}", SearchOption.AllDirectories))
            {
                FileInfo fi = new FileInfo(file);
                var newName = fi.Name.Substring(0, fi.Name.Length - fi.Extension.Length);
                newName = newName.Replace(from, to);
                var newFilename = fi.DirectoryName + Path.DirectorySeparatorChar + newName + fi.Extension;
                File.Move(file, newFilename);
            }
        }
    }

    public class AddTransferServiceRequest
    {
        public string BasketId { get; set; }
        public string WebSiteId { get; set; }
        public string AvailUrl { get; set; }
        public string[] SelectedServices { get; set; }
        public KeyValuePair<string, string> algo { get; set; }
    }

    public class Dataref
    {
        public string Key { get; set; }
        public string Value { get; set; }
        public Dataref(string key, string value)
        {
            Key = key;
            Value = value;
        }
    }
}

