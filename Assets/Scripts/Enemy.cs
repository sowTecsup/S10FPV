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
        SideDetector();
    }

    void Update()
    {
        MoveToTarget();
      
    }
    public void MoveToTarget()
    {
        if (Vector2.Distance(transform.position, target.transform.position) <= MovementRange)
        {
            SideDetector();
        }

        if (!IsLookingTarget()) return;

        
        if (Vector2.Distance(transform.position, target.transform.position) <= MovementRange)
        {
            SideDetector();
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
    public void SideDetector()
    {
        if(target.transform.position.x >= transform.position.x)
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
}
