using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FloorCrusherMover : MonoBehaviour
{
    public GameObject topPoint; // The starting point
    public GameObject bottomPoint; // The ending point
    public Transform topTransform;
    public Transform bottomTransform;
    public float speed = 2f; // Speed of movement

    private Vector3 currentTarget;

    public static event Action<GameObject> OnCrusherCollide;
    // Start is called before the first frame update
    void Start()
    {
        topPoint = GameObject.Find("TopPoint");
        bottomPoint = GameObject.Find("BottomPoint");

        topTransform = topPoint.transform;
        bottomTransform = bottomPoint.transform;

        SetTarget(topTransform.position);
        
}

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, currentTarget, speed * Time.deltaTime);

        // If the platform reaches the target, set a new target
        if (Vector3.Distance(transform.position, currentTarget) < 0.01f)
        {
            if (currentTarget == topTransform.position)
                SetTarget(bottomTransform.position);
            else SetTarget(topTransform.position);

        }
    }

    void SetTarget(Vector3 newTarget)
    {
        currentTarget = newTarget;
    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("XRRig"))
        {
            OnCrusherCollide(other.gameObject);
        }
    }
}
