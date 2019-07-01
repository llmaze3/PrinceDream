using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackTrigger : MonoBehaviour
{
    public Collider2D girlWarrior;
    //Reference is the Collider other 
    public Canvas can;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("goblin"))
        {
            //like clicking the active checkbox. 
            other.gameObject.SetActive(false);
            //SetCountText();
            showGirl();
        }

    }
    void showGirl(){
        girlWarrior.gameObject.SetActive(true);
        can.gameObject.SetActive(true);
    }

}
