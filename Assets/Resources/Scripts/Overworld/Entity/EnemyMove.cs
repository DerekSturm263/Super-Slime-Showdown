using UnityEngine;

public class EnemyMove : EntityMove
{
    private GameObject player;
    [SerializeField] private float followDistance = 3.5f;

    private Vector2 movVal;

    private void Awake()
    {
        rb2 = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
    }
    private void Start()
    {
        InvokeRepeating("ChangeDirection", 0f, 1f);
    }

    private void Update()
    {
        // Sets the direction based on distance from the player.
        if (Vector2.Distance(transform.position, player.transform.position) > followDistance)
            Move(movVal);
        else
            MoveTowards(player);
    }

    private void ChangeDirection()
    {
        int randomDir = Random.Range(0, 4);

        switch (randomDir)
        {
            case 0:
                movVal.x = Random.Range(0.75f, 1.25f);
                break;
            case 1:
                movVal.x = Random.Range(-0.75f, -1.25f);
                break;
            case 2:
                movVal.y = Random.Range(-0.75f, -1.25f);
                break;
            case 3:
                movVal.y = Random.Range(0.75f, 1.25f);
                break;
        }
    }
}
