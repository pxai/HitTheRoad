using UnityEngine;
using System.Collections;

public class Car : MonoBehaviour {

    private Vector3 direction;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        direction = new Vector3();



        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction += Vector3.left;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {

            direction += Vector3.right;
        }
        if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.UpArrow))
        {
            direction += Vector3.left;
            direction += Vector3.up;
        }
        else if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.UpArrow))
        {

            direction += Vector3.right;
            direction += Vector3.up;
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            direction += Vector3.up;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            direction += Vector3.down;
        }

        // restrict the player to the gamespace
        //float newX = Mathf.Clamp(transform.position.x, 0.5f, 16f);
        //float newY = Mathf.Clamp(transform.position.y, 0f, 10f);
        //transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        transform.Translate(direction.normalized * 5 * Time.deltaTime);
    }
}
