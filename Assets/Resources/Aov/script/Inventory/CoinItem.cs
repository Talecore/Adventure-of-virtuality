 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinItem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("player") && other.GetType().ToString() == "UnityEngine.CapsuleCollider2D")
        {
            CoinUI.CuttentCoinQuantity += 1;
            SoundManager.playCoinClip();
            Destroy(gameObject);

        }
    }
}
