using UnityEngine;

public class Enemy : Character
{
    [Header("Random Enemy settings")] [SerializeField]
    private string[] possibleNames;

    [SerializeField] private float minHP = 10f;
    [SerializeField] private float maxHP = 20f;

    [SerializeField] private Sprite[] possibleSprites;

    [Header("Damage settings")]
    [SerializeField] private float minDamage = 2f;
    [SerializeField] private float maxDamage = 6f;

    public string EnemyName { get; private set; }
    public Sprite EnemySprite { get; private set; }

    void Awake()
    {
        EnemyName = possibleNames[Random.Range(0, possibleNames.Length)];
        health = Random.Range(minHP, maxHP);
        EnemySprite = possibleSprites[Random.Range(0, possibleSprites.Length)];
    }

    public override void Attack(Character target)

    {
        float damage = Random.Range(minDamage, maxDamage);
        target.TakeDamage(damage);
        Debug.Log(EnemyName + "attacked" + target.CharName + "for" + damage);
    }
}
