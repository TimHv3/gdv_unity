using UnityEngine;

public class bobbing_movement : MonoBehaviour
{
    public float amplitude = 2.0f;
    public float frequency = 1.0f;
    private Vector3 startPosition;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        float newY = startPosition.y + amplitude * Mathf.Sin(Time.time * frequency);
        
        transform.position = new Vector3(startPosition.x, newY, startPosition.z);
    }
}
