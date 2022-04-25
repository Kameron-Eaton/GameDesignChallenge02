/* Created by: Kameron Eaton
 * Date Created: April 25, 2022
 * 
 * Last Edited by: NA
 * Last Edited: April 25, 2022
 * 
 * Description: Opens door when its switch state is set to true
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public Switch door;
    public Animator openDoor;

    private void Update()
    {
        if (door.switchState == true)
        {
            openDoor.SetBool("Open", true);
        }
    }
}
