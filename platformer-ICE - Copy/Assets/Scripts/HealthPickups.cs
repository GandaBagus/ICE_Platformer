using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPickups : MonoBehaviour
{
    [SerializeField] private float HealthValue;
    [SerializeField] private AudioClip healthsound;
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
            collision.GetComponent<Health>().AddHealth(HealthValue);
            SoundManager.instance.PlaySound(healthsound);
            gameObject.SetActive(false);
        }
    }
}
