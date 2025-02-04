using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private InputManager inputManager;
    [SerializeField] private float speed;

    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Adding MovePlayer as a listener to the OnMove event
        inputManager = FindObjectOfType<InputManager>();
        inputManager.OnMove.AddListener(MovePlayer);
        rb = GetComponent<Rigidbody>();
    }

    // This is similar to our code from our Roll-A-Ball tutorial
    // Only difference being, we only listen to Left and Right inputs
    private void MovePlayer(Vector2 direction)
    {
        Vector3 moveDirection = new(0f, 0f, direction.x);
        rb.AddForce(speed * moveDirection);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
