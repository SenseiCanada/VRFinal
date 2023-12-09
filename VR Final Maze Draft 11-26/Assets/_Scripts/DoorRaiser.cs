using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorRaiser : MonoBehaviour
{
    private float doorHeight;
    //private float newDoorHeight;
    //public GameObject topPointObj;
    public AudioSource audioData;

    // Start is called before the first frame update
    void Start()
    {
        //topPointObj = GameObject.FindGameObjectWithTag("Door Top");
        PlatformTrigger.PlatformTriggered += RaiseDoor;
        //Transform topPointTransform = topPointObj.transform;
        doorHeight = gameObject.transform.position.y;
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void RaiseDoor()
    {
        Debug.Log("Raise door triggered");
        //audioData = GetComponent<AudioSource>();
	    //audioData.Play(0);
        transform.position =  new Vector3(0,5,0);
        //Vector3.MoveTowards(gameObject.transform.position, topPointTransform.position, 20f);
        doorHeight = doorHeight + 15;
    }
}
