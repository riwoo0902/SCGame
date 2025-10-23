using System.Collections;
using UnityEngine;

public class BossBullet : MonoBehaviour
{
    private Rigidbody2D _rigid;
    private void Awake()
    {
        _rigid = GetComponent<Rigidbody2D>();
        StartCoroutine(DieTime());
    }

    private IEnumerator DieTime()
    {
        yield return new WaitForSeconds(5f);
        Destroy(gameObject);
    }

    private void FixedUpdate()
    {
        _rigid.linearVelocity = new Vector2(0,-6);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out HealthSystem a))
        {
            a.Deal(1);
        }
    }
}
