using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorControl : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim=GetComponent<Animator>();   //获取 Animator 组件
    }

    // Update is called once per frame
    void Update()
    {
        // AnimatorStateInfo starteInfo=anim.GetCurrentAnimatorStateInfo(0);
        if (Input.GetKeyDown (KeyCode.W))
        {
            anim.SetTrigger("Jumptrigger");      //实现跳跃
            
            
        }
       
       
        if (Input.GetKeyDown (KeyCode.S))
        {
           anim.SetTrigger("Divetrigger");   //实现dive
        }
        


      
    }
}
