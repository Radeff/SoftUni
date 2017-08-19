﻿using System;

namespace _06.CustomEnumAttribute
{
    public class TypeAttribute : Attribute
    {
        public TypeAttribute(string type, string category, string description)
        {
            this.Type = type;
            this.Category = category;
            this.Description = description;
        }

        public string Description { get; set; }

        public string Category { get; set; }

        public string Type { get; set; }
    }
}