using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BirdScript : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D rg;public float speed;
    public GameObject gameOverObj;         
    void Start()
    {
        Time.timeScale = 1;
        rg = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space))
        {
            SoundController.instance.PlaySound("wing", 0.8f);
            rg.AddForce(Vector2.up * speed);
        }
    }
    public void ResetGame()
    {
        SceneManager.LoadScene(1);
    }
    void GameOver()
    {
        
        gameOverObj.SetActive(true);
        Time.timeScale = 0;  
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        SoundController.instance.PlaySound("hit", 0.8f);
        GameOver();
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        SoundController.instance.PlaySound("point", 0.8f);
        Score.instance.UpdateScore();
        
    }
}
