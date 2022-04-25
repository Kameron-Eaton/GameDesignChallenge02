/* Created by: Steve Salah
 * Date Created: April 16, 2022
 * 
 * Last Edited by: Steve Salah
 * Last Edited: April 22, 2022
 * 
 * Description: Destroys game object if hit by bullet.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret_Control : MonoBehaviour
{
//All variables
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
        //gets player coords
        player= GameObject.FindGameObjectWithTag("Player").transform;


    }

    // Update is called once per frame
    void Update()
    {
        //locks turret onto player and calls shoot if it is the correct time
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
        //shoots at player after instantiating a  projectile.

        GameObject clone=Instantiate(projectile, barrel.position, head.rotation);
        
        clone.GetComponent<Rigidbody>().AddForce(head.forward * speed);
        Destroy(clone, 3);
    }
}
