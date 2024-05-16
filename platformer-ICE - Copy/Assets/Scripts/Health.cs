using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float startingHealth;
    [SerializeField] private AudioClip deathsound;

    public float currentHealth {get; private set; }
    private Animator anim;
    public GameObject UI;
  
    // Start is called before the first frame update
    void Awake()
    {
        currentHealth = startingHealth;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        // if (Input.GetKeyDown(KeyCode.E))
        // {
        //     TakeDamage(1);
        // }
    }

    public void TakeDamage (float _damage)

    {
        currentHealth = Mathf.Clamp(currentHealth - _damage, 0 ,startingHealth);

        if (currentHealth > 0)
        {
            anim.SetTrigger("hurt");
        }
        else
        {
            anim.SetTrigger("die");
            SoundManager.instance.PlaySound(deathsound);
            GetComponent<PlayerMovement>().enabled = false;
            Destroy(gameObject);
            UI.SetActive(true);
            
        }
    }

    public void AddHealth(float _value)
    {
        currentHealth = Mathf.Clamp(currentHealth + _value, 0, startingHealth);
    }
}
