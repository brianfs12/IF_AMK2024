using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralSkybox : MonoBehaviour
{
    [SerializeField] private Material _material;

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
            new Vector3(-10,-10,-10),  //indice 0
            new Vector3(10,-10,-10),   //indice 1
            new Vector3(10,10,-10),    //indice 2
            new Vector3(-10,10,-10),   //indice 3

            new Vector3(10,-10,10),  //indice 4
            new Vector3(-10,-10,10),  //indice 5
            new Vector3(-10,10,10),  //indice 6
            new Vector3(10,10,10),  //indice 7
        };

        mesh.triangles = new int[]
        {
            0,2,3, // triangulo 1
            0,1,2,  // triangulo 2
            1,4,7,
            1,7,2,
            4,5,6,
            4,6,7,
            5,0,3,
            5,3,6,
            3,7,6,
            3,2,7,
            0,5,4,
            0,4,1,
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
            Color.yellow
        };

    }

    void Update()
    {
        
    }
}
