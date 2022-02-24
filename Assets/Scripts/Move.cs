using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    public 
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        float v = Input.GetAxis("Vertical");
        float h = Input.GetAxis("Horizontal");
        Debug.Log("×ÝÏò£º"+v       +"   "+             "a "    + h);
            //translate
        transform.Translate(h * 10 * Time.deltaTime, v * 10 * Time.deltaTime, 0);
        
        
        
    }
}
