using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugListener : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlatformTrigger.PlatformTriggered += PrintTriggerMessage;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void PrintTriggerMessage()
    {
        Debug.Log("Platform was triggered");
    }
}
