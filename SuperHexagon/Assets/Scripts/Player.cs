using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public float moveSpeed = 600f;

    float movement = 0f;

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal");
    }

    private void FixedUpdate()
    {
        // The player can rotate around the central dot
        // moveSpeed is negative so the controls work better
        transform.RotateAround(Vector3.zero, Vector3.forward, movement * Time.fixedDeltaTime * -moveSpeed);
    }

    // Player hits something
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Re-load the scene
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
