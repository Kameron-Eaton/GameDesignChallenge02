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
    public GameObject pickUpText;
    bool inReach;

    private void Start()
    {
        inReach = false;
        activateOB.gameObject.SetActive(false);
        pickUpText.SetActive(false);
    }

    public void OnTriggerEnter(Collider other)
    {
        GameObject otherGo = other.gameObject;
   
        if(otherGo.tag == "Reach")
        {
            inReach = true;
            pickUpText.SetActive(true);
            
        }
    }

    public void OnTriggerExit(Collider other)
    {
        GameObject otherGo = other.gameObject;
        if (otherGo.tag == "Reach")
        {
            inReach = false;
            pickUpText.SetActive(false);
        }
        
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && inReach)
        {
            activateOB.gameObject.SetActive(true);
            activateOB.isCollected = true;
            pickUpText.SetActive(false);
            Destroy(gameObject);
        }
    }
}
