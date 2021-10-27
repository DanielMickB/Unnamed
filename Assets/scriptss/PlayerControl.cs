using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    int index=0;
    public CameraFollow cameraFollow;
    public Character[] _char;
    public KeyCode changePrev = KeyCode.Q;
    //private Character UseChar;
    // Start is called before the first frame update
    void Start()
    {
        cameraFollow.InitialTarget(index);
        Debug.Log("FROM PLAYERCONTROL");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(changePrev)){
            //ganti karakter

            if(index>=1){
                index=0;
            }else{
                index++;  
            }
            cameraFollow.SetTarget(index);
            Debug.Log(" Current CHar: "+index);
            
        }
        
        _char[index].walk();
        
       
        
    }
}
