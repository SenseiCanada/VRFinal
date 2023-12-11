using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxePressurePlate : MonoBehaviour
{
    public static event Action OnAxePressurePlateActivated;
    // Start is called before the first frame update
    void Start()
    {
        //DontDestroyOnLoad(this.gameObject);
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
            Debug.Log("Player collided with axe plate");
        }
        
    }
}
