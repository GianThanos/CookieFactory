using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoteteSky : MonoBehaviour
{
    public float rotateSpeed = 0.1f;
    // Update is called once per frame
    void Update()
    {
        RenderSettings.skybox.SetFloat("_Rotation", Time.time * rotateSpeed);  
    }
}
