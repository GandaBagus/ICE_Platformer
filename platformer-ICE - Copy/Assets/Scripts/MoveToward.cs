using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToward : MonoBehaviour
{
    [SerializeField] private GameObject Lift;
    
    [SerializeField] private float speed = 1.5f;
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

    public void Naik()
    {
        transform.position = Vector2.MoveTowards(transform.position, Lift.transform.position, speed * Time.deltaTime);
    }

}
