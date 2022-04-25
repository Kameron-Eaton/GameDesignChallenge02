/* Created by: Steve Salah
 * Date Created: April 16, 2022
 * 
 * Last Edited by: Steve Salah
 * Last Edited: April 22, 2022
 * 
 * Description: Shoots gun using raycast.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{


    public LayerMask reachLayerMask;
    public int ammo = 10;
    public Camera fpsCam;

    public GameObject impactEffect;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // If you press mouse key, it shoots
        if (Input.GetMouseButtonUp(0)){
            Shoot();
        }
    }
    void Shoot(){
        //USed raycast to shoot gun and if a target with destroy script on it is hit, it dies
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, 1000f, ~reachLayerMask)){
            Debug.Log(hit.transform.name);
            //If ammo then shoot
            if (ammo>=0){
                ammo-=1;
                //Clones and destroys clones after time.
                GameObject clone = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy target=hit.transform.GetComponent<Destroy>();
                Destroy(clone, 2);
                //Allows turrets to get destroyed if bullet hits.
                if (target !=null){
                    target.Die();
            }
            }
            else{
                //Place out of ammo UI here
            }
            
            
            
        }

    }
}
