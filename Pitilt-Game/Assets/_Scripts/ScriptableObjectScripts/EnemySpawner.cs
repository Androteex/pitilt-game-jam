using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public EnemyScript[] enemies;

    private void Start()
    {
        foreach(EnemyScript enemy in enemies)
        {
            Debug.Log(enemy.name);
        }
    }

    void SpawnEnemy()
    {

    }
}
