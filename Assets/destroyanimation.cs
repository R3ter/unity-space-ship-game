﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyanimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, this.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length+.3f);
    }


}
