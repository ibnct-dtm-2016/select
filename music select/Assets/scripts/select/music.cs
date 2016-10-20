using UnityEngine;
using System.Collections;
using UnityEditor;
using System;

public class music : MonoBehaviour {

    //オブジェクトの位置
    private Vector3 pos;

    //オブジェクトの停止位置のx座標
    private float stop_right;

    //デバッグ用変数
    private int num;
    

    // Use this for initialization
    void Start ()
    {
        pos = transform.position;
        print(pos);
    }

    // Update is called once per frame
    void Update ()
    {

        transform.position = pos;

        pos = transform.position;

        //Hが押されたら左に、Lが押されたら右に移動
        if (Input.GetKeyDown(KeyCode.H))
        {
            //print("KeyDown : H");
            if (AddScript.first_pos_x+1>pos.x && pos.x>AddScript.first_pos_x-1)
            {
                //左端に来たら右端に移動
                //不具合回避のため、条件をおおざっぱにしています
                pos.x = AddScript.first_pos_x + AddScript.dist * (AddScript.numOfMusics - 1);

            }
            else
            {
                //演出用
                iTween.MoveTo(gameObject, iTween.Hash("x", pos.x - AddScript.dist, "time", 0.763));

            }
            transform.position = pos;

        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            print("KeyDown : L");
            if ((pos.x + AddScript.dist) > (stop_right+1))
            {
                //右端に来たら左端に移動
                pos.x = AddScript.first_pos_x;
            }
            else
            {
                //演出用
                iTween.MoveTo(gameObject, iTween.Hash("x", pos.x + AddScript.dist, "time", 0.763));
            }

                transform.position = pos;

        }
        //print("At " + num + ", the position : " + pos.x);

    }

    public void StopPosition(float stop_r, int i) {
        stop_right = stop_r;
        num = i;
    }

}
