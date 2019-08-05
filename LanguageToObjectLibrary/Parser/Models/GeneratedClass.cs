using System;
using System.Collections.Generic;
using System.Text;

namespace LanguageToObjectLibrary.Parser.Models
{
    public abstract class GeneratedElement : IEquatable<GeneratedElement>
    {
        private string showName;

        public string ShowName
        {
            get { return showName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    showName = value;
                else
                {
                    showName = value[0].ToString().ToUpper() + (value.Length > 1 ? value.Substring(1) : "");
                }
            }
        }

        public string Id { get; set; } = "";
        public string Name { get; set; } = "";
        public string Namespace { get; set; } = "";

        public bool Equals(GeneratedElement other)
        {
            if (other == null) return false;

            return this.Id == other.Id;
        }
    }

    public class GeneratedClass : GeneratedElement
    {
        public Dictionary<string, GeneratedAttribute> Attributes { get; set; } = new Dictionary<string, GeneratedAttribute>();
        public Dictionary<string, GeneratedChild> Childs { get; set; } = new Dictionary<string, GeneratedChild>();
        public Value Value { get; set; }
    }

    public class Value : GeneratedElement
    {
        public Value()
        {
            Name = "Value";
            ShowName = Name;
        }

        public string Type { get; set; } = "object";
    }

    public class GeneratedAttribute : GeneratedElement
    {
        public GeneratedAttribute()
        {
            Name = "Value";
            Namespace = "";
            ShowName = Name;
        }
        public Value Value { get; set; }
    }

    public class GeneratedChild : GeneratedElement
    {
        public GeneratedClass Type { get; set; }
        public bool IsArray { get; set; } = false;

    }
}
