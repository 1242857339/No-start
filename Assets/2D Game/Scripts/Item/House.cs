using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class House : MonoBehaviour
{
    bool isDoor = false;

    void Update()
    {
        if(isDoor&&Player.move.y>0) SceneManager.LoadScene("Present Level");
    }

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player") isDoor = true;
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player") isDoor = false;
    }
}
