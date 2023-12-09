using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeMover : MonoBehaviour
{
    public Rigidbody axeRB;

    // Start is called before the first frame update
    void Start()
    {
        axeRB = GetComponent<Rigidbody>();
        axeRB.mass = 0f;
        AxePressurePlate.OnAxePressurePlateActivated += ActivateAxe;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ActivateAxe()
    {
        axeRB.mass = 50f;
    }
}
