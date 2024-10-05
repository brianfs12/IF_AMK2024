using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralMesh : MonoBehaviour
{
    [SerializeField] private Material _material;
    [SerializeField] private Transform[] corners;

    private Mesh mesh;
    private MeshFilter meshFilter;
    private MeshRenderer meshRenderer;


    private void Start()
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
        UpdateVertex();

        mesh.triangles = new int[]
        {
            //Cara Trasera
            0, 2, 1, // triangulo 1
            0, 3, 2, // triangulo 2

            //Cara Lateral Izquierdo
            4, 6, 5, // triangulo 4
            4, 7, 6, // triangulo 3

            //Cara Frontal
            8, 10, 9, // triangulo 6
            8, 11, 10, // triangulo 5

            //Cara Lateral Derecho
            12, 14, 13, // triangulo 8
            12, 15, 14, // triangulo 7

            //Cara Superior
            16, 18, 17, // triangulo 10
            16, 19, 18, // triangulo 9

            //Cara Inferior
            20, 22, 21, // triangulo 12
            20, 23, 22, // triangulo 11
        };

        mesh.uv = new Vector2[]
        {
            //Cara Trasera
            new Vector2(0, 0), //indice 0
            new Vector2(1, 0), //indice 1
            new Vector2(1, 1), //indice 2
            new Vector2(0, 1), //indice 3

            //Cara Lateral izquierdo
            new Vector2(0, 0), //indice 4
            new Vector2(1, 0), //indice 5
            new Vector2(1, 1), //indice 6
            new Vector2(0, 1), //indice 7

            //Cara Frontal
            new Vector2(0, 0), //indice 4
            new Vector2(1, 0), //indice 5
            new Vector2(1, 1), //indice 6
            new Vector2(0, 1), //indice 7

            //Cara Lateral Derecho
            new Vector2(0, 0), //indice 4
            new Vector2(1, 0), //indice 5
            new Vector2(1, 1), //indice 6
            new Vector2(0, 1), //indice 7

            //Cara Superior
            new Vector2(0, 1), //indice 4
            new Vector2(0, 0), //indice 5
            new Vector2(1, 0), //indice 6
            new Vector2(1, 1), //indice 7

            //Cara Inferior
            new Vector2(1, 0), //indice 4
            new Vector2(1, 1), //indice 5
            new Vector2(0, 1), //indice 6
            new Vector2(0, 0), //indice 7

        };

        mesh.normals = new Vector3[]
        {
            Vector3.back,
            Vector3.back,
            Vector3.back,
            Vector3.back,

            Vector3.right,
            Vector3.right,
            Vector3.right,
            Vector3.right,

            Vector3.forward,
            Vector3.forward,
            Vector3.forward,
            Vector3.forward,

            Vector3.left,
            Vector3.left,
            Vector3.left,
            Vector3.left,

            Vector3.up,
            Vector3.up,
            Vector3.up,
            Vector3.up,

            Vector3.down,
            Vector3.down,
            Vector3.down,
            Vector3.down,


        };

        mesh.colors = new Color[]
        {
            //Cara Trasera
            Color.black,
            Color.red,
            Color.yellow,
            Color.green,

            //Cara Lateral Izquierda
            Color.red,
            Color.magenta,
            Color.white,
            Color.yellow,

            //Cara Frontal
            Color.magenta,
            Color.blue,
            Color.cyan,
            Color.white,
            
            //Cara Lateral Derecha
            Color.blue,
            Color.black,
            Color.green,
            Color.cyan,

            //Cara superior
            Color.cyan,
            Color.green,
            Color.yellow,
            Color.white,

            //Cara inferior
            Color.magenta,
            Color.red,
            Color.black,
            Color.blue,
        };
    }

    private void UpdateVertex()
    {
        mesh.vertices = new Vector3[]
            //Cara Trasera
        {
            new Vector3(corners[0].localPosition.x,corners[0].localPosition.y,corners[0].localPosition.z),  //indice 0
            new Vector3(corners[1].localPosition.x,corners[1].localPosition.y,corners[1].localPosition.z),  //indice 1
            new Vector3(corners[2].localPosition.x,corners[2].localPosition.y,corners[2].localPosition.z),  //indice 2
            new Vector3(corners[3].localPosition.x,corners[3].localPosition.y,corners[3].localPosition.z),  //indice 3

            //Cara lateral Izquierda
            new Vector3(corners[1].localPosition.x,corners[1].localPosition.y,corners[1].localPosition.z),  //indice 1 || 4
            new Vector3(corners[4].localPosition.x,corners[4].localPosition.y,corners[4].localPosition.z),  //indice 4 || 5
            new Vector3(corners[7].localPosition.x,corners[7].localPosition.y,corners[7].localPosition.z),  //indice 7 || 6
            new Vector3(corners[2].localPosition.x,corners[2].localPosition.y,corners[2].localPosition.z),  //indice 2 || 7

            new Vector3(corners[4].localPosition.x,corners[4].localPosition.y,corners[4].localPosition.z),  //indice 4 || 8
            new Vector3(corners[5].localPosition.x,corners[5].localPosition.y,corners[5].localPosition.z),  //indice 5 || 9
            new Vector3(corners[6].localPosition.x,corners[6].localPosition.y,corners[6].localPosition.z),  //indice 6 || 10
            new Vector3(corners[7].localPosition.x,corners[7].localPosition.y,corners[7].localPosition.z),  //indice 7 || 11
                                                                                                                       
            //Cara lateral Derecha                                                                                     
            new Vector3(corners[5].localPosition.x,corners[5].localPosition.y,corners[5].localPosition.z),  //indice 5 || 12
            new Vector3(corners[0].localPosition.x,corners[0].localPosition.y,corners[0].localPosition.z),  //indice 0 || 13
            new Vector3(corners[3].localPosition.x,corners[3].localPosition.y,corners[3].localPosition.z),  //indice 3 || 14
            new Vector3(corners[6].localPosition.x,corners[6].localPosition.y,corners[6].localPosition.z),  //indice 6 || 15
            
            //Cara superior
            new Vector3(corners[6].localPosition.x,corners[6].localPosition.y,corners[6].localPosition.z),  //indice 6 || 16
            new Vector3(corners[3].localPosition.x,corners[3].localPosition.y,corners[3].localPosition.z),  //indice 3 || 17
            new Vector3(corners[2].localPosition.x,corners[2].localPosition.y,corners[2].localPosition.z),  //indice 2 || 18
            new Vector3(corners[7].localPosition.x,corners[7].localPosition.y,corners[7].localPosition.z),  //indice 7 || 19
                                                                                                                      
            //Cara inferior                                                                                           
            new Vector3(corners[4].localPosition.x,corners[4].localPosition.y,corners[4].localPosition.z),  //indice 4 || 20
            new Vector3(corners[1].localPosition.x,corners[1].localPosition.y,corners[1].localPosition.z),  //indice 1 || 21
            new Vector3(corners[0].localPosition.x,corners[0].localPosition.y,corners[0].localPosition.z),  //indice 0 || 22
            new Vector3(corners[5].localPosition.x,corners[5].localPosition.y,corners[5].localPosition.z),  //indice 5 || 23
        };
    }

    void Update()
    {
        UpdateVertex();
    }
}
