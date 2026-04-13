using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public string weaponName;
    
    public abstract float GetDamage();

    public virtual string GetWeaponName()
    {
        return weaponName;
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
