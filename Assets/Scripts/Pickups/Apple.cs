using UnityEngine;

public class Apple : Pickup
{
    [SerializeField] float adjustChangeMoveSpeedAmount = 3f;
    [SerializeField] AudioClip appleVoiceLine;

    LevelGenerator levelGenerator;

    public void Init(LevelGenerator levelGenerator)
    {
        this.levelGenerator = levelGenerator;
    }

    protected override void OnPickup()
    {
        levelGenerator.ChangeChunkMoveSpeed(adjustChangeMoveSpeedAmount);

        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            AudioSource playerAudio = player.GetComponent<AudioSource>();
            if (playerAudio != null && appleVoiceLine != null)
            {
                playerAudio.PlayOneShot(appleVoiceLine);
            }
        }
    }
}
