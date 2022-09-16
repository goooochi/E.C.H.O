using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Original
public class Laser_Create : MonoBehaviour {

    
    private int collision_time = 0;
    private int create_raser = 16;
    //private float speed = 0.5f;//弾速度
    private Vector3[] hoge = { new Vector3(10f, 0f, 0f), new Vector3(5 * Mathf.Sqrt(3), 0f, 5f), new Vector3(5 * Mathf.Sqrt(2), 0f, 5 * Mathf.Sqrt(2)), new Vector3(5f, 0f, 5 * Mathf.Sqrt(3)), new Vector3(0f, 0f, 10f), new Vector3(-5f, 0f, 5 * Mathf.Sqrt(3)), new Vector3(-5 * Mathf.Sqrt(2), 0f, 5 * Mathf.Sqrt(2)), new Vector3(-5 * Mathf.Sqrt(3), 0f, 5f), new Vector3(-10f, 0f, 0), new Vector3(-5 * Mathf.Sqrt(3), 0f, -5f), new Vector3(-5 * Mathf.Sqrt(2), 0f, -5 * Mathf.Sqrt(2)), new Vector3(-5f, 0f, -5 * Mathf.Sqrt(3)), new Vector3(0f, 0f, -10f), new Vector3(5f, 0f, -5 * Mathf.Sqrt(3)), new Vector3(5 * Mathf.Sqrt(2), 0f, -5 * Mathf.Sqrt(2)), new Vector3(5 * Mathf.Sqrt(3), 0f, -5f) };


    public GameObject Laser_prefab;
    public static int collision = 0;


    public static Laser_Create instance;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    void Start () {
        
    }


	void Update () {

        //マウスを左クリックした時にレーザーを生成
        if (Input.GetMouseButtonDown(0))
        {

            for (int i = 0; i < create_raser; i++)
            {
                GameObject l = Instantiate(Laser_prefab, this.transform.position + new Vector3(0,0.2f,0), Quaternion.identity);//左クリック位置にレーザー生成
                l.GetComponent<Rigidbody>().velocity = hoge[i];

            }


        }

    }

    
}
