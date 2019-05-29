using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hexagon : MonoBehaviour
{
    public Rigidbody2D rb;

    public float shrinkSpeed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        // Rotate the hexagon into a random direction
        rb.rotation = Random.Range(0f, 360f);

        // Make the hexagon big
        transform.localScale = Vector3.one * 10f;
    }

    // Update is called once per frame
    void Update()
    {
        // Start shrinking the hexagon
        transform.localScale -= Vector3.one * shrinkSpeed * Time.deltaTime;

        // Destroy the hexagon when it's small enough
        if (transform.localScale.x <= .05f)
        {
            Destroy(gameObject);
        }
    }
}
