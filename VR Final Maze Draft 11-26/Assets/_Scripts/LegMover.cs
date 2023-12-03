using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LegMover : MonoBehaviour
{
    public InputActionReference legMoverReference = null;
    public GameObject legDetachedParent;
    public GameObject CameraOffset;

    //testing changing color
    private MeshRenderer meshRenderer = null;


    // Start is called before the first frame update
    void Start()
    {
        legMoverReference.action.performed += MoveLegs;
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void MoveLegs(InputAction.CallbackContext context)
    {
        meshRenderer.material.color = new Color(0, 0, 0);
        gameObject.transform.SetParent(legDetachedParent.transform.parent, false);
        gameObject.transform.position = legDetachedParent.transform.position;
    }
}
