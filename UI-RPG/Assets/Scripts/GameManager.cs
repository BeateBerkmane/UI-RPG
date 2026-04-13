using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Player player;

    [SerializeField] private Enemy enemy;
    [SerializeField] private Enemy enemyPrefab;
    [SerializeField] private UnityEngine.UI.Button attackButton;
    [SerializeField] private UnityEngine.UI.Button quitButton;
    [SerializeField] private TMP_Text gameOverText;
    [SerializeField] private UnityEngine.UI.Image enemyImage;
    [SerializeField] private UnityEngine.UI.Image playerImage;
    [SerializeField] private TMP_Text playerName, playerHP, enemyName, enemyHP;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemy = Instantiate(enemyPrefab, new Vector3(2,0,0), Quaternion.identity);
        UpdateUI();
        quitButton.gameObject.SetActive(false);
        
    }

    private void UpdateUI()
    {
        
        playerName.text = player.CharName;
        playerHP.text = "HP:" + Mathf.Max(0,player.health).ToString("F1");
        playerImage.sprite = player.PlayerSprite;
        
        enemyName.text = enemy.EnemyName;
        enemyHP.text = "HP:" + Mathf.Max(0, enemy.health).ToString("F1");
        enemyImage.sprite = enemy.EnemySprite;

    }

    public void PlayerAttack()
    {
        player.Attack(enemy);
        if (enemy.health > 0)
        {
            enemy.Attack(player);
        }
        
        UpdateUI();
        CheckDeath();
    }

    private void CheckDeath()
    {
        if (enemy.health <= 0)
        {
            SpawnNewEnemy();
            UpdateUI();
        }

        if (player.health <= 0)
        {
            Debug.Log("Player died! Game over.");
            attackButton.interactable = false;
            gameOverText.gameObject.SetActive(true);
            quitButton.gameObject.SetActive(true);
        }
    }

    private void SpawnNewEnemy()
    {
        Destroy(enemy.gameObject);
        
        enemy = Instantiate(enemyPrefab, new Vector3(2,0,0), Quaternion.identity);
        Debug.Log("New enemy spawned: " + enemy.EnemyName);
    }
    public void QuitGame()
    {
        Debug.Log("Quit pressed, exiting game.");
        Application.Quit();
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
