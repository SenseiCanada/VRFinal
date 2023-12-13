using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FloorCrusherMover : MonoBehaviour
{
    public List<Transform> points;
    public Transform platform;
    int goalPoint = 0;
    [SerializeField] float moveSpeed = 2;

    public static event Action<GameObject> OnCrusherCollide;

    private void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        MoveToNextPoint();
    }

    void MoveToNextPoint()
    {
        platform.position = Vector3.MoveTowards(platform.position, points[goalPoint].position, Time.deltaTime * moveSpeed);

        if (Vector3.Distance(platform.position, points[goalPoint].position) < 0.1f)
        {
            if (goalPoint == points.Count - 1)
            {
                goalPoint = 0;
                Debug.Log("Platform reached point" + goalPoint);
            }
            else
            {
                goalPoint++;
                Debug.Log("Platform reached point" + goalPoint);
            }
        }

    }

    

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("XRRig"))
        {
            OnCrusherCollide(other.gameObject);
        }
    }
}
