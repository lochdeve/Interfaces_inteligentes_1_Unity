using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    // Start is called before the first frame update
    public int counter = 0;
    
    void Start()
    {      
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Id: 2 Tag: " + gameObject.tag + " counter: " + counter);
        counter++;
    }
}
