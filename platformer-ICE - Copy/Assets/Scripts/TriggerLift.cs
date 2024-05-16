using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLift : MonoBehaviour
{
    [SerializeField] private GameObject Lift;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = Vector2.MoveTowards(transform.position, Lift.transform.position, speed * Time.deltaTime);
        //Naik();
    }


    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == "player")
        {
            Lift.GetComponent<MoveToward>().Naik();
            Debug.Log("Collided");
        }
        
    }
}
