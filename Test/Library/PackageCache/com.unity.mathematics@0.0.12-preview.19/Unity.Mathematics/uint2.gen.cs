// GENERATED CODE
using System;
using System.Runtime.CompilerServices;
using System.Diagnostics;

#pragma warning disable 0660, 0661

namespace Unity.Mathematics
{
    [DebuggerTypeProxy(typeof(uint2.DebuggerProxy))]
    [System.Serializable]
    public partial struct uint2 : System.IEquatable<uint2>, IFormattable
    {
        public uint x;
        public uint y;

        /// <summary>uint2 zero value.</summary>
        public static readonly uint2 zero = new uint2(0u,   0u);


        /// <summary>Constructs a uint2 vector from two uint values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2(uint x, uint y)
        { 
            this.x = x;
            this.y = y;
        }

        /// <summary>Constructs a uint2 vector from a uint2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2(uint2 xy)
        { 
            this.x = xy.x;
            this.y = xy.y;
        }

        /// <summary>Constructs a uint2 vector from a single uint value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2(uint v)
        {
            this.x = v;
            this.y = v;
        }

        /// <summary>Constructs a uint2 vector from a single bool value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2(bool v)
        {
            this.x = v ? 1u : 0u;
            this.y = v ? 1u : 0u;
        }

        /// <summary>Constructs a uint2 vector from a bool2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2(bool2 v)
        {
            this.x = v.x ? 1u : 0u;
            this.y = v.y ? 1u : 0u;
        }

        /// <summary>Constructs a uint2 vector from a single int value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2(int v)
        {
            this.x = (uint)v;
            this.y = (uint)v;
        }

        /// <summary>Constructs a uint2 vector from a int2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2(int2 v)
        {
            this.x = (uint)v.x;
            this.y = (uint)v.y;
        }

        /// <summary>Constructs a uint2 vector from a single float value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2(float v)
        {
            this.x = (uint)v;
            this.y = (uint)v;
        }

        /// <summary>Constructs a uint2 vector from a float2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2(float2 v)
        {
            this.x = (uint)v.x;
            this.y = (uint)v.y;
        }

        /// <summary>Constructs a uint2 vector from a single double value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2(double v)
        {
            this.x = (uint)v;
            this.y = (uint)v;
        }

        /// <summary>Constructs a uint2 vector from a double2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public uint2(double2 v)
        {
            this.x = (uint)v.x;
            this.y = (uint)v.y;
        }


        /// <summary>Implicitly converts a single uint value to a uint2 vector by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static implicit operator uint2(uint v) { return new uint2(v); }

        /// <summary>Explicitly converts a single bool value to a uint2 vector by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2(bool v) { return new uint2(v); }

        /// <summary>Explicitly converts a bool2 vector to a uint2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2(bool2 v) { return new uint2(v); }

        /// <summary>Explicitly converts a single int value to a uint2 vector by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2(int v) { return new uint2(v); }

        /// <summary>Explicitly converts a int2 vector to a uint2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2(int2 v) { return new uint2(v); }

        /// <summary>Explicitly converts a single float value to a uint2 vector by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2(float v) { return new uint2(v); }

        /// <summary>Explicitly converts a float2 vector to a uint2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2(float2 v) { return new uint2(v); }

        /// <summary>Explicitly converts a single double value to a uint2 vector by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2(double v) { return new uint2(v); }

        /// <summary>Explicitly converts a double2 vector to a uint2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static explicit operator uint2(double2 v) { return new uint2(v); }


        /// <summary>Returns the result of a componentwise multiplication operation on two uint2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator * (uint2 lhs, uint2 rhs) { return new uint2 (lhs.x * rhs.x, lhs.y * rhs.y); }

        /// <summary>Returns the result of a componentwise multiplication operation on a uint2 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator * (uint2 lhs, uint rhs) { return new uint2 (lhs.x * rhs, lhs.y * rhs); }

        /// <summary>Returns the result of a componentwise multiplication operation on a uint value and a uint2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator * (uint lhs, uint2 rhs) { return new uint2 (lhs * rhs.x, lhs * rhs.y); }


        /// <summary>Returns the result of a componentwise addition operation on two uint2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator + (uint2 lhs, uint2 rhs) { return new uint2 (lhs.x + rhs.x, lhs.y + rhs.y); }

        /// <summary>Returns the result of a componentwise addition operation on a uint2 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator + (uint2 lhs, uint rhs) { return new uint2 (lhs.x + rhs, lhs.y + rhs); }

        /// <summary>Returns the result of a componentwise addition operation on a uint value and a uint2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator + (uint lhs, uint2 rhs) { return new uint2 (lhs + rhs.x, lhs + rhs.y); }


