/* Created by: Kameron Eaton
 * Date Created: April 11, 2022
 * 
 * Last Edited by: NA
 * Last Edited: April 11, 2022
 * 
 * Description: Allows for flashlight to be turned on and off when equipped by the player
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightController : MonoBehaviour
{
    [Header("Set in inspector")]
    public Light flashLight;

    private void Update()
    {
        if (this.isActiveAndEnabled)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                flashLight.enabled = !flashLight.enabled;
            }
        }
    }
}
