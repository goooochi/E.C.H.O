using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverController : MonoBehaviour
{
    public GameObject gameOverUI;
    public static GameOverController instance;
    bool isPlaying;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        isPlaying = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isPlaying)
        {
            if (Input.GetMouseButtonDown(0))
            {
                SceneManager.LoadScene("Main");
                isPlaying = false;
            }
        }
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "Enemy_01" || collision.gameObject.name == "Enemy_02")
        {
            GameOver();

            isPlaying = false;
        }
    }

    public void GameOver()
    {
        
        gameOverUI.SetActive(true);
        
    }
}
