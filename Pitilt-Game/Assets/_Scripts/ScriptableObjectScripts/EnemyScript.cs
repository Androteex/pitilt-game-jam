using UnityEngine;

[CreateAssetMenu(menuName = "Enemy", fileName = "New Enemy")]
public class EnemyScript : ScriptableObject
{
    public new string name;

    public GameObject prefab;

    public float speed;
    public int health;
    public bool isAlive;
}
