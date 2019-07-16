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
            Regex matcher = new Regex($"^(?<isMatch>{Utils.GroupedComment})?(?<rest>{Utils.Anything}*)", RegexOptions.IgnoreCase);
            var match = matcher.Match(status.Source);
            var newSource = match.Groups["rest"].Value;
            var node = match.Groups["isMatch"].Value;

            if (!string.IsNullOrWhiteSpace(node))
            {
                XMLCommentNode result = new XMLCommentNode(status.ActualNode, match.Value);

                result.Value = match.Groups[nameof(Utils.CommentContent)].Value;

                status.ActualNode = result;
            }

            return status;
        }

        /// <summary>
        /// Procesa un texto solo si su inicio indica ser una declaracion XML.
        /// </summary>
        /// <param name="source">texto del cual sacar el elemento procesado</param>
        /// <returns>source sin el elemento procesado</returns>
        public Status ProcessXMLDeclaration(Status status)
        {
            Regex matcher = new Regex($"^(?<isMatch>{Utils.GroupedXmlDeclaration})?(?<rest>.*)", RegexOptions.IgnoreCase);
            var match = matcher.Match(status.Source);
            var newSource = match.Groups["rest"].Value;
            var node = match.Groups["isMatch"].Value;

            if (string.IsNullOrWhiteSpace(node))
            {
                XMLDeclarationNode result = new XMLDeclarationNode(status.ActualNode);
                string fullVersion = match.Groups[nameof(Utils.VersionInfo)].Value;
                string fullEncoding = match.Groups[nameof(Utils.EncodingDeclaration)].Value;
                string fullStandalone = match.Groups[nameof(Utils.StandaloneDocumentDeclaration)].Value;

                if (!string.IsNullOrWhiteSpace(fullVersion))
                {
                    matcher = new Regex($"{Utils.GroupedVersionInfo}", RegexOptions.IgnoreCase);
                    result.Version = matcher.Match(fullVersion).Groups[nameof(Utils.versionNum)].Value;
                    if (result.Version.Length >= 3)
                        result.Version = result.Version.Substring(1, result.Version.Length - 2);
                }
                if (!string.IsNullOrWhiteSpace(fullEncoding))
                {
                    matcher = new Regex($"{Utils.GroupedEncodingDeclaration}", RegexOptions.IgnoreCase);
                    result.EncodingName = matcher.Match(fullVersion).Groups[nameof(Utils.EncodingName)].Value;
                    if (result.EncodingName.Length >= 3)
                        result.EncodingName = result.EncodingName.Substring(1, result.EncodingName.Length - 2);
                }
                if (!string.IsNullOrWhiteSpace(fullStandalone))
                {
                    matcher = new Regex($"{Utils.GroupedVersionInfo}", RegexOptions.IgnoreCase);
                    var standalone = matcher.Match(fullVersion).Groups[nameof(Utils.YesOrNo)].Value;
                    if (standalone.Length >= 3)
                        standalone = standalone.Substring(1, standalone.Length - 2);

                    result.isStandAlone = standalone.Equals("yes", StringComparison.InvariantCultureIgnoreCase);
                }


                status.ActualNode = result;
            }

            return status;
        }



    }
}
