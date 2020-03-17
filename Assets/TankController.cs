using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankController : MonoBehaviour
{
    [Range(0.0f, 20.0f)]
    public float speed = 5.0f;

    [Range(0.0f, 360.0f)]
    public float rotSpeed = 5.0f;

    public GameObject bulletPrefab;
    public Transform bulletSpawnPoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, Input.GetAxis("Vertical") * speed * Time.deltaTime);
        transform.Rotate(0, rotSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0);

        if (Input.GetKeyDown(KeyCode.Joystick1Button0) || Input.GetKeyDown(KeyCode.Space))
        {
            GameObject bullet = GameObject.Instantiate<GameObject>(bulletPrefab
                ,bulletSpawnPoint.position
                ,bulletSpawnPoint.rotation
                );
        }
    }
}
