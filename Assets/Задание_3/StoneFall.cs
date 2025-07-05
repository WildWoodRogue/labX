using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneFall : MonoBehaviour
{
    public GameObject stone;
    public Transform hillPosition;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("x"))
        {
            Instantiate(stone,hillPosition.position,new Quaternion(0,0,0,0) );
        }
    }
}
