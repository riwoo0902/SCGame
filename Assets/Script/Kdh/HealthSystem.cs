using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class HealthSystem : MonoBehaviour
{
    [SerializeField] private int maxHealth;
    private int minHealth = 0;

    public int currentHealth { get; private set; }
    public bool IsDead { get; private set; }

    public event Action OnHealthChanged; 
    public event Action OnDeath;

    private void Start()
    {
        currentHealth = maxHealth;
        IsDead = false;
    }

    public void Deal(int damage)
    {
        currentHealth = Mathf.Max(currentHealth - damage, minHealth);
        OnHealthChanged?.Invoke();

        Debug.Log("µô");

        if (currentHealth == minHealth)
        {
            Death();
        }
    }

    public void Heal(int healAmount)
    {
        currentHealth = Mathf.Min(currentHealth + healAmount, maxHealth);
        OnHealthChanged?.Invoke();
        Debug.Log("Èú");
    }

    public void Death()
    {
        if (IsDead) return; 
        IsDead = true;
        Debug.Log("Á×À½");
        OnDeath?.Invoke();
    }

}
