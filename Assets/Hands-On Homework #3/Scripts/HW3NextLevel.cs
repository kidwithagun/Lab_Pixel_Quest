using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine.SceneManagement;
using UnityEngine;

public class HW3NextLevel : MonoBehaviour
{
    public string nextLevel;

    void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.tag)
        {
            case "Castle":
                {
                    SceneManager.LoadScene(nextLevel);
                    break;
                }
        }
    }
}
