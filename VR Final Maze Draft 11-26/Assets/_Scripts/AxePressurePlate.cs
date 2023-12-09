using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AxePressurePlate : MonoBehaviour
{
    public static event Action OnAxePressurePlateActivated;
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
            OnAxePressurePlateActivated();
        }
        
    }
}
