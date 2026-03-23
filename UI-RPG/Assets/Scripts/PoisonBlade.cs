using UnityEngine;

public class PoisonBlade : Blade
{
    [SerializeField] private float poisonDamage;

    [SerializeField] private int poisonCount;

    public override float GetDamage()
    {
        float baseDamage = GetDamage();
        if (poisonCount > 0)
        {
            poisonCount--;
            return baseDamage + poisonDamage;
        }

        return baseDamage;
    }

}
