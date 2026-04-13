using UnityEngine;

public class Bow : Weapon
{
    [SerializeField] private float minDamage;
    [SerializeField] private float maxDamage;

    [SerializeField] private float critChange = 0.25f;
    [SerializeField] private float critMultiplier = 2f;

    public override float GetDamage()
    {
        float damage = Random.Range(minDamage, maxDamage);
        if (Random.value < critChange)
        {
            damage *= critMultiplier;
            Debug.Log("Critical hit!");
        }
        return damage;
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
