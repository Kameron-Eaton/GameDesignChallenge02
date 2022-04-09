/* Created by: Kameron Eaton
 * Date Created: April 9, 2022
 * 
 * Last Edited by: NA
 * Last Edited: April 9, 2022
 * 
 * Description: Handles key/puzzle item objects
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New KeyItem Object", menuName = "Inventory System/Items/KeyItem")]
public class KeyItem : ItemObject
{
    public void Awake()
    {
        type = ItemType.KeyItem;
    }
}
