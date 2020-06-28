using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderController : MonoBehaviour
{
    public float saturation = 1;
    public float value = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shader.SetGlobalFloat("AlbedoSaturation", saturation);
        Shader.SetGlobalFloat("LightingSaturation", saturation);
        Shader.SetGlobalFloat("AlbedoValue", value);
        
    }
}
