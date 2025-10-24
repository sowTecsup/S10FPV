using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject target;

    [SerializeField] private float speed;
    [SerializeField] private float MovementRange;
    [SerializeField] private float attackRange = 0.5f;

    [SerializeField] private Vector3 initialPos;
    void Start()
    {
        initialPos = transform.position;
    }

    void Update()
    {
        MoveToTarget();
    }
    public void MoveToTarget()
    {

        if(Vector2.Distance(transform.position, target.transform.position) <= MovementRange)
        {
            if (Vector2.Distance(transform.position, target.transform.position) <= attackRange)
            {
                print("Atacando al player");
            }
            else
            {
                Vector3 dir = target.transform.position - transform.position;//Normalizada
                Vector3 normalizedDir = dir.normalized;

                transform.position += normalizedDir * speed * Time.deltaTime;
            }

               
        }
        else
        {
            Vector3 dir = initialPos - transform.position;//Normalizada
            Vector3 normalizedDir = dir.normalized;
            transform.position += normalizedDir * speed * Time.deltaTime;
        }

     
    }
}
