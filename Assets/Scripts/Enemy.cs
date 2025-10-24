using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject target;

    [SerializeField] private float speed;
    void Start()
    {
        
    }

    void Update()
    {
        MoveToTarget();
    }
    public void MoveToTarget()
    {
        Vector3 dir = target.transform.position - transform.position;//Normalizada
        Vector3 normalizedDir = dir.normalized;

        transform.position += normalizedDir * speed * Time.deltaTime;
    }
}
