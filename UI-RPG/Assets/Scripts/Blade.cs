using UnityEngine;

public class Blade : Weapon
{
    public float minDamage, maxDamage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override float GetDamage()
    {
        return Random.Range(minDamage, maxDamage);
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
