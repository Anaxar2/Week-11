using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class PostEffects : MonoBehaviour
{
    [SerializeField] private Volume cubeProcessing;

    private Bloom _bloom;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    public void changeCube()
    {
        cubeProcessing.priority = 1;
        cubeProcessing.weight = 1;
    }
}