        /// <summary>Returns the result of a componentwise subtraction operation on two uint2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator - (uint2 lhs, uint2 rhs) { return new uint2 (lhs.x - rhs.x, lhs.y - rhs.y); }

        /// <summary>Returns the result of a componentwise subtraction operation on a uint2 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator - (uint2 lhs, uint rhs) { return new uint2 (lhs.x - rhs, lhs.y - rhs); }

        /// <summary>Returns the result of a componentwise subtraction operation on a uint value and a uint2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator - (uint lhs, uint2 rhs) { return new uint2 (lhs - rhs.x, lhs - rhs.y); }


        /// <summary>Returns the result of a componentwise division operation on two uint2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator / (uint2 lhs, uint2 rhs) { return new uint2 (lhs.x / rhs.x, lhs.y / rhs.y); }

        /// <summary>Returns the result of a componentwise division operation on a uint2 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator / (uint2 lhs, uint rhs) { return new uint2 (lhs.x / rhs, lhs.y / rhs); }

        /// <summary>Returns the result of a componentwise division operation on a uint value and a uint2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator / (uint lhs, uint2 rhs) { return new uint2 (lhs / rhs.x, lhs / rhs.y); }


        /// <summary>Returns the result of a componentwise modulus operation on two uint2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator % (uint2 lhs, uint2 rhs) { return new uint2 (lhs.x % rhs.x, lhs.y % rhs.y); }

        /// <summary>Returns the result of a componentwise modulus operation on a uint2 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator % (uint2 lhs, uint rhs) { return new uint2 (lhs.x % rhs, lhs.y % rhs); }

        /// <summary>Returns the result of a componentwise modulus operation on a uint value and a uint2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator % (uint lhs, uint2 rhs) { return new uint2 (lhs % rhs.x, lhs % rhs.y); }


        /// <summary>Returns the result of a componentwise increment operation on a uint2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator ++ (uint2 val) { return new uint2 (++val.x, ++val.y); }


        /// <summary>Returns the result of a componentwise decrement operation on a uint2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator -- (uint2 val) { return new uint2 (--val.x, --val.y); }


        /// <summary>Returns the result of a componentwise less than operation on two uint2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator < (uint2 lhs, uint2 rhs) { return new bool2 (lhs.x < rhs.x, lhs.y < rhs.y); }

        /// <summary>Returns the result of a componentwise less than operation on a uint2 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator < (uint2 lhs, uint rhs) { return new bool2 (lhs.x < rhs, lhs.y < rhs); }

        /// <summary>Returns the result of a componentwise less than operation on a uint value and a uint2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator < (uint lhs, uint2 rhs) { return new bool2 (lhs < rhs.x, lhs < rhs.y); }


        /// <summary>Returns the result of a componentwise less or equal operation on two uint2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator <= (uint2 lhs, uint2 rhs) { return new bool2 (lhs.x <= rhs.x, lhs.y <= rhs.y); }

        /// <summary>Returns the result of a componentwise less or equal operation on a uint2 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator <= (uint2 lhs, uint rhs) { return new bool2 (lhs.x <= rhs, lhs.y <= rhs); }

        /// <summary>Returns the result of a componentwise less or equal operation on a uint value and a uint2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator <= (uint lhs, uint2 rhs) { return new bool2 (lhs <= rhs.x, lhs <= rhs.y); }


        /// <summary>Returns the result of a componentwise greater than operation on two uint2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator > (uint2 lhs, uint2 rhs) { return new bool2 (lhs.x > rhs.x, lhs.y > rhs.y); }

        /// <summary>Returns the result of a componentwise greater than operation on a uint2 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator > (uint2 lhs, uint rhs) { return new bool2 (lhs.x > rhs, lhs.y > rhs); }

        /// <summary>Returns the result of a componentwise greater than operation on a uint value and a uint2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator > (uint lhs, uint2 rhs) { return new bool2 (lhs > rhs.x, lhs > rhs.y); }


        /// <summary>Returns the result of a componentwise greater or equal operation on two uint2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator >= (uint2 lhs, uint2 rhs) { return new bool2 (lhs.x >= rhs.x, lhs.y >= rhs.y); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a uint2 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator >= (uint2 lhs, uint rhs) { return new bool2 (lhs.x >= rhs, lhs.y >= rhs); }

        /// <summary>Returns the result of a componentwise greater or equal operation on a uint value and a uint2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator >= (uint lhs, uint2 rhs) { return new bool2 (lhs >= rhs.x, lhs >= rhs.y); }


        /// <summary>Returns the result of a componentwise unary minus operation on a uint2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator - (uint2 val) { return new uint2 ((uint)-val.x, (uint)-val.y); }


