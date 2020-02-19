using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W)) {
            this.transform.Translate(0.0f, 0.0f, 0.5f);
        }
        if (Input.GetKey(KeyCode.S)) {
            this.transform.Translate(0.0f, 0.0f, -0.5f);
        }
    }
}
