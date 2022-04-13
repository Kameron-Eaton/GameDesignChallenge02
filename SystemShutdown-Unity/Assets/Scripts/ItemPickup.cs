/* Created by: Kameron Eaton
 * Date Created: April 9, 2022
 * 
 * Last Edited by: NA
 * Last Edited: April 9, 2022
 * 
 * Description: Scripted event for picking up an item and adding it to inventory
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item activateOB;
    bool inReach;

    private void Start()
    {
        inReach = false;
    }

    public void OnTriggerEnter(Collider other)
    {
        GameObject otherGo = other.gameObject;
        Debug.Log("Collided with" + otherGo.name);
   
        if(otherGo.tag == "PlayerReach")
        {
            Debug.Log("Item in reach of player");
            inReach = true;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        GameObject otherGo = other.gameObject;
        if (otherGo.tag == "PlayerReach")
        {
            Debug.Log("Item out of player reach");
            inReach = false;
        }
        
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && inReach)
        {
            activateOB.gameObject.SetActive(true);
            activateOB.isCollected = true;
            Destroy(gameObject);
        }
    }
}
