
using UnityEngine;
using System.Collections;

public class Walk : MonoBehaviour
{

    private Animator animator;
    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up") || Input.GetKey("w"))
        {
            if(Input.GetKey("r")){
                if(Input.GetKey("space")){
                    transform.position += transform.forward * 0.015f;
                    animator.SetBool("is_running", false);
                    animator.SetBool("is_walking", false);
                    animator.SetBool("is_jumping", true);
                    Debug.Log("a");
                }else{
                    transform.position += transform.forward * 0.015f;
                    animator.SetBool("is_running", true);
                    animator.SetBool("is_walking", false);
                    animator.SetBool("is_jumping", false);
                }
                
            }else{
                if(Input.GetKey("space")){
                    transform.position += transform.forward * 0.005f;
                    animator.SetBool("is_running", false);
                    animator.SetBool("is_walking", false);
                    animator.SetBool("is_jumping", true);
                }else{
                    transform.position += transform.forward * 0.005f;
                    animator.SetBool("is_running", false);
                    animator.SetBool("is_walking", true);
                    animator.SetBool("is_jumping", false);
                }
            }
            
        }
        else if(Input.GetKey("down") || Input.GetKey("s"))
        {
            transform.position -= transform.forward * 0.005f;
            animator.SetBool("is_walking", true);
        }else if(Input.GetKey("space")){
                    animator.SetBool("is_running", false);
                    animator.SetBool("is_walking", false);
                    animator.SetBool("is_jumping", true);
                }
            
        else
        {
            animator.SetBool("is_walking", false);
            animator.SetBool("is_running", false);
            animator.SetBool("is_jumping", false);
        }
        if (Input.GetKey("right") || Input.GetKey("d"))
        {
            transform.Rotate(0, 0.2f, 0);
        }
        if (Input.GetKey("left") || Input.GetKey("a"))
        {
            transform.Rotate(0, -0.2f, 0);
        }
    }



}
