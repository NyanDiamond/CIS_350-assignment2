using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*Josh Bonovich
 *Prototype2
 *This script is to move object forward
 */
public class MoveForward : MonoBehaviour
{

    public float speed = 40;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
