using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enimy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float z = transform.position.z;
        float playerZ = GameObject.Find("player").transform.position.z;
        if (playerZ > z)
        {
            Destroy(this.gameObject);
        }
    }
}
