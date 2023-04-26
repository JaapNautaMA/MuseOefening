using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatThis : MonoBehaviour
{
    public float speed = 1f; // Speed of the floating motion
    public float xRange = 1f; // Maximum range of motion in x-axis
    public float yRange = 1f; // Maximum range of motion in y-axis

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position; // Record the starting position of the sprite
    }

    void Update()
    {
        float x = Mathf.Sin(Time.time * speed) * xRange;
        float y = Mathf.Cos(Time.time * speed) * yRange;

        // Generate a smooth random offset using Perlin noise
        float xOffset = Mathf.PerlinNoise(Time.time * 0.5f, 0f) * 2f - 1f;
        float yOffset = Mathf.PerlinNoise(0f, Time.time * 0.5f) * 2f - 1f;
        x += xOffset * 0.1f;
        y += yOffset * 0.1f;

        Vector3 newPos = startPos + new Vector3(x, y, 0f);
        transform.position = newPos;
    }
}