        /// <summary>Returns the result of a componentwise unary plus operation on a uint2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator + (uint2 val) { return new uint2 (+val.x, +val.y); }


        /// <summary>Returns the result of a componentwise left shift operation on a uint2 vector by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator << (uint2 x, int n) { return new uint2 (x.x << n, x.y << n); }

        /// <summary>Returns the result of a componentwise right shift operation on a uint2 vector by a number of bits specified by a single int.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator >> (uint2 x, int n) { return new uint2 (x.x >> n, x.y >> n); }

        /// <summary>Returns the result of a componentwise equality operation on two uint2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator == (uint2 lhs, uint2 rhs) { return new bool2 (lhs.x == rhs.x, lhs.y == rhs.y); }

        /// <summary>Returns the result of a componentwise equality operation on a uint2 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator == (uint2 lhs, uint rhs) { return new bool2 (lhs.x == rhs, lhs.y == rhs); }

        /// <summary>Returns the result of a componentwise equality operation on a uint value and a uint2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator == (uint lhs, uint2 rhs) { return new bool2 (lhs == rhs.x, lhs == rhs.y); }


        /// <summary>Returns the result of a componentwise not equal operation on two uint2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator != (uint2 lhs, uint2 rhs) { return new bool2 (lhs.x != rhs.x, lhs.y != rhs.y); }

        /// <summary>Returns the result of a componentwise not equal operation on a uint2 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator != (uint2 lhs, uint rhs) { return new bool2 (lhs.x != rhs, lhs.y != rhs); }

        /// <summary>Returns the result of a componentwise not equal operation on a uint value and a uint2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool2 operator != (uint lhs, uint2 rhs) { return new bool2 (lhs != rhs.x, lhs != rhs.y); }


        /// <summary>Returns the result of a componentwise bitwise not operation on a uint2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator ~ (uint2 val) { return new uint2 (~val.x, ~val.y); }


        /// <summary>Returns the result of a componentwise bitwise and operation on two uint2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator & (uint2 lhs, uint2 rhs) { return new uint2 (lhs.x & rhs.x, lhs.y & rhs.y); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a uint2 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator & (uint2 lhs, uint rhs) { return new uint2 (lhs.x & rhs, lhs.y & rhs); }

        /// <summary>Returns the result of a componentwise bitwise and operation on a uint value and a uint2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator & (uint lhs, uint2 rhs) { return new uint2 (lhs & rhs.x, lhs & rhs.y); }


        /// <summary>Returns the result of a componentwise bitwise or operation on two uint2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator | (uint2 lhs, uint2 rhs) { return new uint2 (lhs.x | rhs.x, lhs.y | rhs.y); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a uint2 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator | (uint2 lhs, uint rhs) { return new uint2 (lhs.x | rhs, lhs.y | rhs); }

