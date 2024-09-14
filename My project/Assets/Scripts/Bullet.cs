using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float damage=50f;
    
    private void OnCollisionEnter(Collision collision) {
        
        if (collision.gameObject.CompareTag("Target")) {
            
            BugController bug = collision.gameObject.GetComponent<BugController>(); 
            if (bug != null) {
                bug.Hit(25);
            }
            
        }
        Destroy(gameObject);
    }

}
