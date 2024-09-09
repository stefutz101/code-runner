using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControll : MonoBehaviour
{
    public Rigidbody player;
    public GameObject character;
    public float inainte = 0.25f;

    public float speed = 3f;

    void Start()
    {
        player = GetComponent<Rigidbody>();

    }
    void Update()
    {
        float x = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(speed, 0f, 0f);

        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(-speed, 0f, 0f);

        }

        

        transform.Translate(0f, 0f, inainte);

        if (transform.position.y < -25)
            transform.position = new Vector3(4.3f, 7.5f, -1.2f);

    }
}
