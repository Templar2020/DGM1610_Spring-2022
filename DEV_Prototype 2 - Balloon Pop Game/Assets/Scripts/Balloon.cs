using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balloon : MonoBehaviour
{
    public int scoreToGive = 100;  // Score give for popped balloon.

    public int clickToPop = 3; //How many clicks before balloon pops

    public float scaleToIncrease = 0.10f; //Scale increase each time the ballon is clicked

    public ScoreManager scoreManager; // A variable refernce to the scoremanagement component

    // Start is called before the first frame update
    void Start()
    {
        //Reference ScoreManager component
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        // Reduce clicks by one
        clickToPop -= 1;
        //Increase 
        transform.localScale += Vector3.one * scaleToIncrease;

        if(clickToPop == 0)
        {
            // Tell the scoremanager to increase our score
            scoreManager.IncreaseScoreText(scoreToGive);
            Destroy(gameObject);
        }
    }
}
