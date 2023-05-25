using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptimizeAllMeshes : MonoBehaviour
{


    private void Start()
    {
        int i = 0;
        foreach(OptimizeMesh optimizerScript in FindObjectsByType<OptimizeMesh>(FindObjectsSortMode.None))
        {
            if(i == 100000)
                break;

            optimizerScript.DecimateMesh();
        }
    }






}
