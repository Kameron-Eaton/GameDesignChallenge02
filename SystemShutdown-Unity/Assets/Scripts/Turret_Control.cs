using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret_Control : MonoBehaviour
{

    Transform player;
    float dist;
    public float howClose;
    public Transform head, barrel;
    public GameObject projectile;
    public float speed;
    public float fireRate, nextFire;


    // Start is called before the first frame update
    void Start()
    {
        player= GameObject.FindGameObjectWithTag("Player").transform;


    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(player.position, transform.position);
        if (dist<=howClose){
            head.LookAt(player);
            if (Time.time>=nextFire){
                
                nextFire=Time.time +1f/fireRate;
                shoot();
            }
            
        }

    }

    void shoot(){


        GameObject clone=Instantiate(projectile, barrel.position, head.rotation);
        
        clone.GetComponent<Rigidbody>().AddForce(head.forward * speed);
        Destroy(clone, 5);
    }
}
