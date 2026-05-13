using UnityEngine;

public class BonusItem : MonoBehaviour
{
    [HideInInspector]
    public int bonusScore = 5;

    void Start()
    {
        Collider2D col = GetComponent<Collider2D>();
        if (col != null)
            col.isTrigger = true;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (!other.CompareTag("Player"))
            return;

        GameManager.Instance?.AddScore(bonusScore);
        Destroy(gameObject);
    }
}
