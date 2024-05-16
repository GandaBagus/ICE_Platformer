using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    [SerializeField] private float attackCooldown;
    [SerializeField] private int damage;
    [SerializeField] private AudioClip fireballsound;
    private Animator anim;
    private PlayerMovement playerMovement;
    private float cooldownTimer = Mathf.Infinity;

    private Health playerHealth;

    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject[] fireballs;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        playerMovement = GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.E) && cooldownTimer > attackCooldown)
        {
            Attack();
            
        }

        if (Input.GetKey(KeyCode.M) && cooldownTimer > attackCooldown)
        {
            anim.SetTrigger("melee");
        }
        cooldownTimer += Time.deltaTime;
    }
    private void Attack()
    {
        SoundManager.instance.PlaySound(fireballsound);
        anim.SetTrigger("attack");
        cooldownTimer = 0;

        fireballs[CheckFireball()].transform.position = firePoint.position;
        fireballs[CheckFireball()].GetComponent<Projectile>().SetDirection(Mathf.Sign(transform.localScale.x));
    }

    private int CheckFireball()
    {
        for(int i = 0; i < fireballs.Length; i++)
        {
            if (!fireballs[i].activeInHierarchy)
            {
                return i;
            }
        }
        return 0;
    }

    private void DamagePlayer()
    {
    
    playerHealth.TakeDamage(damage);

    }
}
