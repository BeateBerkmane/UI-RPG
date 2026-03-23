using UnityEngine;

public class Enemy : Character
{
    [SerializeField] private float minDamage, maxDamage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void Attack(Character enemytoHit)
    
    {
        float damage = Random.Range(minDamage, maxDamage);
        enemytoHit.TakeDamage(damage);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
