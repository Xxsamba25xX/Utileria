using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using LanguageToClasses.Contracts;
using LanguageToClasses.Models;

namespace LanguageToClasses.Converters
{
    public class XmlConverterV2 : AbstractConverter
    {
        public XmlConverterV2(IConfiguration configuration) : base(configuration)
        {
        }

        public override List<AbstractNode> Convert(string source)
        {
            return null;
        }

        /// <summary>
        /// Procesa un texto solo si su inicio indica ser un comentario.
        /// </summary>
        /// <param name="source">texto del cual sacar el elemento procesado</param>
        /// <returns>source sin el elemento procesado</returns>
        public string ProcessComment(string source)
        {
            Regex commentTag = new Regex($"^(?<isMatch>{Utils.Comment})?(?<rest>.*)", RegexOptions.IgnoreCase);
            var match = commentTag.Match(source);
            var newSource = match.Groups["rest"].Value;

            ////Si se quiere hacer EventDriven, dejo esto.
            //if (newSource.Length < source.Length)
            //{
            //    //Es un comentario
            //}

            return newSource;
        }

        /// <summary>
        /// Procesa un texto solo si su inicio indica ser una declaracion XML.
        /// </summary>
        /// <param name="source">texto del cual sacar el elemento procesado</param>
        /// <returns>source sin el elemento procesado</returns>
        public string ProcessXMLDeclaration(string source)
        {
            Regex commentTag = new Regex($"^(?<isMatch>{Utils.XmlDeclaration})?(?<rest>.*)", RegexOptions.IgnoreCase);
            var match = commentTag.Match(source);
            var newSource = match.Groups["rest"].Value;

            ////Si se quiere hacer EventDriven, dejo esto.
            //if (newSource.Length < source.Length)
            //{
            //    //Es un comentario
            //}

            return newSource;
        }

    }
}
