using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    [SerializeField] float checkPointTimeExtension = 5f;

    GameManager gameManager;

    const string playerString = "Player";

    void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(playerString))
        {
            gameManager.IncreaseTime(checkPointTimeExtension);
        }
    }
}
