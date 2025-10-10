using UnityEditor.Rendering;
using UnityEngine;

public class Health_status : MonoBehaviour
{
    public int Health = 100;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Health > 80)
        {
            Debug.Log("Excellent health");
        }
        else if (Health > 50)
        {
            Debug.Log("good health");
        }
        else if (Health > 20)
        {
            Debug.Log("Warning: low health");
        }
        else
        {
            Debug.Log("Critical: Very low health");
        }

        if (Input.GetKeyDown(KeyCode.H) && (Health > 0))
        {
            Debug.Log("You have taken damage");
            Health = Health - 10;
        }
        if (Input.GetKeyDown(KeyCode.J) && (Health < 100))
        {
            Debug.Log("You have healed yourself for 10 HP");
            Health = Health + 10;
        }
        if (Health == 0)
        {
            Debug.Log("Game Over!");
        }
    }
}
