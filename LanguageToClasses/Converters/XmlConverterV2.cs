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
        public Status ProcessComment(Status status)
        {
            //De comment solo podríamos sacar content;
            Regex matcher = new Regex($"^(?<isMatch>{Utils.Comment})?(?<rest>{Utils.Anything}*)", RegexOptions.IgnoreCase);
            var match = matcher.Match(status.Source);
            var newSource = match.Groups["rest"].Value;
            var node = match.Groups["isMatch"].Value;

            XMLCommentNode result = new XMLCommentNode(status.ActualNode, match.Value);

            if (!string.IsNullOrWhiteSpace(node))
            {
                matcher = new Regex($"{Utils.CommentContent}", RegexOptions.IgnoreCase);
                match = matcher.Match(node);
                result.Value = match.Value;
            }

            ////Si se quiere hacer EventDriven, dejo esto.
            //if (newSource.Length < source.Length)
            //{
            //    //Es un comentario
            //}

            status.ActualNode = result;
            return status;
        }

        /// <summary>
        /// Procesa un texto solo si su inicio indica ser una declaracion XML.
        /// </summary>
        /// <param name="source">texto del cual sacar el elemento procesado</param>
        /// <returns>source sin el elemento procesado</returns>
        public Status ProcessXMLDeclaration(Status status)
        {
            Regex matcher = new Regex($"^(?<isMatch>{Utils.XmlDeclaration})?(?<rest>.*)", RegexOptions.IgnoreCase);
            var match = matcher.Match(status.Source);
            var newSource = match.Groups["rest"].Value;
            var node = match.Groups["isMatch"].Value;
            if (string.IsNullOrWhiteSpace(node))
            {
                //matcher = new Regex($"{Utils.}");
            }
            ////Si se quiere hacer EventDriven, dejo esto.
            //if (newSource.Length < source.Length)
            //{
            //    //Es un comentario
            //}

            //status.ActualNode = result;
            return status;
        }

    }
}
