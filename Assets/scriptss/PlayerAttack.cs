using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    private float bscatk_cd;
    public float bscatk_strt;

    public Transform atkPos;
    public LayerMask destroy_able;
    public float atk_range;
    public int dmg;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(bscatk_cd<=0){
            
            if(Input.GetKey(KeyCode.DownArrow)){
                Debug.Log("Atk done");
                //Collider2D[] enemyToatk =Physics2D.OverlapCircleAll(atkPos.position,atk_range,destroy_able);// cant atk enemy because this
                Collider[] enemyToatk =Physics.OverlapSphere(atkPos.position,atk_range,destroy_able);
                //Debug.Log("Atk done?");
                for(int x=0;x<enemyToatk.Length;x++){
                    //Debug.Log("Mendapatkan data musuh di aoe....");
                    enemyToatk[x].GetComponent<Enemy>().takedamage(dmg);

                }
                //Debug.Log("Atk is done??");
            }
            bscatk_cd=bscatk_strt;
        }else{
            bscatk_cd-= Time.deltaTime;
        }
        
    }
    void OnDrawGizmosSelected(){
        Gizmos.color= Color.red;
        Gizmos.DrawWireSphere(atkPos.position,atk_range);
    }
}
