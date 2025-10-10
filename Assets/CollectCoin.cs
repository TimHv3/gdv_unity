using UnityEngine;

public class CollectCoin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);

        if (other.tag == "Player")
        {
            gameObject.SetActive(false);
            Invoke(nameof(Respawn), 3f);
        }
    }
    void Respawn()
    {
        gameObject.SetActive(true);
    }


}
