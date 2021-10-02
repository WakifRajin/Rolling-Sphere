using UnityEngine;

public class CoinScript : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0, 0 ,90 * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            other.GetComponent<Point>().points++;
            Destroy(gameObject);
        }
    }
}
