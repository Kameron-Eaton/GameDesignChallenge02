/* Created by: Kameron Eaton
 * Date Created: April 25, 2022
 * 
 * Last Edited by: NA
 * Last Edited: April 24, 2022
 * 
 * Description: Turns off all light fixtures attached
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillLights : MonoBehaviour
{
    public List<Light> lights;
    public Material emissiveMat;

    private void Start()
    {
        emissiveMat.EnableKeyword("_EMISSION");
        emissiveMat.SetColor("_EmissionColor", Color.yellow);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            emissiveMat.DisableKeyword("_EMISSION");
            emissiveMat.SetColor("_EmissionColor", Color.black);
            foreach(Light light in lights)
            {
                light.enabled = false;
            }
        }
    }
}
