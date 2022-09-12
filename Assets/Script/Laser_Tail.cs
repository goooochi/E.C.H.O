﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Original
public class Laser_Tail : MonoBehaviour {
    private int time;//経過フレーム用
	
	void Start () {
        time = 0;//初期化
	}
	
	void Update () {
        time++;
        if(time>60)//60フレーム後に削除
        {
            Destroy(gameObject);
        }
	}
}
