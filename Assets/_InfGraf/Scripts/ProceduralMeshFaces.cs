using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProceduralMeshFaces : MonoBehaviour
{
    [SerializeField] private Material _material;
    [SerializeField] private Transform[] faces;

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
        UpdateVertex();

        mesh.triangles = new int[]
        {
            //Cara Trasera
            0, 2, 1,  // triangulo 1
            0, 3, 2,  // triangulo 2

            //Cara Lateral Izquierdo
            4, 6, 5,  // triangulo 4
            4, 7, 6,  // triangulo 3

            //Cara Frontal
            8, 10, 9,  // triangulo 6
            8, 11, 10,  // triangulo 5

            //Cara Lateral Derecho
            12, 14, 13,  // triangulo 8
            12, 15, 14,  // triangulo 7

            //Cara Superior
            16, 18, 17,  // triangulo 10
            16, 19, 18,  // triangulo 9

            //Cara Inferior
            20, 22, 21,  // triangulo 12
            20, 23, 22,  // triangulo 11
        };

        mesh.uv = new Vector2[]
        {
            //Cara Trasera
            new Vector2(0,0), //indice 0
            new Vector2(1,0), //indice 1
            new Vector2(1,1), //indice 2
            new Vector2(0,1), //indice 3
        
            //Cara Lateral izquierdo
            new Vector2(0,0), //indice 4
            new Vector2(1,0), //indice 5
            new Vector2(1,1), //indice 6
            new Vector2(0,1), //indice 7

            //Cara Frontal
            new Vector2(0,0), //indice 4
            new Vector2(1,0), //indice 5
            new Vector2(1,1), //indice 6
            new Vector2(0,1), //indice 7

            //Cara Lateral Derecho
            new Vector2(0,0), //indice 4
            new Vector2(1,0), //indice 5
            new Vector2(1,1), //indice 6
            new Vector2(0,1), //indice 7

            //Cara Superior
            new Vector2(0,1), //indice 4
            new Vector2(0,0), //indice 5
            new Vector2(1,0), //indice 6
            new Vector2(1,1), //indice 7

            //Cara Inferior
            new Vector2(1,0), //indice 4
            new Vector2(1,1), //indice 5
            new Vector2(0,1), //indice 6
            new Vector2(0,0), //indice 7
        
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
            Color.blue,
            Color.green,
            Color.yellow,
            Color.red,

           //Cara Lateral Izquierd
            Color.green,
            Color.white,
            Color.black,
            Color.yellow,
            
            //Cara Frontal
            Color.white,
            Color.magenta,
            Color.grey,
            Color.black,
            
            //Cara Lateral Derechas
            Color.magenta,
            Color.blue,
            Color.red,
            Color.grey,
            
            //Cara superior
            Color.grey,
            Color.red,
            Color.yellow,
            Color.black,
            
            //Cara inferior
            Color.white,
            Color.green,
            Color.blue,
            Color.magenta,
        };

    }

    private void UpdateVertex()
    {
        mesh.vertices = new Vector3[]
        {
            //Cara Trasera
            new Vector3(faces[3].localPosition.x,faces[5].localPosition.y,faces[1].localPosition.z),  //indice 0
            new Vector3(faces[2].localPosition.x,faces[5].localPosition.y,faces[1].localPosition.z),  //indice 1
            new Vector3(faces[2].localPosition.x,faces[4].localPosition.y,faces[1].localPosition.z),  //indice 2
            new Vector3(faces[3].localPosition.x,faces[4].localPosition.y,faces[1].localPosition.z),  //indice 3

            //Cara lateral Izquierda
            new Vector3(faces[2].localPosition.x,faces[5].localPosition.y,faces[1].localPosition.z),  //indice 1 || 4
            new Vector3(faces[2].localPosition.x,faces[5].localPosition.y,faces[0].localPosition.z),  //indice 4 || 5
            new Vector3(faces[2].localPosition.x,faces[4].localPosition.y,faces[0].localPosition.z),  //indice 7 || 6
            new Vector3(faces[2].localPosition.x,faces[4].localPosition.y,faces[1].localPosition.z),  //indice 2 || 7

            //Cara Frontal
            new Vector3(faces[2].localPosition.x,faces[5].localPosition.y,faces[0].localPosition.z),  //indice 4 || 8
            new Vector3(faces[3].localPosition.x,faces[5].localPosition.y,faces[0].localPosition.z),  //indice 5 || 9
            new Vector3(faces[3].localPosition.x,faces[4].localPosition.y,faces[0].localPosition.z),  //indice 6 || 10
            new Vector3(faces[2].localPosition.x,faces[4].localPosition.y,faces[0].localPosition.z),  //indice 7 || 11
                                                                                                                       
            //Cara lateral Derecha                                                                                     
            new Vector3(faces[3].localPosition.x,faces[5].localPosition.y,faces[0].localPosition.z),  //indice 5 || 12
            new Vector3(faces[3].localPosition.x,faces[5].localPosition.y,faces[1].localPosition.z),  //indice 0 || 13
            new Vector3(faces[3].localPosition.x,faces[4].localPosition.y,faces[1].localPosition.z),  //indice 3 || 14
            new Vector3(faces[3].localPosition.x,faces[4].localPosition.y,faces[0].localPosition.z),  //indice 6 || 15
            
            //Cara superior
            new Vector3(faces[3].localPosition.x,faces[4].localPosition.y,faces[0].localPosition.z),  //indice 6 || 16
            new Vector3(faces[3].localPosition.x,faces[4].localPosition.y,faces[1].localPosition.z),  //indice 3 || 17
            new Vector3(faces[2].localPosition.x,faces[4].localPosition.y,faces[1].localPosition.z),  //indice 2 || 18
            new Vector3(faces[2].localPosition.x,faces[4].localPosition.y,faces[0].localPosition.z),  //indice 7 || 19
                                                                                                                      
            //Cara inferior                                                                                           
            new Vector3(faces[2].localPosition.x,faces[5].localPosition.y,faces[0].localPosition.z),  //indice 4 || 20
            new Vector3(faces[2].localPosition.x,faces[5].localPosition.y,faces[1].localPosition.z),  //indice 1 || 21
            new Vector3(faces[3].localPosition.x,faces[5].localPosition.y,faces[1].localPosition.z),  //indice 0 || 22
            new Vector3(faces[3].localPosition.x,faces[5].localPosition.y,faces[0].localPosition.z),  //indice 5 || 23
        };
    }

    void Update()
    {
        UpdateVertex();
    }
}
