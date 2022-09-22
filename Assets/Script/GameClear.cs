using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameClear : MonoBehaviour
{
    public GameObject leftDoor;
    public GameObject rightDoor;
    public GameObject gameClearUI;

    public static GameClear instance;

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

    public void OpenDoor()
    {
        leftDoor.SetActive(false);
        rightDoor.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {

        if(collision.gameObject.layer == 9)
        {
            gameClearUI.SetActive(true);
        }

    }
}
