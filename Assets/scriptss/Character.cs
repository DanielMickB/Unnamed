using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    [Header("Stats")]
    public int level=1;
    public int maxhp=1;
    public int hp=0;
    //public int atk=2;
    public int def=1;
    public float movespd=1.0f;
    /**
    public KeyCode upButton = KeyCode.W;
    public KeyCode leftButton = KeyCode.A;
    public KeyCode downButton = KeyCode.S;
    public KeyCode rightButton = KeyCode.D;
    //public KeyCode bscatk= KeyCode.DownArrow;
    public KeyCode dashing = KeyCode.LeftShift;**/

    public enum CharState { selected, notselected }
    public CharState _state;
    public CharState State { get { return _state; } }//fungsi cek state dipanggil di scipt lain

    private Rigidbody char_rb;
    int floorMask;
    Vector3 movement;

    // Start is called before the first frame update
    void Start()
    {
        char_rb=GetComponent<Rigidbody>();
        hp=maxhp;
        floorMask = LayerMask.GetMask("floor");
    }
    public void takedamage(int totalatk){
        int dmg = totalatk-def;
        hp=hp-dmg;
        Debug.Log("current hp:"+hp);
    }
    public void walk(float h, float v){//dari player control
        //Set nilai x dan y
        movement.Set(h, 0f, v);//posisi awal
        
        //Menormalisasi nilai vector agar total panjang dari vector adalah 1
        movement = movement.normalized * movespd * Time.deltaTime;
        
        //Move to position
        char_rb.MovePosition(transform.position + movement);
        /**Vector3 velocity=char_rb.velocity;
        
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
        **/
        //Debug.Log("movementspeed :"+velocity);
        //Debug.Log("Char Location:"+transform.position);
    }
    
    
}
