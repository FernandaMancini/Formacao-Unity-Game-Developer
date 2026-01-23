using UnityEngine;

public class CheckpointController : MonoBehaviour
{
 public GameObject player;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject != player) return;

        // Atualiza o checkpoint no player
        Vector3 checkpointPosition = transform.position;
        player.SendMessage("SetCheckpoint", checkpointPosition, SendMessageOptions.DontRequireReceiver);

        // Opcional: efeito visual
        Debug.Log("Checkpoint ativado em: " + checkpointPosition);
    }
}