        /// <summary>Returns the result of a componentwise bitwise or operation on a uint value and a uint2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator | (uint lhs, uint2 rhs) { return new uint2 (lhs | rhs.x, lhs | rhs.y); }


        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on two uint2 vectors.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator ^ (uint2 lhs, uint2 rhs) { return new uint2 (lhs.x ^ rhs.x, lhs.y ^ rhs.y); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a uint2 vector and a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator ^ (uint2 lhs, uint rhs) { return new uint2 (lhs.x ^ rhs, lhs.y ^ rhs); }

        /// <summary>Returns the result of a componentwise bitwise exclusive or operation on a uint value and a uint2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 operator ^ (uint lhs, uint2 rhs) { return new uint2 (lhs ^ rhs.x, lhs ^ rhs.y); }




        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(x, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(x, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(x, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(x, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(x, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(x, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(x, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 xyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(x, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yxxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(y, x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yxxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(y, x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yxyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(y, x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yxyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(y, x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yyxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(y, y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yyxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(y, y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yyyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(y, y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint4 yyyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint4(y, y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 xxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint3(x, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 xxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint3(x, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 xyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint3(x, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 xyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint3(x, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 yxx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint3(y, x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 yxy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint3(y, x, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 yyx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint3(y, y, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint3 yyy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint3(y, y, y); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint2 xx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint2(x, x); }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint2 xy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint2(x, y); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { x = value.x; y = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint2 yx
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint2(y, x); }
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            set { y = value.x; x = value.y; }
        }


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public uint2 yy
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get { return new uint2(y, y); }
        }



        /// <summary>Returns the uint element at a specified index.</summary>
        unsafe public uint this[int index]
        {
            get
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (uint2* array = &this) { return ((uint*)array)[index]; }
            }
            set
            {
#if ENABLE_UNITY_COLLECTIONS_CHECKS
                if ((uint)index >= 2)
                    throw new System.ArgumentException("index must be between[0...1]");
#endif
                fixed (uint* array = &x) { array[index] = value; }
            }
        }

        /// <summary>Returns true if the uint2 is equal to a given uint2, false otherwise.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public bool Equals(uint2 rhs) { return x == rhs.x && y == rhs.y; }

        /// <summary>Returns true if the uint2 is equal to a given uint2, false otherwise.</summary>
        public override bool Equals(object o) { return Equals((uint2)o); }


        /// <summary>Returns a hash code for the uint2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override int GetHashCode() { return (int)math.hash(this); }


        /// <summary>Returns a string representation of the uint2.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public override string ToString()
        {
            return string.Format("uint2({0}, {1})", x, y);
        }

        /// <summary>Returns a string representation of the uint2 using a specified format and culture-specific format information.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string ToString(string format, IFormatProvider formatProvider)
        {
            return string.Format("uint2({0}, {1})", x.ToString(format, formatProvider), y.ToString(format, formatProvider));
        }

        internal sealed class DebuggerProxy
        {
            public uint x;
            public uint y;
            public DebuggerProxy(uint2 v)
            {
                x = v.x;
                y = v.y;
            }
        }

    }

    public static partial class math
    {
        /// <summary>Returns a uint2 vector constructed from two uint values.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 uint2(uint x, uint y) { return new uint2(x, y); }

        /// <summary>Returns a uint2 vector constructed from a uint2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 uint2(uint2 xy) { return new uint2(xy); }

        /// <summary>Returns a uint2 vector constructed from a single uint value by assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 uint2(uint v) { return new uint2(v); }

        /// <summary>Returns a uint2 vector constructed from a single bool value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 uint2(bool v) { return new uint2(v); }

        /// <summary>Return a uint2 vector constructed from a bool2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 uint2(bool2 v) { return new uint2(v); }

        /// <summary>Returns a uint2 vector constructed from a single int value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 uint2(int v) { return new uint2(v); }

        /// <summary>Return a uint2 vector constructed from a int2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 uint2(int2 v) { return new uint2(v); }

        /// <summary>Returns a uint2 vector constructed from a single float value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 uint2(float v) { return new uint2(v); }

        /// <summary>Return a uint2 vector constructed from a float2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 uint2(float2 v) { return new uint2(v); }

        /// <summary>Returns a uint2 vector constructed from a single double value by converting it to uint and assigning it to every component.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 uint2(double v) { return new uint2(v); }

        /// <summary>Return a uint2 vector constructed from a double2 vector by componentwise conversion.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 uint2(double2 v) { return new uint2(v); }

        /// <summary>Returns a uint hash code of a uint2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint hash(uint2 v)
        {
            return csum(v * uint2(0x4C7F6DD1u, 0x4822A3E9u)) + 0xAAC3C25Du;
        }

        /// <summary>
        /// Returns a uint2 vector hash code of a uint2 vector.
        /// When multiple elements are to be hashes together, it can more efficient to calculate and combine wide hash
        /// that are only reduced to a narrow uint hash at the very end instead of at every step.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 hashwide(uint2 v)
        {
            return (v * uint2(0xD21D0945u, 0x88FCAB2Du)) + 0x614DA60Du;
        }

        /// <summary>Returns the result of specified shuffling of the components from two uint2 vectors into a uint value.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint shuffle(uint2 a, uint2 b, ShuffleComponent x)
        {
            return select_shuffle_component(a, b, x);
        }

        /// <summary>Returns the result of specified shuffling of the components from two uint2 vectors into a uint2 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint2 shuffle(uint2 a, uint2 b, ShuffleComponent x, ShuffleComponent y)
        {
            return uint2(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y));
        }

        /// <summary>Returns the result of specified shuffling of the components from two uint2 vectors into a uint3 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint3 shuffle(uint2 a, uint2 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z)
        {
            return uint3(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y),
                select_shuffle_component(a, b, z));
        }

        /// <summary>Returns the result of specified shuffling of the components from two uint2 vectors into a uint4 vector.</summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint4 shuffle(uint2 a, uint2 b, ShuffleComponent x, ShuffleComponent y, ShuffleComponent z, ShuffleComponent w)
        {
            return uint4(
                select_shuffle_component(a, b, x),
                select_shuffle_component(a, b, y),
                select_shuffle_component(a, b, z),
                select_shuffle_component(a, b, w));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static uint select_shuffle_component(uint2 a, uint2 b, ShuffleComponent component)
        {
            switch(component)
            {
                case ShuffleComponent.LeftX:
                    return a.x;
                case ShuffleComponent.LeftY:
                    return a.y;
                case ShuffleComponent.RightX:
                    return b.x;
                case ShuffleComponent.RightY:
                    return b.y;
                default:
                    throw new System.ArgumentException("Invalid shuffle component: " + component);
            }
        }

    }
}
