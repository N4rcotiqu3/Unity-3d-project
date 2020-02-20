using UnityEngine;

public class CollectGems : MonoBehaviour
{
    public AudioSource collectSound;

    void Start() 
    {
        CollectSystem1.theScore = 0;    
    }

    void OnTriggerEnter(Collider other)
    {
        collectSound.Play();
        CollectSystem1.theScore += 1;
        Destroy(gameObject);
    }    
}
