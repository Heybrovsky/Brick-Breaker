
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rigidbody { get; private set; }

    public float speed = 500f;

    public void Awake()
    {
        this.rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        ResetBall();
    }
        
    public void ResetBall()
    {
        this.transform.position = Vector2.zero;
        this.rigidbody.velocity = Vector2.zero;
        Invoke(nameof(MoveRandomTrajectory), 3f);
    }
    private void MoveRandomTrajectory()
    {
        Vector2 force = Vector2.zero;
        force.x = Random.Range(-1f, 1f);
        force.y = -1f;

        this.rigidbody.AddForce(force.normalized * this.speed);
    }
}
