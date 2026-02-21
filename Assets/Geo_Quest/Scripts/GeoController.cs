using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeoController : MonoBehaviour
{
    // Start is called before the first frame update
    string variable1 = "My ";
    private int aNumber = 3;
    void Start()
    {
        string variable2 = "First ";
        string variable3 = "Script";
        Debug.Log(variable1 + variable2 + variable3);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(aNumber++);

        if (Input.GetKeyDown(KeyCode.W) || (Input.GetKeyUp(KeyCode.W)))
        {
            transform.position += new Vector3(0, 1f, 0);
        }
        
        if (Input.GetKeyUp(KeyCode.A))
        {
            transform.position += new Vector3(-1f, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.position += new Vector3(0, -1f, 0);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.position += new Vector3(1f, 0, 0);
        }
    }
}
