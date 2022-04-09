/* Created by: Kameron Eaton
 * Date Created: April 9, 2022
 * 
 * Last Edited by: NA
 * Last Edited: April 9, 2022
 * 
 * Description: Handles consumable item objects
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Consumable Object", menuName = "Inventory System/Items/Consumable")]
public class Consumable : ItemObject
{
    public void Awake()
    {
        type = ItemType.Consumable;
    }
}
