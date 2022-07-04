using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {
    public GameObject Player;
    private Rigidbody PlayerRigid;//PlayerオブジェクトのRigidbobyを保管する
    public float Upspeed;　　　　//ジャンプのスピード
    // Use this for initialization
    void Start () {
        PlayerRigid = Player.GetComponent<Rigidbody>();

    }
	
	// Update is called once per frame
	void Update () {

    }
    void OnCollisionStay(Collision col)
    {
        
        if (col.gameObject.tag == "Ground" && Input.GetKey("space")) //Groundと接触している、かつスペースキーが押されたとき
        {//地面についている時だけ飛べるようにする
            PlayerRigid.AddForce(transform.up * Upspeed);
 
 
 
        }
      
    }
}