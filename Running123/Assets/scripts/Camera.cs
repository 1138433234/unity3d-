using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public GameObject Targect;//跟踪的对象
    public float height;// 相机距离人物的高度
    public float distance;  //相机距离人物的距离
    Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        pos=transform.position;//获取当前相机的位置
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }

    void LateUpdate()
    {
        pos.x=Mathf.Lerp(pos.x,Targect.transform.position.x,Time.deltaTime);
        pos.y=Mathf.Lerp(pos.y,Targect.transform.position.y+height,Time.deltaTime);
        pos.z=Mathf.Lerp(pos.z,Targect.transform.position.z-distance,Time.deltaTime);
        transform.position=pos;
    }
}
