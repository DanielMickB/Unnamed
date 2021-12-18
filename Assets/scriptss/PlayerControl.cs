using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    int index=0;
    public CameraFollow cameraFollow;
    public Character[] _char;
    public KeyCode changePrev = KeyCode.Q;
    public KeyCode upButton = KeyCode.W;
    public KeyCode leftButton = KeyCode.A;
    public KeyCode downButton = KeyCode.S;
    public KeyCode rightButton = KeyCode.D;
    //public KeyCode bscatk= KeyCode.DownArrow;
    public KeyCode dashing = KeyCode.LeftShift;

    
    //private Character UseChar;
    // Start is called before the first frame update
    void Start()
    {
        cameraFollow.InitialTarget(index);
        //Debug.Log("FROM PLAYERCONTROL");
    }

    // Update is called once per frame
    void Update()
    {
        
        
        //_char[index].walk();
        
       
        
    }
    // Update is called once per frame
    private void FixedUpdate()
    {
        float h=0;
        float v=0;
        if(Input.GetKeyDown(changePrev)){
            //ganti karakter

            if(index>=1){
                index=0;
            }else{
                index++;  
            }
            cameraFollow.SetTarget(index);
            //Debug.Log(" change CHar: "+index);
            
        }
        if(Input.GetKey(upButton)||Input.GetKey(downButton)||Input.GetKey(leftButton)||Input.GetKey(rightButton)){
            Debug.Log(" movement button");
            h = Input.GetAxisRaw("Horizontal");
            v = Input.GetAxisRaw("Vertical");
        }
        
        
        //Mendapatkan nilai input vertical (-1,0,1)
       
        Debug.Log(" Current CHar: "+index);
        _char[index].walk(h, v);//gerak karakter
      
    }
}
