
using UnityEngine;
using System.Collections;

public sealed partial class Vector3
{
    public static Vector3 operator+(Vector3 a, Vector3 b)
	{
		var result = new Vector3();
		result.X = a.X + b.X;
		result.Y = a.Y + b.Y;
		result.Z = a.Z + b.Z;
		return result;
	}

    public static Vector3 operator*(Vector3 a, double b)
	{
		var result = new Vector3();
		result.X = a.X * b;
		result.Y = a.Y * b;
		result.Z = a.Z * b;
		return result;
	}

	public static implicit operator UnityEngine.Vector3(Vector3 a)
	{
		var result = new UnityEngine.Vector3();
		result.x = (float)a.X;
		result.y = (float)a.Y;
		result.z = (float)a.Z;
		return result;
	}

	public static implicit operator Vector3(UnityEngine.Vector3 a)
	{
		var result = new Vector3();
		result.X = a.x;
		result.Y = a.y;
		result.Z = a.z;
		return result;
	}
}

public sealed partial class Quaternion
{
    public static implicit operator UnityEngine.Quaternion(Quaternion a)
    {
        var result = new UnityEngine.Quaternion();
        result.x = (float)a.X;
        result.y = (float)a.Y;
        result.z = (float)a.Z;
        result.w = (float)a.W;
        return result;
    }

    public static implicit operator Quaternion(UnityEngine.Quaternion a)
    {
        var result = new Quaternion();
        result.X = a.x;
        result.Y = a.y;
        result.Z = a.z;
        result.W = a.w;
        return result;
    }
}
