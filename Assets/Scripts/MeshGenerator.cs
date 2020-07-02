using UnityEngine;

[ExecuteInEditMode]
public class MeshGenerator : MonoBehaviour
{
    [SerializeField]
    private MeshFilter filter;

    [SerializeField]
    private Vector3[] vertices =
    {
        new Vector3(-.5f, 0, -.5f),
        new Vector3(-.5f, 0, .5f),
        new Vector3(.5f, 0, -.5f),
        new Vector3(.5f, 0, .5f)
    };

    [SerializeField]
    Color[] colors = {Color.black, Color.blue, Color.red, Color.yellow};

    [SerializeField]
    private int[] triangles = {0, 1, 2, 1, 3, 2};

    [SerializeField]
    private Vector2[] uv =
    {
        new Vector2(-.5f, -.5f),
        new Vector2(-.5f, .5f),
        new Vector2(.5f, -.5f),
        new Vector2(.5f, .5f)
    };

    [SerializeField]
    private float testVerticalVerticeCero = 0;

    private Mesh mesh;


    private void OnValidate()
    {
        if (null == filter)
        {
            filter = GetComponent<MeshFilter>();
        }

        vertices[0] = new Vector3(vertices[0].x, testVerticalVerticeCero, vertices[0].z);

        CreateMesh();
    }


    public void CreateMesh()
    {
        if (null != mesh)
            mesh.Clear();
        else
        {
            mesh = new Mesh();
            filter.mesh = mesh;
        }

        mesh.vertices = vertices;
        mesh.triangles = triangles;
        mesh.colors = colors;
        mesh.uv = uv;

        mesh.RecalculateNormals();
    }
}