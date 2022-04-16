using System;
using UnityEngine;

public static class MathUtils
{

    public static Vector3 MultiplyMatrixAndVector(float[,] m, Vector3 v) 
    {
        return new Vector3(
            v.x * m[0, 0] + v.y * m[0, 1] + v.z * m[0, 2],
            v.x * m[1, 0] + v.y * m[1, 1] + v.z * m[1, 2],
            v.x * m[2, 0] + v.y * m[2, 1] + v.z * m[2, 2]
        );
    }

    public static Vector3 RotateVectorAroundAxis(Vector3 vector, Vector3 a, Vector3 b, double angle)
    {
        var normalizedAxis = (b - a).normalized;
        var x = normalizedAxis.x;
        var y = normalizedAxis.y;
        var z = normalizedAxis.z;
        var translationVector = ProjectPointOnAxis(vector, a, b);
        var c = (float) Math.Cos(angle);
        var s = (float) Math.Sin(angle);
        var rotationMatrix = new float[3, 3];

        rotationMatrix[0, 0] = c + x * x * (1 - c);
        rotationMatrix[0, 1] = x * y * (1 - c) - z * s;
        rotationMatrix[0, 2] = x * z * (1 - c) + y * s;
        rotationMatrix[1, 0] = y * x * (1 - c) + z * s;
        rotationMatrix[1, 1] = c + y * y * (1 - c);
        rotationMatrix[1, 2] = y * z * (1 - c) - x * s;
        rotationMatrix[2, 0] = z * x * (1 - c) - y * s;
        rotationMatrix[2, 1] = z * y * (1 - c) + x * s;
        rotationMatrix[2, 2] = c + z * z * (1 - c);

        return MultiplyMatrixAndVector(rotationMatrix, vector - translationVector) + translationVector;
    }

    public static Vector3 ProjectPointOnAxis(Vector3 vector, Vector3 a, Vector3 b)
    {
        var ba = b - a;
        var lambda = Vector3.Dot(ba, vector - a) / Vector3.Dot(ba, ba);

        return a + lambda * ba;
    }

}