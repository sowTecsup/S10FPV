using UnityEngine;


public enum ListaCustom
{
    None, //0
    Posion,//1
    Fire,//2
    Icechill//3
}

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
   /* private Vector2 up = new Vector2(0, 1);
    private Vector2 down = new Vector2(0, -1);
    private Vector2 left = new Vector2(-1, 0);
    private Vector2 right = new Vector2(1, 0);*/
    void Start()
    {
        //print(up.normalized);
    }

    void Update()
    {
        MovementSystem();
    }
    public void MovementSystem()
    {
        
        if(Input.GetKey(KeyCode.W))
        {
            Vector3 dir = Vector2.up;
            AddDirection(dir);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 dir = Vector2.down;
            AddDirection(dir);
        }
        if(Input.GetKey(KeyCode.D))
        {
            Vector3 dir = Vector2.right;
            AddDirection(dir);
        }
        if(Input.GetKey(KeyCode.A))
        {
            Vector3 dir = Vector2.left;
            AddDirection(dir);
        }
    }
    public void AddDirection(Vector3 dir)
    {
        transform.position += dir * speed * Time.deltaTime;
    }
}
