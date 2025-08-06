using UnityEngine;

public class Coin : Pickup
{
    [SerializeField] int scoreAmount = 100;
    [SerializeField] AudioClip pickupSound;

    private ScoreManager scoreManager;
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    public void Init(ScoreManager scoreManager)
    {
        this.scoreManager = scoreManager;
    }

    protected override void OnPickup()
    {
        scoreManager?.IncreaseScore(scoreAmount);

        if (pickupSound != null)
        {
            AudioSource.PlayClipAtPoint(pickupSound, transform.position, 2.0f);
        }
    }
}
