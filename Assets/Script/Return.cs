using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Return : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z >= 125)
            transform.position = new Vector3(4.3f, 7.5f, -1.2f);
    }
}
