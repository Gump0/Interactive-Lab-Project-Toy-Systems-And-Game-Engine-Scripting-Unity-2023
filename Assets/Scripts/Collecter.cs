using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collecter : MonoBehaviour
{
 void Collider2D(Collision collision)
    {
        if (collision.gameObject.tag == "Bomb" || collision.gameObject.tag == "Star")
        {
            Destroy(collision.gameObject);
        }
    }
}
