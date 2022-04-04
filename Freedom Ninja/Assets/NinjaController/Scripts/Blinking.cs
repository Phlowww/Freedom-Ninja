using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blinking : MonoBehaviour
{
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        InvokeRepeating(nameof(RandomTime), 1f, 26f);
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    void SetBlinking()
    {
        anim.SetTrigger("Blinking");
    }

    void RandomTime()
    {
        Invoke(nameof(SetBlinking), Random.Range(2f, 25f));
    }
}
