using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudRain : MonoBehaviour
{
    public List<Transform> targets;
    public float height;
    public float speed;
    public GameObject drops;

    private int characterIndex = 0;
    private bool b_Move = false;
    private Transform target;
    
    void Start()
    {
        target = targets[0];
    }

    // Update is called once per frame
    void Update()
    {
        NextTarget();
        
    }
    void FixedUpdate() {
        FlyToTarget();
    }
    //смена цели по нажатию на пробел
    void NextTarget()
    {
        if (Input.GetKeyDown("z"))
        {

            target = targets[characterIndex];
            b_Move = true;
            characterIndex += 1;
        }
        if (characterIndex == targets.Count)
        {
            characterIndex = 0;
        }
    }
    //Летим к цели и поливаем когда над ней
    void FlyToTarget()
    {
        if (b_Move)
        {

            transform.position = Vector3.MoveTowards(transform.position,target.position + new Vector3(0, height, 0),speed*Time.fixedDeltaTime);
            drops.SetActive(false);

            if (transform.position == target.position + new Vector3(0, height, 0))
            {
                b_Move = false;
            }
        }

        else
        {
            drops.SetActive(true);
        }
    }

}
