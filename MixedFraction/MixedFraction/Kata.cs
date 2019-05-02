using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MixedFraction
{
    public class Kata
    {
        private static int _dividend, _divisor, _quatation, _remainder;

        public static string MixedFraction( string s )
        {
            ParseNumbers( s );
            return CalculateResult();
        }

        public static void ParseNumbers( string input )
        {
            string[] numbers = input.Split( '/' );

            _dividend = int.Parse( numbers[ 0 ] );

            _divisor = int.Parse( numbers[ 1 ] );

            if( _divisor == 0 )
            {
                throw new DivideByZeroException();
            }
        }

        public static string CalculateResult()
        {
            _quatation = _dividend / _divisor;

            _remainder = _dividend % _divisor;

            if( _remainder == 0 )
            {
                return _quatation.ToString();
            }

            int gcd = CalculateGcd( new int[] { _remainder , _divisor } );

            return $"{_quatation} {_remainder / gcd}/{_divisor / gcd}";
        }




        static int CalculateGcd( int[] numbers )
        {
            return numbers.Aggregate( CalculateGcd );
        }

        static int CalculateGcd( int a , int b )
        {
            return b == 0 ? a : CalculateGcd( b , a % b );
        }


    }
}
