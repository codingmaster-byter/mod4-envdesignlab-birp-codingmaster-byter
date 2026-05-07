using UnityEngine;

public class Collectible : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(0, 90 * Time.deltaTime, 0);
        
        GameObject player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            float distance = Vector3.Distance(transform.position, player.transform.position);
            if (distance < 2f)
            {
                GameManager.score++;
                Destroy(gameObject);
            }
        }
    }
}