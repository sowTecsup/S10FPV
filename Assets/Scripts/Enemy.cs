using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject target;

    [SerializeField] private float speed;
    [SerializeField] private float MovementRange;
    [SerializeField] private float attackRange = 0.5f;

    [SerializeField] private Vector3 initialPos;

    [SerializeField] private Vector3 DirectionVision = Vector3.right;
    void Start()
    {
        initialPos = transform.position;
        SideDetector(target.transform.position);
    }

    void Update()
    {
        MoveToTarget();
      
    }
    public void MoveToTarget()
    {
        float distanceToTarget = Vector2.Distance(transform.position, target.transform.position);
        if (IsLookingTarget() && distanceToTarget <= MovementRange) 
        {
            SideDetector(target.transform.position);
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
            if (Vector2.Distance(initialPos, transform.position) >= 0.2f)
            {
                SideDetector(initialPos);
                Vector3 dir = initialPos - transform.position;//Normalizada
                Vector3 normalizedDir = dir.normalized;
                transform.position += normalizedDir * speed * Time.deltaTime;
            }
        }
    }
    public void SideDetector(Vector3 target)
    {
        if(target.x >= transform.position.x)
        {
            transform.localScale = new Vector3(1, 1, 1);
            DirectionVision = Vector3.right;
        }
        else
        {
            transform.localScale = new Vector3(-1, 1, 1);
            DirectionVision = Vector3.left;
        }
    }

    public bool IsLookingTarget()
    {
        Vector3 LookDirection = DirectionVision;
        Vector3 TargetDirection = (target.transform.position - transform.position).normalized;

        float doti = Vector3.Dot(LookDirection, TargetDirection);  
        
        if(doti >= 0)
        {
            print("Te veo");
            return true;
        }
        else
        {
            print("No Te veo");
            return false;
        }

    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, MovementRange);
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, attackRange);
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(transform.position, DirectionVision);
        Vector3 TargetDirection = (target.transform.position - transform.position).normalized;
        Gizmos.DrawRay(transform.position, TargetDirection);
    }
    
}
