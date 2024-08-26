using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public gameManager gameManagerLogic;
    
    private void OnTriggerEnter (Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            gameManagerLogic.coinAdd();
            Destroy(gameObject);        
        }
        
    }
}
