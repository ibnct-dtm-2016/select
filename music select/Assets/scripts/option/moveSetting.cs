using UnityEngine;
using System.Collections;

public class moveSetting : MonoBehaviour {

    private Vector3 pos;

    private int difficulty = 2;

    private int speed = 4;

    // Use this for initialization
    void Start () {
        pos = transform.position;
        /*難易度と整数値の対応
            1 : easy
            2 : normal
            3 : hard
        */
        
    }
    //5.325023 -> -9.04

    // Update is called once per frame
    void Update () {

        pos = transform.position;

        if (pos.x > 5.32f && pos.x < 5.33f)
        {
            if (Input.GetKeyDown(KeyCode.L))
            {
                if (difficulty < 3)
                {
                    difficulty++;
                }
                else
                {
                    difficulty = 1;
                }
            }
            else if (Input.GetKeyDown(KeyCode.H))
            {
                if (difficulty > 1)
                {
                    difficulty--;
                }
                else
                {
                    difficulty = 3;
                }
            }
            
            if (Input.GetKeyDown(KeyCode.Return))
            {
                iTween.MoveTo(this.gameObject, iTween.Hash("x", -9.04f));
            }
            print("speed:" + speed + " difficulty:" + difficulty);
        }else {
            if (Input.GetKeyDown(KeyCode.J))
            {
                if (speed < 12)
                {
                    speed++;
                }
                else
                {
                    //なにもしない
                }
            }
            else if (Input.GetKeyDown(KeyCode.K))
            {
                if (speed > 1)
                {
                    speed--;
                }
                else
                {
                    //なにもしない
                }
            }
            print("speed:" + speed + " difficulty:" + difficulty);
        }
        transform.position = pos;

	}
}
