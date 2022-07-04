
using UnityEngine;
using System.Collections;

public class Walk_FPS : MonoBehaviour
{
    public GameObject Player;
    private Rigidbody PlayerRigid;//PlayerオブジェクトのRigidbobyを保管する
    public float Upspeed;　　　　//ジャンプのスピード
    // Use this for initialization
    void Start()
    {
        //animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up") || Input.GetKey("w"))
        {
            if(Input.GetKey("r")){
                transform.position += transform.forward * 0.015f;
                
            }else{
                transform.position += transform.forward * 0.005f;
            }
            
        }
        else if(Input.GetKey("down") || Input.GetKey("s"))
        {
            transform.position -= transform.forward * 0.005f;
        }      
        else
        {
        }
        if (Input.GetKey("right") || Input.GetKey("d"))
        {
            if(Input.GetKey("r")){
                transform.position += transform.right * 0.015f;
                
            }else{
                transform.position += transform.right * 0.005f;
            }
        }
        if (Input.GetKey("left") || Input.GetKey("a"))
        {
            if(Input.GetKey("r")){
                transform.position += transform.right * -0.015f;
                
            }else{
                transform.position += transform.right * -0.005f;
            }
        }
    }



}
