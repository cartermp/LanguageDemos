using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8
{
    /// <summary>
    /// Readonly members - tell the compiler when you're not modifying the state of a struct.
    /// It'll track if you're actually modifying it!
    /// </summary>
    public struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        /// <summary>
        /// This member also does not modify the state of the struct,
        /// but it doesn't tell the compiler as much.
        /// </summary>
        public double Distance => Math.Sqrt(X * X + Y * Y);

        /// <summary>
        /// Define ToString() as 'readonly', which means it won't modify the state of the struct.
        /// 
        /// 'readonly' is viral! Since 'Distance' is not declared as 'readonly',
        /// we get a warning here.
        /// </summary>
        /// <returns></returns>
        public readonly override string ToString() =>
            $"({X}, {Y}) is {Distance} from the origin";

        /// <summary>
        ///  Note that this code is not allowed - modification in a readonly member.
        /// </summary>
        //public readonly ModifyTheStruct()
        //{
        //    X = 12;
        //    Y = 13;
        //}
    }
}
