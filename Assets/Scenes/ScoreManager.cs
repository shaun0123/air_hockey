using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI; 

public class ScoreManager : MonoBehaviour
{
    public GameObject A_score_object = null;
    public GameObject B_score_object = null;
    public int A_score_num = 0;    // Aのスコア
    public int B_score_num = 0;    // Bのスコア

    private Transform Ball_Tf = null;
    private Vector3 Ball_pos = new Vector3(0.0f, 0.0f, 0.0f);      // ボールの現在位置
    private Vector3 Ball_init_pos = new Vector3(0.0f, 0.0f, 0.0f); // ボールの初期位置
    private Text A_score_text = null;                              // Aのスコアテキスト
    private Text B_score_text = null;                              // Bのスコアテキスト

    // Start is called before the first frame update
    void Start()
    {
        Ball_Tf = GameObject.Find("Ball").transform;
        Ball_init_pos = Ball_Tf.position; // ボールの初期位置を保存

        // オブジェクトからTextコンポーネントを取得
        A_score_text = A_score_object.GetComponent<Text> ();
        B_score_text = B_score_object.GetComponent<Text> ();
    }

    // Update is called once per frame
    void Update()
    {
        // ボールの現在位置をBall_posに代入
        Ball_pos = Ball_Tf.position;

        if (Ball_pos.x <= -50.0f) {
            // ボールがプレイヤーB側の奥に到達したら
            A_score_num += 1;                 // Aのスコアを増やす
            Ball_Tf.position = Ball_init_pos; // ボールを初期位置に戻す
        } else if (Ball_pos.x >= 50.0f) {
            // ボールがプレイヤーA側の奥に到達したら
            B_score_num += 1;                 // Bのスコアを増やす
            Ball_Tf.position = Ball_init_pos; // ボールを初期位置に戻す
        }

        // スコア表示を更新
        A_score_text.text = A_score_num.ToString();
        B_score_text.text = B_score_num.ToString();
    }
}
