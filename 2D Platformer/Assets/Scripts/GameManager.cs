using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        //Exit out of game by pressing the ESC key
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit(); // Quit Game
        }
    }
}
