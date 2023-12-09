using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using System;

public class PlatformTrigger : MonoBehaviour
{
    public static event Action PlatformTriggered;
    
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("XRRig"))
        {
            PlatformTriggered();
            Debug.Log("Player Triggered Platform");
        }
    }
}
