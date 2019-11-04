using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8
{
    /// <summary>
    /// Demos local functions (static and non-static)
    /// </summary>
    public static class StaticLocalFunctions
    {
        /// <summary>
        /// Shows how to define and call a static local function
        /// </summary>
        public static int Add5And7()
        {
            var five = 5;
            var seven = 7;

            return Add(five, seven);

            // Define a local function as a helper
            static int Add(int left, int right) => left + right;
        }

        public class Person
        {

        }

        public static int Add5And7NonStaticLocalFunction()
        {
            var five = 5;
            var seven = 7;

            Person p = null;

            p ??= new Person();
            p = p ?? (p = new Person());


            return Add();

            // Define a local function as a helper
            // Captures the 'five' and 'seven' variables
            // Generally safer/clearer if something is a pure helper function
            int Add() => five + seven;
        }
    }
}
