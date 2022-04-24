/* Created by: Kameron Eaton
 * Date Created: April 24, 2022
 * 
 * Last Edited by: NA
 * Last Edited: April 24, 2022
 * 
 * Description: Destroys the GameObject when the switch being watched is set to true
 */using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnSwitch : MonoBehaviour
{
    public Switch watchSwitch;

    private void Update()
    {
        if(watchSwitch.switchState == true)
        {
            this.gameObject.GetComponent<Collider>().enabled = false;
            Destroy(gameObject);
        }
    }
}
