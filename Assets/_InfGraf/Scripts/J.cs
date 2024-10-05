using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class J : MonoBehaviour
{
    [SerializeField] private Material _material;
    [SerializeField] private Transform[] corners;

    private Mesh mesh;
    private MeshFilter meshFilter;
    private MeshRenderer meshRenderer;


    void Start()
    {
        meshFilter = gameObject.AddComponent<MeshFilter>();
        meshRenderer = gameObject.AddComponent<MeshRenderer>();

        mesh = new Mesh();
        mesh.name = "Procedural Mesh";

        MeshData();

        meshFilter.mesh = mesh;
        meshRenderer.material = _material;

    }

    private void MeshData() // VertexData[]
    {
        mesh.vertices = new Vector3[]
        {
            new Vector3(-2.5f, 0, -1),  //indice 0
            new Vector3(-2.5f,-1,-1),   //indice 1
            new Vector3(-1.5f,-2,-1),    //indice 2
            new Vector3(1.5f,-2,-1),   //indice 3
            new Vector3(2.5f,-1,-1),   //indice 4
            new Vector3(2.5f,7,-1),   //indice 5
            new Vector3(1.5f,7,-1),   //indice 6
            new Vector3(1.5f,0,-1),   //indice 7
            new Vector3(1,-1,-1),   //indice 8
            new Vector3(-1,-1,-1),   //indice 9
            new Vector3(-1.5f,0,-1),   //indice 10

            //new Vector3(1,-1,1),  //indice 4
            //new Vector3(-1,-1,1),  //indice 5
            //new Vector3(-1,1,1),  //indice 6
            //new Vector3(1,1,1),  //indice 7
        };

        mesh.triangles = new int[]
        {
            0,10,1, // triangulo 1
            1,10,9,  // triangulo 2
            1,9,2,
            2,9,3,
            9,8,3,
            3,8,4,
            8,7,4,
            4,7,5,
            5,7,6
        };

        mesh.colors = new Color[]
        {
            Color.red,
            Color.green,
            Color.blue,
            Color.yellow,
            Color.red,
            Color.green,
            Color.blue,
            Color.blue,
            Color.blue,
            Color.blue,
            Color.yellow
        };

    }
}
