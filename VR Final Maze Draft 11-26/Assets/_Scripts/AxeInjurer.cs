using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeInjurer : MonoBehaviour
{
    public static event Action OnAxeCollide;
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
            OnAxeCollide();
        }
    }
}
