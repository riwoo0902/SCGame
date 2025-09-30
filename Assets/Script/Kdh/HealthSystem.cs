using System;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    [SerializeField] private int maxHealth = 100;
    private int minHealth = 0;

    public int currentHealth { get; private set; }
    public bool IsDead { get; private set; }

    public event Action<int, int> OnHealthChanged; // (현재 체력, 최대 체력)
    public event Action OnDeath;

    private void Awake()
    {
        
    }
    private void Start()
    {
        currentHealth = maxHealth;
        IsDead = false;
        OnHealthChanged?.Invoke(currentHealth, maxHealth);
        OnDeath?.Invoke();
    }

    public void Deal(int damage)
    {
        currentHealth = Mathf.Max(currentHealth - damage, minHealth);

        if (currentHealth == minHealth)
        {
            Death();
        }
    }

    public void Heal(int healAmount)
    {
        currentHealth = Mathf.Min(currentHealth + healAmount, maxHealth);
    }

    public void Death()
    {
        Debug.Log("죽음");
    }

}
