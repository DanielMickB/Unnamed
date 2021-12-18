using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform[] target;
    float y_cam=1.0f;
    //public Transform target;
    public float smoothing = 5f;
    public int index_c=0;
    
    Vector3 offset;
    // Start is called before the first frame update
    private void Start()
    {
        //Mendapatkan offset antara target dan camera
        
        //Debug.Log("Target= "+target[1]);
        
        
    }
    public void InitialTarget(int index){//Ini perlu???
        index_c=index;
        offset = transform.position - target[index_c].position;
        SetTarget(index_c);
       // Debug.Log("Target= "+target[index_c]);
    }
    public void SetTarget(int index){
        index_c=index;//buat kalo nanti ganti target
       // Debug.Log("Camera= "+transform.position);
       // Debug.Log("offset= "+offset);
        transform.position=new Vector3(target[index_c].position.x,y_cam,target[index_c].position.z);
 
        //Debug.Log("Set Target= "+index_c);
    }
    public void SetCamera(int index){
        //Menapatkan posisi untuk camera
        Vector3 targetCamPos = target[index].position + offset;
        
        //set posisi camera dengan smoothing
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);

    }
    void FixedUpdate()
    {   
        //SetTarget(index_c);
        SetCamera(index_c);
       // Debug.Log("Camera= "+transform.position);
       // Debug.Log("offset= "+offset+"OFFSET MUST CONSTANT");
       
        //Menapatkan posisi untuk camera
       // Vector3 targetCamPos = target.position + offset;
        
        //set posisi camera dengan smoothing
       // transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
        
    }
    // Update is called once per frame
    
}
