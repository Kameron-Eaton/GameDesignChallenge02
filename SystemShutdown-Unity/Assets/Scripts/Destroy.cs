/* Created by: Steve Salah
 * Date Created: April 16, 2022
 * 
 * Last Edited by: Steve Salah
 * Last Edited: April 16, 2022
 * 
 * Description: Destroys game object if hit by bullet.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    
    public void Die (){
        //Simply destroys object
        Destroy (gameObject);
    }
}
