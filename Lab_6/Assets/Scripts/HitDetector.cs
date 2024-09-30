using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetector : MonoBehaviour
{
<<<<<<< HEAD


=======
>>>>>>> 775a50f4808668894864e408ed2c40b70fe9d3f8
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
<<<<<<< HEAD
            EnemyController enemyController =  other.GetComponent<EnemyController>();
            if (enemyController  != null)
=======
            EnemyController enemyController = other.GetComponent<EnemyController>();
            if (enemyController != null)
>>>>>>> 775a50f4808668894864e408ed2c40b70fe9d3f8
            {
                enemyController.GotHit();
            }
        }
    }
}
<<<<<<< HEAD

=======
>>>>>>> 775a50f4808668894864e408ed2c40b70fe9d3f8
