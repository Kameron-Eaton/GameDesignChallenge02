/* Created by: Kameron Eaton
 * Date Created: April 25, 2022
 * 
 * Last Edited by: NA
 * Last Edited: April 25, 2022
 * 
 * Description: Game Manager script
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    #region GameManager Singleton
    static private GameManager gm;
    static public GameManager GM { get { return gm; } }

    void CheckGameManagerIsInScene()
    {
        if (gm == null)
        {
            gm = this;
            Debug.Log(gm);
        }
        else
        {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this);
        Debug.Log(gm);
    }
    #endregion

    public int playerHealth;

    private void Awake()
    {
        CheckGameManagerIsInScene();
    }

    private void Update()
    {
        if(playerHealth <= 0)
        {
            Die();
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }

    public void Die()
    {
        SceneManager.LoadScene(3);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}

