using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TerrainGenerator : MonoBehaviour
{
    [SerializeField] int Width = 50;
    [SerializeField] int Height = 50;

    [SerializeField] float perlinFrequencyX = 0.1f;
    [SerializeField] float perlinFrequencyZ = 0.1f;
    [SerializeField] float perlinNoiseStrength = 7f;

    enum TerrainStyle
    {
        TerrainColour,
        BlackToWhite,
        WhiteToBlack,
    }

    [SerializeField] TerrainStyle terrainStyle;

    Gradient TerrainGradient;
    Gradient BlackToWhiteGradient;
    Gradient WhiteToBlackGradient;

    Vector3[] vertices;
    int[] tris;
    Vector2[] uvs;
    Color[] colours;

    Mesh mesh;
    MeshFilter meshFilter;
    MeshRenderer meshRenderer;
    NavMeshSurface navMeshSurface;
    MeshCollider meshCollider;

    float minHeight = 0;
    float maxHeight = 0;


    private void Start()
    {
        mesh = new Mesh();
        mesh.name = "Procedural Terrain";
        meshFilter = GetComponent<MeshFilter>();
        meshFilter.mesh = mesh;

        meshRenderer = GetComponent<MeshRenderer>();
        Material mat = new Material(Shader.Find("Particles/Standard Unlit"));
        meshRenderer.material = mat;

    }


}
