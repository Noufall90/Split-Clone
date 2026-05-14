using UnityEngine;

public class HealthPlayer : MonoBehaviour
{
    [Header("Health")]
    [SerializeField] protected int maxHealth;
    [SerializeField] protected int currentHealth;

    [Header("UI")]
    [SerializeField] private BarHUD healthHUD;

    private bool isDead = false;

    private void Start()
    {
        currentHealth = maxHealth;

        UpdateHealthUI();
    }

    public void TakeDamage(int damage)
    {
        if (isDead) return;

        currentHealth -= damage;

        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        UpdateHealthUI();

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public void Heal(int amount)
    {
        if (isDead) return;

        currentHealth += amount;

        currentHealth = Mathf.Clamp(currentHealth, 0, maxHealth);

        UpdateHealthUI();
    }

    private void UpdateHealthUI()
    {
        if (healthHUD != null)
        {
            healthHUD.UpdateUI(currentHealth, maxHealth);
        }
    }

    private void Die()
    {
        isDead = true;

        Debug.Log("Player Dead");
    }
}