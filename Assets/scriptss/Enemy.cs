using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Stats")]
    public int level=1;
    public int maxhp=2;
    public int hp=0;
    //public int atk=2;
    //public int def=1;

    bool isDead;
    [Header("Movement")]
    public float movespd=1.0f;

    private Rigidbody char_rb;
   // public gameObject

    public void takedamage(int totalatk){
        //int dmg = totalatk-def;
        hp-=totalatk;
        Debug.Log("dmg taken");
        if(hp<=0){
            Destroy(gameObject);
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        char_rb=GetComponent<Rigidbody>();
        hp=maxhp;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("EnemyHp="+hp);
        
        
    }
}
