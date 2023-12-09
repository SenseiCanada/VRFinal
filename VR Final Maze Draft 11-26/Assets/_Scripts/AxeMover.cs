using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AxeMover : MonoBehaviour
{
    public Rigidbody axeRB;
    public GameObject pivot;
    [SerializeField] float axeSpeed;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        axeRB = GetComponent<Rigidbody>();
        //axeRB.mass = 0f;
        AxePressurePlate.OnAxePressurePlateActivated += ActivateAxe;


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ActivateAxe()
    {
        axeRB.constraints = RigidbodyConstraints.None;
        //transform.RotateAround(pivot.transform.position, Vector3.down, axeSpeed * Time.deltaTime);
        //axeRB.mass = 50f;
        Debug.Log("Axe was activated");
    }
}
