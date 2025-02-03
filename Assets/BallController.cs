using UnityEngine;
using UnityEngine.Events;

public class BallController : MonoBehaviour
{
    [SerializeField] private float force = 1f;

    private bool isBallLaunched;
    private Rigidbody ballRB;
    private InputManager inputManager;

    void Start()
    {
        ballRB = GetComponent<Rigidbody>();
        inputManager = FindObjectOfType<InputManager>();
        inputManager.OnSpacePressed.AddListener(LaunchBall);
    }

    private void LaunchBall()
    {
        if (isBallLaunched) return;
        
        isBallLaunched = true;
        ballRB.AddForce(transform.forward * force, ForceMode.Impulse);
    }
    
    void Update()
    {
        
    }
}
