using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class performance : MonoBehaviour
{
    private Animator anim;
    public ParticleSystem particle;
    public ParticleSystem particled;
    void Start()
    {
        anim=GetComponent<Animator>(); 
    }

    // Update is called once per frame
    void Update()
    {
       if (anim!=null)
        {
            if (Input.GetKeyDown(KeyCode.X))
            {
                anim.SetTrigger("gracias");
            }
            if (Input.GetKeyDown(KeyCode.C))
            {
                anim.SetTrigger("Recitando");
            }
        }
    }
    public void AttackEffect()
    {
        particle.Play();

    }
    public void AttackEffectd()
    {
        particled.Play();

    }
}
