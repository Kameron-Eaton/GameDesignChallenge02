/* Created by: Kameron Eaton
 * Date Created: April 9, 2022
 * 
 * Last Edited by: NA
 * Last Edited: April 9, 2022
 * 
 * Description: Handles interaction with switches
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : Interactable
{
    public bool switchState;
    private void Start()
    {
        inReach = false;
        switchState = false;
        interactText.gameObject.SetActive(false);
        failText.gameObject.SetActive(false);
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && inReach && !itemRequired)
        {
            switchState = true;
        }
        if (Input.GetKeyDown(KeyCode.E) && inReach && itemRequired)
        {
            if (requiredItem.gameObject.activeInHierarchy)
            {
                itemRequired = !itemRequired;
                requiredItem.gameObject.SetActive(false);
            }

            else
            {
                StartCoroutine(Failed());
            }
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        GameObject otherGo = other.gameObject;
        
        if (otherGo.tag == "Reach")
        {
            if (switchState)
                return;
            inReach = true;
            interactText.SetActive(true);
        }
    }

    public void OnTriggerExit(Collider other)
    {
        GameObject otherGo = other.gameObject;
        if (otherGo.tag == "Reach")
        {
            inReach = false;
            interactText.SetActive(false);
        }

    }

    IEnumerator Failed()
    {
        this.GetComponent<Collider>().enabled = false;
        interactText.SetActive(false);
        failText.SetActive(true);
        yield return new WaitForSeconds(3f);
        failText.SetActive(false);
        this.GetComponent<Collider>().enabled = true;
    }
}