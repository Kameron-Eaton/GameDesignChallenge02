/* Created by: Kameron Eaton
 * Date Created: April 9, 2022
 * 
 * Last Edited by: NA
 * Last Edited: April 9, 2022
 * 
 * Description: Handles interactable objects that are not picked up. Parent class
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    public bool itemRequired;
    [HideInInspector]
    public bool inReach;

    public GameObject interactText;
    public GameObject failText;
    public Item requiredItem;
}
