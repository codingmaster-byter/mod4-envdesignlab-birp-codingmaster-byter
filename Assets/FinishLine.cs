using UnityEngine;
using TMPro;

public class FinishLine : MonoBehaviour
{
    public GameObject endScreen;

    void Update()
    {
        GameObject player = GameObject.FindWithTag("Player");
        if (player != null)
        {
            float distance = Vector3.Distance(transform.position, player.transform.position);
            if (distance < 3f)
            {
                endScreen.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}