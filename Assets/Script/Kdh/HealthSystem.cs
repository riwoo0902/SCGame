using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class HealthSystem : MonoBehaviour
{
    [SerializeField] private int maxHealth;
    private int minHealth = 0;

    public int currentHealth { get; private set; }
    public bool IsDead { get; private set; }

    public event Action OnHealthChanged; 
    public UnityEvent OnDeath;

    private bool canDamage = true;
    private void Start()
    {
        currentHealth = maxHealth;
        IsDead = false;
    }

    public void Deal(int damage)
    {
        if (canDamage)
        {
            currentHealth = Mathf.Max(currentHealth - damage, minHealth);
            OnHealthChanged?.Invoke();
            StartCoroutine(SetCandamage());
            Debug.Log("µô");

            if (currentHealth == minHealth)
            {
                Death();
            }
        }
        
    }
    private IEnumerator SetCandamage()
    {
        canDamage = false;
        yield return new WaitForSeconds(0.2f);
        canDamage = true;
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
        StartCoroutine(Dead());
    }
    private IEnumerator Dead()
    {
        yield return new WaitForSeconds(3f);
        OnDeath?.Invoke();
    }

}
