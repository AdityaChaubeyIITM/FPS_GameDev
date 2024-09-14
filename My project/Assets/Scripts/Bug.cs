using UnityEngine;

public class BugController : MonoBehaviour
{
    public float speed = 3.0f;    
    private Transform player;     
    private Animator animator;  
    public float life = 100f;  

    void Start()
    {
        
        player = GameObject.FindGameObjectWithTag("Player").transform;
        animator = GetComponent<Animator>();
        animator.Play("Walk");
    }
    void Update()
    {
        
        if (player != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
            Vector3 direction = player.position - transform.position;
            Quaternion rotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * speed);
        }
    }
    public void Hit(float damage){
        life-=damage;
        if(life<=0){
            GameManager manager = FindObjectOfType<GameManager>();
            manager.enemies--;
          
            Destroy(gameObject);
        }
    }
}
