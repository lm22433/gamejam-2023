using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private static PlayerMovement _instance;

    // Start is called before the first frame update
    public float moveSpeed = 100f;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        Input.GetAxisRaw("Horizontal");
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate(){
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "Lvl1Walls"){
            if (Input.GetKey(KeyCode.LeftArrow)){
                transform.Translate(0, 0, 0);
            }
             if (Input.GetKey(KeyCode.RightArrow)){
                transform.Translate(0, 0, 0);
            }
             if (Input.GetKey(KeyCode.UpArrow)){
                transform.Translate(0, 0, 0);
            }
             if (Input.GetKey(KeyCode.DownArrow)){
                transform.Translate(0, 0, 0);
            }
        }
    }
}
