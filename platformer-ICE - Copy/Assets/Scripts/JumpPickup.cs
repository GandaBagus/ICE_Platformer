using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPickup : MonoBehaviour
{
    [SerializeField] private AudioClip powerupsound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.tag == "player")
        {
            PlayerMovement player = collision.GetComponent<PlayerMovement>();
            player.jump *= 2.0f;
            SoundManager.instance.PlaySound(powerupsound);
            gameObject.SetActive(false);
        }
    }

    
}
