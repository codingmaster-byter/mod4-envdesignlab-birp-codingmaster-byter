using UnityEngine;

public class Respawn : MonoBehaviour
{
    public Transform respawnPoint;
    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (transform.position.y < -5f)
        {
            controller.enabled = false;
            transform.position = respawnPoint.position;
            controller.enabled = true;
        }
    }
}