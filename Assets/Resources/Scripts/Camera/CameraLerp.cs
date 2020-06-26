using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraLerp : MonoBehaviour
{
    [SerializeField] private float lerpSpeed = 5f;

    [SerializeField] private float xMin = -10f, xMax = 10f;
    [SerializeField] private float yMin = -10f, yMax = 10f;

    private Vector2 positionNew;

    private void Awake()
    {
        positionNew = transform.position;
    }

    private void Update()
    {
        transform.position = Vector3.Lerp(transform.position, positionNew, Time.deltaTime * lerpSpeed);

        if (Vector2.Distance(transform.position, positionNew) < 1f)
            GetNewPosition();
    }

    private void GetNewPosition()
    {
        float posX = Random.Range(xMin, xMax);
        float posY = Random.Range(yMin, yMax);

        positionNew = new Vector2(posX, posY);
    }
}
