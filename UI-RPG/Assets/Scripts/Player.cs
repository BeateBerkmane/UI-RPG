using UnityEngine;

public class Player : Character
{
    [SerializeField] private Weapon activeWeapon;
    public override void Attack(Character enemytoHit)
    {
        enemytoHit.TakeDamage(activeWeapon);
        //float damage = activeWeapon.GetDamage();
        //enemytoHit.TakeDamage(damage);
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
