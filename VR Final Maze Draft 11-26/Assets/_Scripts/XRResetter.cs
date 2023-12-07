using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class XRResetter : MonoBehaviour
{
    [SerializeField]
    Vector3 startPosition;
    public bool ResetEntireScene;


    // Start is called before the first frame update
    void Start()
    {
        LavaNotifier.OnFallInLava += ResetPosition;
        LavaNotifier.OnFallInLava += ResetScene;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ResetPosition(GameObject xrRig)
    {
	if (xrRig.name.Contains("XR Origin Default"))
	{
        	SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}
//        transform.position = startPosition;
    }

    private void ResetScene(GameObject xrRig)
    {
        if (ResetEntireScene)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        
    }
}
