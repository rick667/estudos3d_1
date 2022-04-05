using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float spd = 0.05f;

    private GameObject camera;

    // Start is called before the first frame update
    void Start()
    {
        camera = GameObject.Find("Main Camera");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 0, spd);
        camera.transform.position = transform.position + new Vector3(0, 2, -4f);

        if (Input.GetKey("d"))
        {
            transform.position += new Vector3(spd, 0, 0);
        }
        else if (Input.GetKey("a"))
        {
            transform.position -= new Vector3(spd, 0, 0);
        }
    }
}
