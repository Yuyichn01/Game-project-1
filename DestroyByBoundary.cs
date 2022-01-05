using System.Collections;
using UnityEngine;

public class DestroyByBoundary : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(collision.gameObject);
    }
}
