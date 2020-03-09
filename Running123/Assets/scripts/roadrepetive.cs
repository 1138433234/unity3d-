using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roadrepetive : MonoBehaviour
{

    public GameObject currentRoad;   // 当前的路段
    public GameObject nextRoad;    // 下一个路段

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z<currentRoad.transform.position.z-120)     //  如果角色当前位置在下一个路段，则前一个路段移动到下一个路段位置之后
        {
            currentRoad.transform.position=new Vector3(0,0,nextRoad.transform.position.z-100);
            GameObject temp =currentRoad;
            currentRoad=nextRoad;
            nextRoad=temp;
        }
    }
}
