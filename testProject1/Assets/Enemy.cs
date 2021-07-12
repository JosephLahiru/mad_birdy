using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Birdy_")
        {
            Destroy(gameObject);
        }

        if (coll.contacts[0].normal.y < -0.5)
        {
            Destroy(gameObject);
        }
    }
}