/* Created by: Kameron Eaton
 * Date Created: April 9, 2022
 * 
 * Last Edited by: NA
 * Last Edited: April 9, 2022
 * 
 * Description: Holds items and the amount of each item in inventory slots
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Inventory", menuName = "Inventory System/Inventory")]
public class InventoryObject : ScriptableObject
{
    public List<InventorySlot> inv = new List<InventorySlot>();
    public void AddItem(ItemObject itm, int amt)
    {
        bool hasItem = false;
        for (int i = 0; i < inv.Count; i++)
        {
            if (inv[i].item == itm)
            {
                inv[i].AddAmount(amt);
                hasItem = true;
                break;
            }
        }
        if (!hasItem)
        {
            inv.Add(new InventorySlot(itm, amt));
        }
    }       
}

[System.Serializable]
public class InventorySlot
{
    public ItemObject item;
    public int amount;
    public InventorySlot(ItemObject itm, int amt)
    {
        item = itm;
        amount = amt;
    }

    public void AddAmount(int value)
    {
        amount += value;
    }
}