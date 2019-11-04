using System;
using System.Collections.Generic;
using System.Text;

// Enable nullability analysis for the whole file.
// For a proejct, set '<Nullable>enable</Nullable>' in the project file.
#nullable enable

namespace CSharp8
{
    public static class NullableWithStrings
    {
        /// <summary>
        /// Unsafely "dot" into a nullable reference type and observe the warning.
        /// </summary>
        public static int StringLengthUnsafe(string? theString) => theString.Length;

        /// <summary>
        /// Safely "dot" into a nullable reference type. Flow analysis tells us it's safe.
        /// </summary>
        public static int StringLengthSafe(string? theString) =>
            string.IsNullOrWhiteSpace(theString) ? 0 : theString.Length;
    }
}
