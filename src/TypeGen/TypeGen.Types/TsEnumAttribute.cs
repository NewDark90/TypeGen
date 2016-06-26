﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TypeGen.Types
{
    /// <summary>
    /// Indentifies an enum that a TypeScript file should be generated for
    /// </summary>
    [AttributeUsage(AttributeTargets.Enum)]
    public class TsEnumAttribute : Attribute
    {
        /// <summary>
        /// TypeScript file output directory
        /// </summary>
        public string OutputDir { get; set; }
    }
}