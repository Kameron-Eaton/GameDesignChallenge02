/* Created by: Kameron Eaton
 * Date Created: April 11, 2022
 * 
 * Last Edited by: NA
 * Last Edited: April 11, 2022
 * 
 * Description: Allows the player to switch between equipment items
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentSwitch : MonoBehaviour
{
    public Equipment flashLight;
    public Equipment weapon;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SwitchEmpty();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SwitchFlashLight();
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SwitchWeapon();
        }
    }

    public void SwitchEmpty()
    {
        flashLight.gameObject.SetActive(false);
        weapon.gameObject.SetActive(false);
    }

    public void SwitchFlashLight()
    {
        if (flashLight.isCollected == false)
            return;
        weapon.gameObject.SetActive(false);
        flashLight.gameObject.SetActive(true);
    }

    public void SwitchWeapon()
    {
        if (weapon.isCollected == false)
            return;
        flashLight.gameObject.SetActive(false);
        weapon.gameObject.SetActive(true);
    }
}
