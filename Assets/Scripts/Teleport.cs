using UnityEngine;

public class Teleport : MonoBehaviour
{
    private Player player;

    private void Start()
    {
        player = FindObjectOfType<Player>();
    }

    public void TeleportPlayer()
    {
        player.transform.position = transform.position;
    }
}
