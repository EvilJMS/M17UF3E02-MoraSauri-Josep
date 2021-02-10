using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour
{
    public Vector3 point;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.A)){
            transform.Rotate (new Vector3 (0, 0, 20) * Time.deltaTime);
        } else if (Input.GetKey(KeyCode.D))
            transform.Rotate (new Vector3 (0, 0, -20) * Time.deltaTime);
        else if (Input.GetKey(KeyCode.W))
            transform.Rotate (new Vector3 (20, 0, 0) * Time.deltaTime);
        else if (Input.GetKey(KeyCode.S))
            transform.Rotate (new Vector3 (-20, 0, 0) * Time.deltaTime);
    }  
    }
