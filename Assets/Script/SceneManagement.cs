using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{

    public static SceneManagement instance;

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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ToHome()
    {
        SceneManager.LoadScene("Title");
    }

    public void ToMain()
    {
        SceneManager.LoadScene("Main");
    }

    public void ToExplain()
    {
        SceneManager.LoadScene("Explanation");
    }
}
