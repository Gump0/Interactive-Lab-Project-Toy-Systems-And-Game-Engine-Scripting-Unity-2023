using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ScoreController : MonoBehaviour
{
    public Text scoreText;

    private int score;

    void Update()
    {
        scoreText.text = score.ToString();
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Bomb")
        {
           Destroy(target.gameObject);
            Destroy(gameObject);
        }
       
    }

    void OnTriggerExit2D(Collider2D target)
    {
        if (target.tag == "Star")
        {
            CircleCollider2D collider = GetComponent<CircleCollider2D>();
            Destroy(gameObject);
            score++;
            
            Debug.Log(score);
        }
    }
    
}
