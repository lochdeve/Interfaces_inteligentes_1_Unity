using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class avion : MonoBehaviour
{
    // Start is called before the first frame update
    public int counter = 0;
    
    void Start()
    {      
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Id: 1 tag: " + gameObject.tag + " counter: " + counter);
        counter++; 
    }
}
