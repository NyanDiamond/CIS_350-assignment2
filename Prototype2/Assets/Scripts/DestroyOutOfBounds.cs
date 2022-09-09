using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Josh Bonovich
 *Prototype2
 *This script is used to destroy out of bounds objects
 */
public class DestroyOutOfBounds : MonoBehaviour
{
    public float topBound = 20;
    public float bottomBound = -10;
    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > 20 || transform.position.z < -10)
        {

            if (transform.position.z<-10)
            {
                FindObjectOfType<HealthSystem>().TakeDamage();
            }
            Destroy(gameObject);
        }
    }
}
