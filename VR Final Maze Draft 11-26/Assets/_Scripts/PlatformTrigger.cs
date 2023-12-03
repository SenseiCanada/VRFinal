using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System;

public class PlatformTrigger : MonoBehaviour
{
    public static event Action platformTriggered;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("XRRig"))
        {
            platformTriggered?.Invoke();
        }
    }
}
