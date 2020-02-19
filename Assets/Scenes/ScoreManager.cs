using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI; 

public class ScoreManager : MonoBehaviour
{
    // public GameObject A_score_object = null;
    // public GameObject B_score_object = null;
    // public int A_score_num = 0;    // スコア
    // public int B_score_num = 0;    // スコア
    // public float border_x  = 0.0f; // 境界のx座標
    // private Transform Ball_Tf;

    // Start is called before the first frame update
    void Start()
    {
        // Ball_Tf = GameObject.Find("Ball").transform;
        // Vector3 Ball_pos = Ball_Tf.position;

        // // オブジェクトからTextコンポーネントを取得
        // Text A_score_text = A_score_object.GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        // // テキストの表示を入れ替える
        // if (Ball_pos.x <= -50.0f) {
        //     A_score_num += 1;
        // } else if (Ball_pos.x >= 50.0f) {
        //     B_score_num += 1;
        // }
        // A_score_text.text = A_score_num;
        // B_score_text.text = B_score_num;
    }
}
