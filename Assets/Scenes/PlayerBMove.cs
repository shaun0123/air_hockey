using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBMove : MonoBehaviour
{
    Transform PlayerBTrans = null;
    Vector3 pos = new Vector3(0.0f, 0.0f, 0.0f);

    // Start is called before the first frame update
    void Start()
    {
        PlayerBTrans = GameObject.Find("PlayerB").transform;
    }

    // Update is called once per frame
    void Update()
    {
        // PlayerBの現在位置を取得
        pos = PlayerBTrans.position;

        if (Input.GetKey(KeyCode.UpArrow)) {
            if (pos.z < 43.0f) {
                this.transform.Translate(0.0f, 0.0f, 0.5f);
            }
            
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            if (pos.z > 6.5f) {
                this.transform.Translate(0.0f, 0.0f, -0.5f);
            }
        }
    }
}
