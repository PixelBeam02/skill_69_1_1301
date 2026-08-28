using Unity.VisualScripting;
using UnityEngine;

public class Flag : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Player player = other.gameObject.GetComponent<Player>();

        if (player == null)
            return;

        player.Point += 10;
        UIManager.instance.ShowNotiText($"+10 Points\nPoints: {player.Point}");
        Destroy(gameObject);
    }
}
