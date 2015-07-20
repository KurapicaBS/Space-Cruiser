using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Space_Cruiser
{

    public struct Vector2D
    {
        private static readonly Vector2D _zero;
        private static readonly Vector2D _unit;
        private static readonly Vector2D _unitX;
        private static readonly Vector2D _unitY;
        public float X;
        public float Y;
        public float Length
        {
            get
            {
                return MathUtility.Sqrt((this.X * this.X) + (this.Y * this.Y));
            }
        }
        public float LengthSquare
        {
            get
            {
                return ((this.X * this.X) + (this.Y * this.Y));
            }
        }
        public float InverseLength
        {
            get
            {
                float length = this.Length;
                if (length == 0.0)
                {
                    return 0f;
                }
                return (1f / length);
            }
        }
        public static Vector2D Zero
        {
            get
            {
                return _zero;
            }
        }
        public static Vector2D Unit
        {
            get
            {
                return _unit;
            }
        }
        public static Vector2D UnitX
        {
            get
            {
                return _unitX;
            }
        }
        public static Vector2D UnitY
        {
            get
            {
                return _unitY;
            }
        }
        public float Angle()
        {
            return MathUtility.ATan(this.Y, this.X);
        }

        public static float Angle(Vector2D vector1, Vector2D vector2)
        {
            vector1.Normalize();
            vector2.Normalize();
            return MathUtility.ACos(DotProduct(vector1, vector2));
        }

        public static Vector2D Negate(Vector2D left)
        {
            return new Vector2D(-left.X, -left.Y);
        }

        public static Vector2D Add(Vector2D left, Vector2D right)
        {
            return new Vector2D(left.X + right.X, left.Y + right.Y);
        }

        public static Vector2D Subtract(Vector2D left, Vector2D right)
        {
            return new Vector2D(left.X - right.X, left.Y - right.Y);
        }

        public static Vector2D Divide(Vector2D dividend, Vector2D divisor)
        {
            return new Vector2D(dividend.X / divisor.X, dividend.Y / divisor.Y);
        }

        public static Vector2D Divide(Vector2D dividend, float divisor)
        {
            return new Vector2D(dividend.X / divisor, dividend.Y / divisor);
        }

        public static Vector2D Multiply(Vector2D left, Vector2D right)
        {
            return new Vector2D(left.X * right.X, left.Y * right.Y);
        }

        public static Vector2D Multiply(Vector2D left, float right)
        {
            return new Vector2D(left.X * right, left.Y * right);
        }

        public static float DotProduct(Vector2D left, Vector2D right)
        {
            return ((left.X * right.X) + (left.Y * right.Y));
        }

        public static Vector2D Normalize(Vector2D vector)
        {
            Vector2D zero = Zero;
            if (vector.Length > float.Epsilon)
            {
                float inverseLength = vector.InverseLength;
                zero.X = vector.X * inverseLength;
                zero.Y = vector.Y * inverseLength;
            }
            return zero;
        }

        public void Normalize()
        {
            if (this.Length > float.Epsilon)
            {
                float inverseLength = this.InverseLength;
                this.X *= inverseLength;
                this.Y *= inverseLength;
            }
        }

        public static Vector2D CrossProduct(Vector2D vector1, Vector2D vector2)
        {
            return new Vector2D((vector2.X * vector1.Y) - (vector2.Y * vector1.X), (vector2.Y * vector1.X) - (vector2.X * vector1.Y));
        }

        public override bool Equals(object obj)
        {
            return ((obj is Vector2D) && (this == ((Vector2D)obj)));
        }

        public override int GetHashCode()
        {
            return (this.X.GetHashCode() ^ this.Y.GetHashCode());
        }

        public override string ToString()
        {
            return string.Format("2D Vector:\n\tX:{0}, Y:{1}", this.X, this.Y);
        }

        public static bool operator ==(Vector2D left, Vector2D right)
        {
            return (MathUtility.EqualFloat(left.X, right.X) && MathUtility.EqualFloat(left.Y, right.Y));
        }

        public static bool operator !=(Vector2D left, Vector2D right)
        {
            return !(left == right);
        }

        public static bool operator <(Vector2D left, Vector2D right)
        {
            return ((left.X < right.X) && (left.Y < right.Y));
        }

        public static bool operator >(Vector2D left, Vector2D right)
        {
            return ((left.X > right.X) && (left.Y > right.Y));
        }

        public static bool operator <=(Vector2D left, Vector2D right)
        {
            return ((left.X <= right.X) && (left.Y <= right.Y));
        }

        public static bool operator >=(Vector2D left, Vector2D right)
        {
            return ((left.X >= right.X) && (left.Y >= right.Y));
        }

        public static Vector2D operator +(Vector2D left, Vector2D right)
        {
            return Add(left, right);
        }

        public static Vector2D operator -(Vector2D left, Vector2D right)
        {
            return Subtract(left, right);
        }

        public static Vector2D operator -(Vector2D left)
        {
            return Negate(left);
        }

        public static Vector2D operator *(Vector2D left, Vector2D right)
        {
            return Multiply(left, right);
        }

        public static Vector2D operator *(Vector2D left, float scalar)
        {
            return Multiply(left, scalar);
        }

        public static Vector2D operator *(float scalar, Vector2D right)
        {
            return Multiply(right, scalar);
        }

        public static Vector2D operator /(Vector2D left, float scalar)
        {
            return Divide(left, scalar);
        }

        public static Vector2D operator /(Vector2D left, Vector2D right)
        {
            return Divide(left, right);
        }


        public static implicit operator Vector2D(Point point)
        {
            return new Vector2D(point);
        }

        public static implicit operator Vector2D(PointF point)
        {
            return new Vector2D(point);
        }

        public static implicit operator Vector2D(Size point)
        {
            return new Vector2D(point);
        }

        public static implicit operator Vector2D(SizeF point)
        {
            return new Vector2D(point);
        }

        public static explicit operator Point(Vector2D vector)
        {
            return new Point((int)vector.X, (int)vector.Y);
        }

        public static implicit operator PointF(Vector2D vector)
        {
            return new PointF(vector.X, vector.Y);
        }

        public static explicit operator Size(Vector2D vector)
        {
            return new Size((int)vector.X, (int)vector.Y);
        }

        public static implicit operator SizeF(Vector2D vector)
        {
            return new SizeF(vector.X, vector.Y);
        }

        public Vector2D(float x, float y)
        {
            this.X = x;
            this.Y = y;
        }

        public Vector2D(PointF point)
        {
            this.X = point.X;
            this.Y = point.Y;
        }

        public Vector2D(Point point)
        {
            this.X = point.X;
            this.Y = point.Y;
        }

        public Vector2D(Size size)
        {
            this.X = size.Width;
            this.Y = size.Height;
        }

        public Vector2D(SizeF size)
        {
            this.X = size.Width;
            this.Y = size.Height;
        }

        static Vector2D()
        {
            _zero = new Vector2D(0f, 0f);
            _unit = new Vector2D(1f, 1f);
            _unitX = new Vector2D(1f, 0f);
            _unitY = new Vector2D(0f, 1f);
        }
    }

    /// <summary>
    /// Value type representing a star.
    /// </summary>
    public struct Star
    {
        /// <summary>
        /// Position of the star.
        /// </summary>
        public Vector2D Position;
        /// <summary>
        /// Magnitude of the star.
        /// </summary>
        public Pen Magnitude;
        /// <summary>
        /// Vertical delta.
        /// </summary>
        public float VDelta;

        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="position">Position of the star.</param>
        /// <param name="magnitude">Magnitude of the star.</param>
        public Star(Vector2D position, Pen magnitude)
        {
            Position = position;
            Magnitude = magnitude;
            VDelta = 0;
        }
    }

}

