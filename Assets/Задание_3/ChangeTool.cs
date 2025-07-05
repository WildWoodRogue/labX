using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTool : MonoBehaviour
{
    public GameObject tool;
    public List<GameObject> tools;
    private Vector3 startPos;
    private Quaternion startRot;

    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Change();
        }
    }
    void Change()
    {   
        startPos = tool.transform.position;
        startRot = tool.transform.rotation;
        Destroy(tool);
        tool = null;
        int rand = Random.Range(0, tools.Count);

        tool = Instantiate(tools[rand], startPos,startRot,transform);
        

    }
}
