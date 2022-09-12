using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Original
public class Laser_Create : MonoBehaviour {

    public GameObject Laser_prefab;//Laser_prefabをインスペクターに用意
    public GameObject Cube_prefab;
    public static int collision = 0;
    private int collision_time = 0;
    
    
    void Start () {
        
    }
	
	void Update () {
        if(collision==1 && collision_time==0)
        {
            GetComponent<Renderer>().material.color = new Color32(255, 0, 0, 120);//弾に当たったら赤に変更する
        }
        
        if(collision==1)
        {
            collision_time++;
        }

        if(collision_time > 5)
        {
            collision = 0;
            collision_time = 0;
            GetComponent<Renderer>().material.color = new Color32(30, 255, 200, 120);//元の色に戻す
        }

        Vector3 touchScreenPosition = Input.mousePosition;//マウス座標を代入

        touchScreenPosition.z = 3.6f;

        Camera gameCamera = Camera.main;//カメラ取得
        Vector3 touchWorldPosition = gameCamera.ScreenToWorldPoint(touchScreenPosition);//マウス座標をワールド座標に変換

        Vector3 pos = transform.position;
        pos.x = touchWorldPosition.x;
        pos.y = touchWorldPosition.y;
        pos.z = touchWorldPosition.z;

        transform.position = pos;//プレイヤー表示座標


        if (Input.GetMouseButton(0))//マウスを左クリックした時
        {
            touchScreenPosition.z = 5f;
            touchWorldPosition = gameCamera.ScreenToWorldPoint(touchScreenPosition);
            Debug.Log("LeftClick:" + touchWorldPosition);//取得座標表示
           
            Instantiate(Laser_prefab, touchWorldPosition , Quaternion.identity);//左クリック位置にレーザー生成
        }
        

    }
}
