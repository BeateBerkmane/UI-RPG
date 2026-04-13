using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public float health;
    [SerializeField]
    private string charName;

    public string CharName
    {
        get { return charName; }
        
    }

    public float Health
    {
        get { return health; }
        set { health = Mathf.Max(0, value); }
    }

    public abstract void Attack (Character toHit);
    
    

    public void TakeDamage(float damage)
    {
        health -= damage;
        Debug.Log(charName + " took " + damage + 
                  " damage! Health:" + health);
    }

    public void TakeDamage(Weapon thrownWeapon)
    {
        float damage = thrownWeapon.GetDamage();
       TakeDamage(damage);
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
