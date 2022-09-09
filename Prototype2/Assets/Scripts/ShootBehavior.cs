using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Josh Bonovich
 *Prototype2
 *This script is used to shoot a food
 */
public class ShootBehavior : MonoBehaviour
{
    public GameObject prefabToShoot;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(prefabToShoot, transform.position, prefabToShoot.transform.rotation);
        }
    }
}
