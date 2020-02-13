using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceToStart : MonoBehaviour
{
    public HingeJoint hinge1;
    public HingeJoint hinge2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //hinge joint trigger
            hinge1.useLimits = false;
            hinge2.useLimits = false;

            
        }
    }
}
