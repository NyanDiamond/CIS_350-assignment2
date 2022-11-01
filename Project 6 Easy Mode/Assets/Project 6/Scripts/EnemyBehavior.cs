using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class EnemyBehavior : Target
{
    //public AudioClip clip;
    // Start is called before the first frame update
    protected override void Die()
    {
        AudioSource.PlayClipAtPoint(Resources.Load<AudioClip>("Right"), FindObjectOfType<Camera>().transform.position);
        base.Die();
    }
}
