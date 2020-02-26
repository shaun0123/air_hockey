using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAMove : MonoBehaviour
{
    Transform PlayerATrans = null;
    Vector3 pos = new Vector3(0.0f, 0.0f, 0.0f);

    // Start is called before the first frame update
    void Start()
    {
        PlayerATrans = GameObject.Find("PlayerA").transform;
    }

    // Update is called once per frame
    void Update()
    {
        // PlayerAの現在位置を取得
        pos = PlayerATrans.position;

        if (Input.GetKey(KeyCode.W)) {
            if (pos.z < 43.0f) {
                this.transform.Translate(0.0f, 0.0f, 0.5f);
            }
            
        }
        if (Input.GetKey(KeyCode.S)) {
            if (pos.z > 6.5f) {
                this.transform.Translate(0.0f, 0.0f, -0.5f);
            }
        }
    }
}
