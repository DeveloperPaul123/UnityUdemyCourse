using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 paddle_pos = new Vector3(0.5f, this.transform.position.y, this.transform.position.z);

        float mouse_pos_in_blocks = Input.mousePosition.x / Screen.width * 16;
        paddle_pos.x = Mathf.Clamp(mouse_pos_in_blocks - 8, -7.5f, 7.5f);
        this.transform.position = paddle_pos;
	}
}
