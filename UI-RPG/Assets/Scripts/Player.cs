using UnityEngine;

public class Player : Character
{
    [SerializeField] private Weapon activeWeapon;
    [SerializeField] private Sprite playerSprite;
    [SerializeField] private Weapon currentWeapon;

    public Sprite PlayerSprite => playerSprite;
    public string CurrentWeaponName => currentWeapon.weaponName;
    public void SetWeapon(Weapon newWeapon)
    {
        currentWeapon = newWeapon;
    }
    public override void Attack(Character target)
    {
        float damage = currentWeapon.GetDamage();
        target.TakeDamage(damage);
        Debug.Log(CharName + " attacked " + target.CharName + " for " + damage);
        
        //float damage = activeWeapon.GetDamage();
        //enemytoHit.TakeDamage(damage);
    }
}
