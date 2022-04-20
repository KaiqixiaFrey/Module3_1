using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cude : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Game.Instance.SetCoin();
            Destroy(this.gameObject);
        }
    }

}
