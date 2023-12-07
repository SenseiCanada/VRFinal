using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaNotifier : MonoBehaviour
{
    public static Action<GameObject> OnFallInLava;


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
	OnFallInLava(other.gameObject);
    }
}
