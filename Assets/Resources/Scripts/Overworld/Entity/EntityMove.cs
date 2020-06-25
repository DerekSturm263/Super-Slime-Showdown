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
    [SerializeField] [Tooltip("The minimum speed the slime can move.")] public float moveSpeedMin = 2f;
    [SerializeField] [Tooltip("The maximum speed the slime can move.")] public float moveSpeedMax = 5f;
    private float currentSpeed;

    protected float maxDist; // Maximum length you can move the held tap between the original.

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
        Vector2 moveVect;

        if (isPlayer)
        {
            // Sets a distance float between the world positions of each tap icon.
            float tapDist = Vector2.Distance(tapPos, tapStartPos);

            if (tapDist <= maxDist)
            {
                tapHoldIcon.GetComponent<RectTransform>().anchoredPosition = tapPos - new Vector2(Screen.width, Screen.height) / 2f;
            }
            else
            {
                // Clamps the distance of the tap hold icon.
                tapHoldIcon.GetComponent<RectTransform>().anchoredPosition = tapStartPos + ( (tapPos - tapStartPos).normalized * maxDist ) - new Vector2(Screen.width, Screen.height) / 2f;
                tapDist = maxDist;
            }

            // Lerps speed.
            currentSpeed = Mathf.Lerp(moveSpeedMin, moveSpeedMax, tapDist / maxDist);

            // Sets a movement vector based on the position between where your finger started and where it is now.
            moveVect = (tapPos - tapStartPos).normalized;
        }
        else
        {
            moveVect = tapPos;

            // Sets speed.
            currentSpeed = moveSpeedMin * 1.5f;
        }

        // Sets an x and a y based on input.
        currentVel.x = Mathf.Lerp(-1f, 1f, moveVect.x + 0.5f);
        currentVel.y = Mathf.Lerp(-1f, 1f, moveVect.y + 0.5f);

        // Applies your velocity.
        rb2.velocity = currentVel * currentSpeed;

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
        Vector2 moveVal = new Vector2(g.transform.position.x - transform.position.x, g.transform.position.y - transform.position.y).normalized;

        // Sets an x and a y based on input.
        currentVel.x = Mathf.Lerp(-1f, 1f, moveVal.x + 0.5f);
        currentVel.y = Mathf.Lerp(-1f, 1f, moveVal.y + 0.5f);

        // Sets speed.
        currentSpeed = (moveSpeedMin + moveSpeedMax) / 2f;

        // Applies your velocity.
        rb2.velocity = currentVel * currentSpeed;

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
        currentSpeed = 0f;
        rb2.velocity = Vector2.zero;
        
        // Sets animation state to idle.
        anim.SetInteger("State", 0);
    }
}
