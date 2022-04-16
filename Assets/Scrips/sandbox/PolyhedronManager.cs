using System;
using System.Collections.Generic;
using UnityEngine;

public class PolyhedronManager : MonoBehaviour
{

    public Material material;
    
    void Start()
    {
        var polyhedron = CreatePolyhedron("dodecahedron", material);
        polyhedron.transform.position = new Vector3(-5, 0, 0);
    }
    public static GameObject CreatePolyhedron(string name, Material material)
    {
        // var material = Resources.Load<Material>("grass");
        var gameObject = new GameObject();

        Mesh mesh;

        switch (name)
        {
            case "hexahedron":
            {
                mesh = CreatePolyhedronMesh(4, Math.PI / 2);
                break;
            }

            case "tetrahedron":
            {
                mesh = CreatePolyhedronMesh(3, Math.Acos(1d / 3));
                break;
            }

            case "octahedron":
            {
                mesh = CreatePolyhedronMesh(3, Math.Acos(-1d / 3));
                break;
            }

            case "icosahedron":
            {
                mesh = CreatePolyhedronMesh(3, Math.Acos(-Math.Sqrt(5) / 3));
                break;
            }

            case "dodecahedron":
            {
                mesh = CreatePolyhedronMesh(5, 2 * Math.Atan2(1 + Math.Sqrt(5), 2));
                break;
            }

            default:
            {
                throw new Exception("Invalid polyhedron name");
            }
        }

        mesh.RecalculateNormals();
        gameObject.AddComponent<MeshRenderer>().material = material;
        gameObject.AddComponent<MeshFilter>().mesh = mesh;
        gameObject.name = char.ToUpper(name[0]) + name.Substring(1);
        gameObject.transform.rotation = Quaternion.Euler(180, 0, 0);

        return gameObject;
    }

    private static List<Vector3> CreatePolygonVertices(int nSides, Vector3 origin, Vector3 normal, Vector3 firstNode, bool shouldUseFirstNode)
    {
        var angle = 2 * Math.PI / nSides;
        var distanceFromCenter = (float) Math.Sqrt(0.5 / (1 - Math.Cos(angle)));
        var actualFirstNode = shouldUseFirstNode ? firstNode : origin + distanceFromCenter * Vector3.right;

        var vertices = new List<Vector3> {actualFirstNode};

        for (var i = 1; i < nSides; i++)
        {
            vertices.Add(MathUtils.RotateVectorAroundAxis(vertices[i - 1], origin, origin + normal, angle));
        }

        return vertices;
    }

    private static Mesh CreatePolyhedronMesh(int nSides, double dihedralAngle)
    {
        var supplementaryAngle = Math.PI - dihedralAngle;
        var origin = Vector3.zero;
        var faces = new List<List<Vector3>> {CreatePolygonVertices(nSides, origin, Vector3.up, origin, false)};
        var centers = new List<Vector3> {origin};

        var facesQueue = new List<List<Vector3>> {faces[0]};
        var centersQueue = new List<Vector3> {centers[0]};

        while (true)
        {
            if (facesQueue.Count == 0)
            {
                break;
            }

            var face = facesQueue[0];
            var center = centersQueue[0];

            facesQueue.RemoveAt(0);
            centersQueue.RemoveAt(0);

            for (var i = 0; i < nSides; i++)
            {
                var a = face[i];
                var b = face[i == nSides - 1 ? 0 : i + 1];
                var dihedralAxis = b - a;
                var pivot = (b + a) / 2;
                var p = pivot - center;
                var nextCenter = pivot + p;
                var rotatedCenter = MathUtils.RotateVectorAroundAxis(nextCenter, a, b, supplementaryAngle);

                var centerAlreadyExists = false;

                centers.ForEach(existingCenter =>
                {    
                    if ((rotatedCenter - existingCenter).sqrMagnitude < 0.01)
                    {
                        centerAlreadyExists = true;
                    }
                });

                if (centerAlreadyExists)
                {
                    continue;
                }

                var normal = Vector3.Cross(p, dihedralAxis);
                var nextFace = CreatePolygonVertices(nSides, nextCenter, normal, a, true)
                    .ConvertAll(new Converter<Vector3, Vector3>(vertex => MathUtils.RotateVectorAroundAxis(vertex, a, b, supplementaryAngle)));

                faces.Add(nextFace);
                centers.Add(rotatedCenter);

                facesQueue.Add(nextFace);
                centersQueue.Add(rotatedCenter);
            }
        }

        var vertices = new List<Vector3>();
        var triangles = new List<int>();
        var c = -1;

        for (var i = 0; i < faces.Count; i++)
        {
            var face = faces[i];
            var center = centers[i];

            c++;
            vertices.Add(center);

            var centerVertexIndex = c;

            for (var j = 0; j < face.Count; j++)
            {
                var vertex = face[j];

                c++;
                vertices.Add(vertex);
                triangles.Add(centerVertexIndex);
                triangles.Add(c);
                triangles.Add(j == face.Count - 1 ? centerVertexIndex + 1 : c + 1);
            }
        }

        return new Mesh
        {
            vertices = vertices.ToArray(), 
            triangles = triangles.ToArray()
        };
    }
}