using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    internal class VarTypes
    {
        static void main(string[] args)
        {
            // Integer types
            byte varByte = 255;             // 8 bits, from 0 to 255
            sbyte varSbyte = -128;          // 8 bits, from -128 to 127
            short varShort = -32768;        // 16 bits, from -32,768 to 32,767
            ushort varUshort = 65535;       // 16 bits, from 0 to 65,535
            int varInt = -2147483648;       // 32 bits, from -2,147,483,648 to 2,147,483,647
            uint varUint = 4294967295;      // 32 bits, from 0 to 4,294,967,295
            long varLong = -9223372036854775808;  // 64 bits, from -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
            ulong varUlong = 18446744073709551615; // 64 bits, from 0 to 18,446,744,073,709,551,615

            // Floating point types
            float varFloat = 3.14f;         // 32 bits, precision of 7 digits
            double varDouble = 3.14159265359; // 64 bits, precision of 15 digits
            decimal varDecimal = 3.14159265358979323846m; // 128 bits, precision of 28-29 digits

            // Boolean type
            bool varBool = true;            // true or false

            // Character type
            char varChar = 'A';             // 16 bits, one Unicode character

            // String type
            string varString = "Hello, World!"; // Collection of characters

            // Object type
            object varObject = "I can be anything"; // Can store any type of data

            // Implicitly typed variables (type inference using var)
            var varImplicitInt = 42;        // Will be inferred as int
            var varImplicitString = "Text"; // Will be inferred as string

            // Nullable types (allow null values)
            int? varNullableInt = null;     // Can be an int or null
            bool? varNullableBool = null;   // Can be a bool or null

            // Output to console
            Console.WriteLine($"byte: {varByte}");
            Console.WriteLine($"sbyte: {varSbyte}");
            Console.WriteLine($"short: {varShort}");
            Console.WriteLine($"ushort: {varUshort}");
            Console.WriteLine($"int: {varInt}");
            Console.WriteLine($"uint: {varUint}");
            Console.WriteLine($"long: {varLong}");
            Console.WriteLine($"ulong: {varUlong}");
            Console.WriteLine($"float: {varFloat}");
            Console.WriteLine($"double: {varDouble}");
            Console.WriteLine($"decimal: {varDecimal}");
            Console.WriteLine($"bool: {varBool}");
            Console.WriteLine($"char: {varChar}");
            Console.WriteLine($"string: {varString}");
            Console.WriteLine($"object: {varObject}");
            Console.WriteLine($"var (int): {varImplicitInt}");
            Console.WriteLine($"var (string): {varImplicitString}");
            Console.WriteLine($"Nullable int: {varNullableInt}");
            Console.WriteLine($"Nullable bool: {varNullableBool}");

            Console.ReadKey();
        }
    }
}
