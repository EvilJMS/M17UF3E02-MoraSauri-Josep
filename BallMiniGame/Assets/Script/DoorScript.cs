using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public int monedas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        monedas = PlayerPrefs.GetInt("monedas");
        if (monedas == 4)
        {
            Destroy(this.gameObject);
        }
        else
        {
            this.enabled = true;
        }

        {
            
        }
    }
}
