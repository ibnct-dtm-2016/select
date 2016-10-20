using UnityEngine;
using System.Collections;
using UnityEditor;
using System;

public class music : MonoBehaviour {

    //オブジェクトの位置
    private Vector3 pos;

<<<<<<< HEAD
=======
    //待機フレーム数
    private int wait_frame;

    //移動速度調整
    private int speed;

>>>>>>> refs/remotes/origin/master
    //オブジェクトの停止位置のx座標
    private float stop_right;

    //デバッグ用変数
    private int num;
    

    // Use this for initialization
    void Start ()
    {
        pos = transform.position;
<<<<<<< HEAD
=======
        speed = 13;
        wait_frame = 20;
>>>>>>> refs/remotes/origin/master
        print(pos);
    }

    // Update is called once per frame
    void Update ()
    {

        transform.position = pos;
<<<<<<< HEAD
=======
        wait_frame = 20;
>>>>>>> refs/remotes/origin/master

        pos = transform.position;

        //Hが押されたら左に、Lが押されたら右に移動
        if (Input.GetKeyDown(KeyCode.H))
        {
            //print("KeyDown : H");
<<<<<<< HEAD
            if (AddScript.first_pos_x+1>pos.x && pos.x>AddScript.first_pos_x-1)
            {
                //左端に来たら右端に移動
                //不具合回避のため、条件をおおざっぱにしています
                pos.x = AddScript.first_pos_x + AddScript.dist * (AddScript.numOfMusics - 1);

=======
            if (0>pos.x && pos.x>-1)
            {
                //左端に来たら右端に移動
                //不具合回避のため、条件をおおざっぱにしています

                pos.x = AddScript.first_pos_x + AddScript.dist * (AddScript.numOfMusics - 1);

                transform.position = pos;
>>>>>>> refs/remotes/origin/master
            }
            else
            {
                //演出用
<<<<<<< HEAD
                iTween.MoveTo(gameObject, iTween.Hash("x", pos.x - AddScript.dist, "time", 0.763));

            }
            transform.position = pos;
=======
                for (int i = speed; i > 0; i--)
                {
                    wait_frame = i;

                    StartCoroutine(DelayMethod(wait_frame, () =>
                    {
                        pos.x -= AddScript.dist/speed;
                    }));
                }

                transform.position = pos;

            }
>>>>>>> refs/remotes/origin/master

        }
        else if (Input.GetKeyDown(KeyCode.L))
        {
            print("KeyDown : L");
            if ((pos.x + AddScript.dist) > (stop_right+1))
            {
                //右端に来たら左端に移動
                pos.x = AddScript.first_pos_x;
<<<<<<< HEAD
=======
                transform.position = pos;
>>>>>>> refs/remotes/origin/master
            }
            else
            {
                //演出用
<<<<<<< HEAD
                iTween.MoveTo(gameObject, iTween.Hash("x", pos.x + AddScript.dist, "time", 0.763));
=======
                for (int i = speed; i > 0; i--)
                {
                    wait_frame = i;

                    StartCoroutine(DelayMethod(wait_frame, () =>
                    {
                        pos.x += AddScript.dist / speed;
                    }));
                }
>>>>>>> refs/remotes/origin/master
            }

                transform.position = pos;

        }
        //print("At " + num + ", the position : " + pos.x);

    }

<<<<<<< HEAD
=======
    //http://qiita.com/toRisouP/items/e402b15b36a8f9097ee9 より
    private IEnumerator DelayMethod(int delayFrameCount, Action action)
    {
        for (var i = 0; i < delayFrameCount; i++)
        {
            yield return null;
        }

        action();
    }

>>>>>>> refs/remotes/origin/master
    public void StopPosition(float stop_r, int i) {
        stop_right = stop_r;
        num = i;
    }

}
