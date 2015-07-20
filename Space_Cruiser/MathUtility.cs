using System;
using System.Collections.Generic;
using System.Text;

namespace Space_Cruiser
{
    public static class MathUtility
    {
        // Fields
        private const float degConvert = 0.01745329f;
        public const float PI = 3.141593f;
        private const float radConvert = 57.29578f;

        // Methods
        public static int Abs(int number)
        {
            return Math.Abs(number);
        }

        public static float Abs(float number)
        {
            return Math.Abs(number);
        }

        public static float ACos(float cosine)
        {
            return (float)Math.Acos((double)cosine);
        }

        public static float ASin(float sine)
        {
            return (float)Math.Asin((double)sine);
        }

        public static float ATan(float y, float x)
        {
            return (float)Math.Atan2((double)y, (double)x);
        }

        public static float Cos(float radians)
        {
            return (float)Math.Cos((double)radians);
        }

        public static float Degrees(float radians)
        {
            return (57.29578f * radians);
        }

        public static bool EqualFloat(float value1, float value2)
        {
            return EqualFloat(value1, value2, 1E-06f);
        }

        public static bool EqualFloat(float value1, float value2, float epsilon)
        {
            return (Abs((float)(value2 - value1)) <= epsilon);
        }

        public static float InverseSqrt(float sqvalue)
        {
            return (1f / Sqrt(sqvalue));
        }

        public static short Max(short value1, short value2)
        {
            if (value1 > value2)
            {
                return value1;
            }
            return value2;
        }

        public static int Max(int value1, int value2)
        {
            if (value1 > value2)
            {
                return value1;
            }
            return value2;
        }

        public static float Max(float value1, float value2)
        {
            if (value1 > value2)
            {
                return value1;
            }
            return value2;
        }

        public static short Min(short value1, short value2)
        {
            if (value1 < value2)
            {
                return value1;
            }
            return value2;
        }

        public static int Min(int value1, int value2)
        {
            if (value1 < value2)
            {
                return value1;
            }
            return value2;
        }

        public static float Min(float value1, float value2)
        {
            if (value1 < value2)
            {
                return value1;
            }
            return value2;
        }

        public static float Pow(float value, float power)
        {
            return (float)Math.Pow((double)value, (double)power);
        }

        public static float Radians(float degrees)
        {
            return (0.01745329f * degrees);
        }

        public static Vector2D Round(Vector2D value)
        {
            return new Vector2D(Round(value.X), Round(value.Y));
        }

        public static float Round(float value)
        {
            return (float)Math.Round((double)value);
        }

        public static Vector2D Round(Vector2D value, int decimalPlaceCount)
        {
            return new Vector2D(Round(value.X, decimalPlaceCount), Round(value.Y, decimalPlaceCount));
        }

        public static float Round(float value, int decimalPlaceCount)
        {
            return (float)Math.Round((double)value, decimalPlaceCount);
        }

        public static Vector2D Round(Vector2D value, int decimalPlaceCount, MidpointRounding rounding)
        {
            return new Vector2D(Round(value.X, decimalPlaceCount, rounding), Round(value.Y, decimalPlaceCount, rounding));
        }

        public static float Round(float value, int decimalPlaceCount, MidpointRounding rounding)
        {
            return (float)Math.Round((double)value, decimalPlaceCount, rounding);
        }

        public static int RoundInt(float value)
        {
            return (int)Math.Round((double)value);
        }

        public static float Sin(float radians)
        {
            return (float)Math.Sin((double)radians);
        }

        public static float Sqrt(float sqvalue)
        {
            return (float)Math.Sqrt((double)sqvalue);
        }

        public static float Tan(float radians)
        {
            return (float)Math.Tan((double)radians);
        }
    }




}
