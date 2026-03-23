using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Player player;

    [SerializeField] private Enemy enemy;
    [SerializeField] private TMP_Text playerName, playerHP, enemyName, enemyHP;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("player" + player.CharName);
        player.TakeDamage(3);
        enemy.TakeDamage(5);
        
    }

    private void UpdateUI()
    {
        playerName.text = player.CharName;
        enemyName.text = enemy.CharName;
        playerHP.text = "HP:" + player.health.ToString("F1");
        enemyHP.text = "HP:" + enemy.health.ToString("F1");

    }

    public void PlayerAttack()
    {
        player.Attack(enemy);
        enemy.Attack(player);
        UpdateUI();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
