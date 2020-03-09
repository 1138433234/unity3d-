using UnityEngine;
using System.Collections;

public class IdleRunJump : MonoBehaviour {

	public float Speed=10.0f;

	// private Animator anim;
	// float inputSpeed=0f;

	// int speedHash=Animator.StringToHash("Speed");
	// int jumpHash=Animator.StringToHash("jump");
	void Start () 
	{
		// anim=GetComponent<Animator>();// 获取animator 组件
	}
		
	// Update is called once per frame
	void Update () 
	{

		// if (anim)
		// {
		// 	float v_Input=Input.GetAxis("Vertical");
		// 	anim.SetFloat("float",v_Input);
		// }
		
		
		transform.Translate(new Vector3(0,0,-Speed*Time.deltaTime));
		
	}
}
