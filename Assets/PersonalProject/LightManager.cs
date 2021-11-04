using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightManager : MonoBehaviour
{
    [SerializeField]
    private Light directionalLight;

    [SerializeField]
    private LightPreset preset;

    [SerializeField, Range(0,24)]
    private float timeOfDay;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
