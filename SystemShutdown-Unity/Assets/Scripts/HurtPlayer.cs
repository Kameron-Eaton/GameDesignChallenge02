/* Created by: Steve Salah
 * Date Created: April 25, 2022
 * 
 * Last Edited by: Steve Salah
 * Last Edited: April 25, 2022
 * 
 * Description: Hurts players health if hit by turret.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour
{
    GameManager gm;
    
void Start(){
    gm = GameManager.GM;
}
    void OnCollisionEnter(Collision other){
        GameObject otherGO = other.gameObject;
        if(otherGO.tag == "Player"){
            gm.playerHealth -= 25;
        }
        Destroy(gameObject);
    }
}
