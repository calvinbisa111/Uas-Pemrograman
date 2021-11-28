using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioClip coinSound;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
               
        if (collision.gameObject.tag.Equals("Player"))
        {
            print("Coin diambil");
            Destroy(gameObject);
            CoinScore.hitungCoin += 50;
            AudioSource.PlayClipAtPoint(coinSound, transform.position, 0.1f);
            
        }
    }
}
