using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    public Material red;
    public Material green;

    public Renderer cubeRenderer;

    private bool isRed = true;
    void Start()
    {
        cubeRenderer = GetComponent<Renderer>();
        cubeRenderer.material = red;
    }

    public void Interchage(){
        if(isRed){
            cubeRenderer.material = green;
        }else{
            cubeRenderer.material = red;
        }
        isRed = !isRed;
    }

}
