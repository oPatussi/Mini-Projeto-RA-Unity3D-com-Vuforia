using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

        if(Input.GetAxisRaw("Horizontal") != 0)
        {
            transform.Translate(Input.GetAxisRaw("Horizontal") * 0.01f, 0f, 0f);
        }
        if (Input.GetAxisRaw("Jump") != 0)
        {
            transform.Translate(0f, 0f, Input.GetAxisRaw("Jump") * 0.01f);
        }
        if (Input.GetAxisRaw("Vertical") != 0)
        {
            transform.Translate(0f, Input.GetAxisRaw("Vertical") * 0.01f, 0f);
        }
        if (Input.GetAxisRaw("Fire1") != 0)
        {
            transform.Rotate(0f, 0f, Input.GetAxisRaw("Fire1")* 1f);
        }

    }


}
