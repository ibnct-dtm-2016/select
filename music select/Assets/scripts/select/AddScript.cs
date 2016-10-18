using UnityEngine;
using System.Collections;

public class AddScript : MonoBehaviour {

    //生成プレハブ管理
    private  GameObject[] panels;
    //プレハブの複製元
    public  GameObject origin;
    //生成するプレハブの数(曲数)
    private const int numberOfMusics = 10;
    //プレハブの位置
    private  Vector3 pos;
    //初期配置プレハブのx座標
    private const float x_position = -0.61f;
    
    private float right;

    //プレハブ間の距離
    private const float distance = 3.06f;

    // Use this for initialization
    void Start () {
        panels = new GameObject[numberOfMusics];
        pos = new Vector3(x_position, -3.60f, -19.44f);
        /*  デバッグ用
        print("1st Add Script : "+pos);
        print("origin:"+origin+", pos :"+pos);
        */
        for (int i = 0; i < numberOfMusics; i++)
        {
            pos.x = x_position + distance*i;

            print("i is "+i+" , Add Script : "+pos);
            panels[i] = (GameObject)Instantiate(origin, pos, Quaternion.identity);
            panels[i].AddComponent<music>();
            music m = panels[i].GetComponent<music>();

            right = x_position + distance * (numberOfMusics-1);

            m.StopPosition(right, i);
        }
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public static int numOfMusics {
        get { return numberOfMusics; } 
    }

    public static float first_pos_x {
        get { return x_position; }
    }

    public static float dist {
        get { return distance; }
    }

}
