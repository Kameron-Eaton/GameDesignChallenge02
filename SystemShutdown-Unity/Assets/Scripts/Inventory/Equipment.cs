/* Created by: Kameron Eaton
 * Date Created: April 9, 2022
 * 
 * Last Edited by: NA
 * Last Edited: April 9, 2022
 * 
 * Description: Handles equipment item objects
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Equipment Object", menuName = "Inventory System/Items/Equipment")]
public class Equipment : ItemObject
{
    public void Awake()
    {
        type = ItemType.Equipment;
    }
}
