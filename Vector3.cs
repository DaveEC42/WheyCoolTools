//NOTE: A VALIDATOR METHOD NEEDS TO CHECK FOR NULL POSSIBLY
//None of these methods have been tested yet.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WheyCoolStudios.Tools.MathUtil
{
    public class Vector3
    {
        private float _x;
        private float _y;
        private float _z;
        

        public float X { get => _x; }
        public float Y { get => _y; }
        public float Z { get => _z; }
        

        public Vector3(float x, float y, float z)
        {       
            _x = x;
            _y = y;
            _z = z;
        
        }

        public Vector3() : this(0f, 0f, 0f)
        { }

        
        public static float Magnitude(Vector3 vector) => 
            (float)Math.Abs(Math.Sqrt(vector.X * vector.X + vector.Y * vector.Y + vector.Z * vector.Z));
        

        public static Vector3 AddVector(Vector3 vectorLhs, Vector3 vectorRhs) =>
            new Vector3(vectorLhs.X + vectorRhs.X, vectorLhs.Y + vectorRhs.Y, vectorLhs.Z + vectorRhs.Z);

        public void AddVector(Vector3 vector) =>
            AddVector(vector.X, vector.Y, vector.Z);
        
        public void AddVector(float x, float y, float z)
        {
            _x += x;
            _y += y;
            _z += z;
        }

        public void SubtractVector(Vector3 vector) =>
            SubtractVector(vector.X, vector.Y, vector.Z);
        
        public void SubtractVector(float x, float y, float z)
        {
            _x -= x;
            _y -= y;
            _z -= z;
        }

        public static Vector3 SubtractVector(Vector3 vectorLhs, Vector3 vectorRhs) =>
            new Vector3(vectorLhs.X + vectorRhs.X, vectorLhs.Y + vectorRhs.Y, vectorLhs.Z + vectorRhs.Z);
        
        public static float DotProduct(Vector3 vectorLhs, Vector3 vectorRhs) =>
             ((vectorLhs.X * vectorRhs.X) + (vectorLhs.Y * vectorRhs.Y) + (vectorLhs.Z * vectorRhs.Z));

        public float DotProduct(float magnitude, float angle) =>        
            (float)(Magnitude(this) * magnitude * Math.Cos(angle));
        

        public static float AngleBetween(Vector3 vectorLhs, Vector3 vectorRhs)
        {
            float dot = DotProduct(vectorLhs, vectorRhs);
            float multiplyMag = Magnitude(vectorLhs) * Magnitude(vectorRhs);
            float angle = (float)Math.Acos(dot / multiplyMag);
            return angle;
        }

        public static Vector3 UnitVector(Vector3 vector)
        {
            float mag = Magnitude(vector);
            return new Vector3(vector.X / mag, vector.Y / mag, vector.Z / mag);
        }

        public static Vector3 operator+ (Vector3 left, Vector3 right) =>
            AddVector(left, right);
        

        public static Vector3 operator- (Vector3 left, Vector3 right) =>
            SubtractVector(left, right);

        public static float operator *(Vector3 left, Vector3 right) =>
            DotProduct(left, right);
            
    }
}
