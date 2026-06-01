using UnityEngine;

public class Player : MonoBehaviour
{
    public float Health;
    public float Speed;

    public float MaxTime = 10;
    public float currentTime;

    public bool isAbilityAblive = true;
    void Start()
    {
        
    }
    void Update()
    {
        if(!isAbilityAblive)
        {
            TimerToDoSmt();
        }
    }
    public void MoventPlayer()
    {
        //AXix
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        Vector3 direction = new Vector3(x, y, 0);
        direction.Normalize();

        transform.position += direction * Speed * Time.deltaTime; 

    }
    public void SimpleAttack()
    {
        if(isAbilityAblive)
        {
            //->hago lo que tenga que hacer
            isAbilityAblive = false;
        }
    }
    public void TimerToDoSmt()
    {
        currentTime += Time.deltaTime;
        if(currentTime >= MaxTime)
        {
            //-> ejecutar algo
            isAbilityAblive = true;

            currentTime = 0;
        }
    }
}
