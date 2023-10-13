using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerscript : MonoBehaviour
{
    public Rigidbody rigidboady;
    public float force = 1000f;
    public float speed = 10f;
    public float minX;
    public float maxX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //For Preventing to fall from Ground

        Vector3 playerPos = transform.position;
        if (playerPos.x < minX)
        {
            playerPos.x = minX;
        }
        if (playerPos.x > maxX)
        {
            playerPos.x = maxX;
        }
        transform.position = playerPos;

        //Moving the object Left and Right 

        if (Input.GetKey(KeyCode.LeftArrow)||Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position - new Vector3(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.RightArrow)||Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(speed * Time.deltaTime, 0, 0); 
        }
        //transform.position = transform.localPosition + new Vector3(0, 0, 10f * Time.deltaTime);

    }
    private void FixedUpdate()
    {
        rigidboady.AddForce(0, 0, force*Time.deltaTime);

    }
}
