using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{


    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GameController.Instance.SetCoin();
            Destroy(this.gameObject);
        }
    }

}
