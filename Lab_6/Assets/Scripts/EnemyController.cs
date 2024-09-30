using UnityEngine;

public class EnemyController : MonoBehaviour
{
<<<<<<< HEAD
    private float health = 0;

    private EnemyHealth enemyHealth;
=======
>>>>>>> 775a50f4808668894864e408ed2c40b70fe9d3f8
    private Animator animator;
    private ParticleSystem hitParticles;
    private AudioSource audioSource;

    void Start()
    {
        animator = GetComponent<Animator>();
        hitParticles = GetComponent<ParticleSystem>();
        audioSource = GetComponent<AudioSource>();
<<<<<<< HEAD
        enemyHealth = GetComponent<EnemyHealth>();
=======
>>>>>>> 775a50f4808668894864e408ed2c40b70fe9d3f8
    }

    public void GotHit()
    {
<<<<<<< HEAD
        if (enemyHealth != null) {
            enemyHealth.TakeDamage(50);
            animator.SetTrigger("GotHit");
            hitParticles.Play();
            audioSource.Play();
        }
=======
        animator.SetTrigger("GotHit");
        hitParticles.Play();
        audioSource.Play();
        GameManager.Instance.IncrementScore();
>>>>>>> 775a50f4808668894864e408ed2c40b70fe9d3f8
    }
}
