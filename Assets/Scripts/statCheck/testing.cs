using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class testing : MonoBehaviour
{

    [SterializeField] private PlayerStats playerStats;

    private void Start()
    {
        Debug.Log(playerStats.exptxt);
    }

}
