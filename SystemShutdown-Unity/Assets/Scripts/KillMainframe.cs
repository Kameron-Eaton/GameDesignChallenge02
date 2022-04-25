/* Created by: Kameron Eaton
 * Date Created: April 25, 2022
 * 
 * Last Edited by: NA
 * Last Edited: April 25, 2022
 * 
 * Description: Interactable that allows player to win the game
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillMainframe : MonoBehaviour
{
    public GameObject successGame;
    public GameObject interactText;
    bool inReach;

    GameManager gm;

    void Start(){
        gm = GameManager.GM;
        inReach = false;
        interactText.gameObject.SetActive(false);
        successGame.gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E) && inReach){
            StartCoroutine(WinGame());
        }
    }

    public void OnCollisionEnter(Collision other)
    {
        GameObject otherGo = other.gameObject;
        
        if (otherGo.tag == "Reach")
        {
            inReach = true;
            interactText.SetActive(true);
        }
    }

    public void OnCollisionExit(Collision other)
    {
        GameObject otherGo = other.gameObject;
        if (otherGo.tag == "Reach")
        {
            inReach = false;
            interactText.SetActive(false);
        }

    }

    IEnumerator WinGame(){
        inReach = false;
        this.GetComponent<Collider>().enabled = false;
        interactText.SetActive(false);
        successGame.SetActive(true);
        yield return new WaitForSeconds(3f);
        successGame.SetActive(false);
        gm.Die();
    }
}
