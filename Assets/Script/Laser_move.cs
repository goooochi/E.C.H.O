using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

//Original
public class Laser_move : MonoBehaviour {

    
    private float moveX = 0f;
    //private float moveZ = 0f;
    int randomNum;
    private int time = 0;
    private float speed = 1.0f;//弾速度

    //変更点
    private Vector3 lastVelocity;//速度ベクトル
    private Rigidbody rb;//Rigidbody用
    


    public static Laser_move instance;
    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }


    void Start () {
        rb = GetComponent<Rigidbody>();
        //moveX = Random.Range(-10.0f, 10.0f) * speed;
        //moveZ = Random.Range(-10.0f, 10.0f) * speed;
        //randomNum = Laser_Create.instance.hoge_index[Random.Range(0, Laser_Create.instance.hoge_index.Length)];

        //9/14 他スクリプトに配列を用意し、配列の要素を取得。その配列番号も取得時に同時に消す。
        //rb.velocity = Laser_Create.instance.hoge[Laser_Create.instance.k % Laser_Create.instance.hoge.Length];
        

        
    }
	
	void Update () {
        time++;
        if (time > 60)//60フレーム後に弾削除
        {
            transform.DetachChildren();//親オブジェクトから子オブジェクトを解除
            Destroy(gameObject);//弾削除
        }
    }

    void FixedUpdate()
    {
        this.lastVelocity = this.rb.velocity;//Rigidbodyを使用した移動用

    }





    private void OnCollisionEnter(Collision coll)
    {
        if (coll.gameObject.tag == "Cube")//壁と当たった時
        {
            Vector3 refrectVec = Vector3.Reflect(this.lastVelocity, coll.contacts[0].normal);//反射ベクトル計算
            this.rb.velocity = refrectVec;
            if (coll.gameObject.tag == "key")
            {
                //var trail_renderer = this.gameObject.GetComponent<TrailRenderer>();
                //trail_renderer.colorGradient
            }
            
        }
        if (coll.gameObject.tag == "Cube_Destroy")//破壊出来る壁に当たった時
        {
            Destroy(coll.gameObject);//壁削除
            Vector3 refrectVec = Vector3.Reflect(this.lastVelocity, coll.contacts[0].normal);//反射ベクトル計算
            this.rb.velocity = refrectVec;
        }
        if (coll.gameObject.tag == "Player_Cube")//プレイヤーと当たった時
        {
            Vector3 refrectVec = Vector3.Reflect(this.lastVelocity, coll.contacts[0].normal);//反射ベクトル計算
            this.rb.velocity = refrectVec;
            Laser_Create.collision = 1;//赤く光らせる用
        }

        
    }


}
