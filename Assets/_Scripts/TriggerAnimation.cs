using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{

    [SerializeField] private Animator isDead;
    [SerializeField] private string playerDeath = "Death";

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isDead.Play(playerDeath, 0, 0.0f);
        }
    }
}