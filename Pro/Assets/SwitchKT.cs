using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchKT : MonoBehaviour
{
    [SerializeField] private int _goNextKT;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.U))
        {
            SceneManager.LoadScene(_goNextKT);
        }
    }
}
