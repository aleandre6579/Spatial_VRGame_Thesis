using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.Serialization;
using System;

public class SimplifyMesh : MonoBehaviour
{

    public float quality = 0.5f;

    void OnGUI()
    {
        if(GUI.Button(Rect.MinMaxRect(0, 0, 200, 200), "Simplify Mesh"))
        {
            var originalMesh = GetComponent<MeshFilter>().sharedMesh;
            if (!originalMesh.isReadable) return;
            Debug.Log("a");
            var meshSimplifier = new UnityMeshSimplifier.MeshSimplifier();
            meshSimplifier.Initialize(originalMesh);
            meshSimplifier.SimplifyMesh(quality);
            var destMesh = meshSimplifier.ToMesh();
            GetComponent<MeshFilter>().sharedMesh = destMesh;
        }
    }



}
