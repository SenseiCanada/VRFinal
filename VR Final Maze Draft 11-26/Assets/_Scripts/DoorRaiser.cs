using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorRaiser : MonoBehaviour
{
    private float doorHeight;
    private float newDoorHeight;
    public Transform topPoint;

    // Start is called before the first frame update
    void Start()
    {
        PlatformTrigger.platformTriggered += RaiseDoor;
        doorHeight = gameObject.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void RaiseDoor()
    {

        transform.position =  new Vector3(0,3,0);
//Vector3.MoveTowards(gameObject.transform.position, topPoint.position, 20f);
        //doorHeight = doorHeight + 15;
    }
}
