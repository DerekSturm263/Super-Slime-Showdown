using UnityEngine;
using UnityEngine.UI;

public class EntityMove : MonoBehaviour
{
    public enum Direction
    {
        Up, Down, Left, Right
    }
    [HideInInspector] public Direction animDir = Direction.Down;

    public enum State
    {
        Idle, Moving
    }
    [HideInInspector] public State animState = State.Idle;

    protected Rigidbody2D rb2;
    protected Animator anim;
    private Vector2 currentVel;

    [Header("Settings")]
    [SerializeField] [Tooltip("How fast the slime moves.")] private float moveSpeed = 2f;
    [SerializeField] [Tooltip("Scales the slime's speed based on distance from where the original tap was.")] private float moveScaler = 0.5f;
    protected float maxDist = 5f; // Maximum length you can move the held tap between the original.

    private Vector2 tapStartPos;

    [Header("UI Images")]
    [SerializeField] private Image tapStartIcon = null; // Where the user started a tap.
    [SerializeField] private Image tapHoldIcon = null; // Where the user's finger currently is.

    protected void StartMove(Vector2 tapPos)
    {
        tapStartPos = tapPos;

        tapStartIcon.gameObject.SetActive(true);
        tapStartIcon.GetComponent<RectTransform>().anchoredPosition = tapStartPos - new Vector2(Screen.width, Screen.height) / 2f;

        tapHoldIcon.gameObject.SetActive(true);
        tapHoldIcon.GetComponent<RectTransform>().anchoredPosition = tapStartIcon.GetComponent<RectTransform>().anchoredPosition;
    }

    protected void Move(Vector2 tapPos, bool isPlayer = false)
    {
        Vector2 moveVal;
        float tapDist = 1f;

        if (isPlayer)
        {
            Camera camera = Camera.main;

            // Sets a distance float between the world positions of each tap icon.
            tapDist = (Vector2.Distance(camera.ScreenToWorldPoint(tapPos), camera.ScreenToWorldPoint(tapStartPos)));

            if (tapDist <= maxDist)
            {
                tapHoldIcon.GetComponent<RectTransform>().anchoredPosition = tapPos - new Vector2(Screen.width, Screen.height) / 2f;
            }
            else
            {
                // Clamps the distance of the tap hold icon.
                tapHoldIcon.GetComponent<RectTransform>().anchoredPosition = tapStartPos + ( (tapPos - tapStartPos).normalized * camera.WorldToScreenPoint( new Vector2(maxDist, 0f) ).x ) - new Vector2(Screen.width, Screen.height) / 2f;
                tapDist = maxDist;
            }

            // Sets a movement vector based on the position between where your finger started and where it is now.
            moveVal = tapPos - tapStartPos;
        }
        else
        {
            moveVal = tapPos;
        }

        // Sets an x and a y based on input.
        currentVel.x = Mathf.Lerp(-1f, 1f, moveVal.normalized.x + 0.5f);
        currentVel.y = Mathf.Lerp(-1f, 1f, moveVal.normalized.y + 0.5f);

        // Applys your velocity.
        rb2.velocity = currentVel * moveSpeed * moveScaler * tapDist;

        #region Animation States

        // Sets whether you're idle or not.
        animState = (rb2.velocity.magnitude == 0f) ? State.Idle : State.Moving;

        // Sets the direction you're moving in.
        if (Mathf.Abs(rb2.velocity.x) > Mathf.Abs(rb2.velocity.y))
            animDir = (rb2.velocity.x < 0f) ? Direction.Left : Direction.Right;
        else if (Mathf.Abs(rb2.velocity.x) < Mathf.Abs(rb2.velocity.y))
            animDir = (rb2.velocity.y < 0f) ? Direction.Down : Direction.Up;

        // Converts them into animation states.
        anim.SetInteger("State", 1);
        anim.SetInteger("Direction", (int) animDir);

        #endregion
    }

    protected void MoveTowards(GameObject g)
    {
        Vector2 moveVal = new Vector2(g.transform.position.x - transform.position.x, g.transform.position.y - transform.position.y).normalized * moveSpeed;

        // Sets an x and a y based on input.
        currentVel.x = Mathf.Lerp(-1f, 1f, moveVal.normalized.x + 0.5f);
        currentVel.y = Mathf.Lerp(-1f, 1f, moveVal.normalized.y + 0.5f);

        // Applys your velocity.
        rb2.velocity = currentVel * moveVal.magnitude * moveSpeed * moveScaler;

        #region Animation States

        // Sets whether you're idle or not.
        animState = (rb2.velocity.magnitude == 0f) ? State.Idle : State.Moving;

        // Sets the direction you're moving in.
        if (Mathf.Abs(rb2.velocity.x) > Mathf.Abs(rb2.velocity.y))
            animDir = (rb2.velocity.x < 0f) ? Direction.Left : Direction.Right;
        else if (Mathf.Abs(rb2.velocity.x) < Mathf.Abs(rb2.velocity.y))
            animDir = (rb2.velocity.y < 0f) ? Direction.Down : Direction.Up;

        // Converts them into animation states.
        anim.SetInteger("State", (int)animState);
        anim.SetInteger("Direction", (int)animDir);

        #endregion
    }

    protected void StopMove()
    {
        Debug.Log("End Tap.");

        tapStartIcon.gameObject.SetActive(false);
        tapHoldIcon.gameObject.SetActive(false);

        // Stops all movement.
        rb2.velocity = Vector2.zero;
        
        // Sets animation state to idle.
        anim.SetInteger("State", 0);
    }
}
