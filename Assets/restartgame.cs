﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class restartgame : MonoBehaviour
{

public void restart()
    {
        SceneManager.LoadScene("gamePlay");
    }

    
}
