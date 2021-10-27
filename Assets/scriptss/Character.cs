using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [Header("Stats")]
    public int level=1;
    public int hp=1;


    [Header("Movement")]
    public float movespd=1.0f;
    
    public KeyCode upButton = KeyCode.W;
    public KeyCode leftButton = KeyCode.A;
    public KeyCode downButton = KeyCode.S;
    public KeyCode rightButton = KeyCode.D;
    public KeyCode dashing = KeyCode.LeftShift;

    public enum CharState { selected, notselected }
    public CharState _state;
    public CharState State { get { return _state; } }//fungsi cek state dipanggil di scipt lain

    private Rigidbody char_rb;

    // Start is called before the first frame update
    void Start()
    {
        char_rb=GetComponent<Rigidbody>();
    }
    public void walk(){
        Vector3 velocity=char_rb.velocity;
        
        if(Input.GetKey(upButton)){
            velocity.z=movespd;
        }
        if(Input.GetKey(downButton)){
            velocity.z=-movespd;
        }
        if(Input.GetKey(rightButton)){
            velocity.x=movespd;
        }
        if(Input.GetKey(leftButton)){
            velocity.x=-movespd;
        }
        if(Input.GetKey(0)){
            velocity.z=0.0f;
            velocity.x=0.0f;
            
        }        
        
        char_rb.velocity=velocity;
        //Debug.Log("movementspeed :"+velocity);
        Debug.Log("Char Location:"+transform.position);
    }
    // Update is called once per frame
    void Update()
    {
      
    }
}
