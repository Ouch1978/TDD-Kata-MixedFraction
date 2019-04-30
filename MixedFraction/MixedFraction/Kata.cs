using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixedFraction
{
    public class Kata
    {
        public static string MixedFraction( string s )
        {
            return CalculateResult( ParseNumbers( s ) );
        }

        public static Tuple<int , int> ParseNumbers( string input )
        {
            string[] numbers = input.Split( '/' );

            if( numbers.Contains( "0" ) )
            {
                throw new DivideByZeroException();
            }

            return null;
        }

        public static string CalculateResult( Tuple<int , int> inputNumbers )
        {
            return string.Empty;
        }
    }
}
