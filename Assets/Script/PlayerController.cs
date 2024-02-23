using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 5.0f;
    private CharacterController controller;
    public GameObject floor;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Debug.Log(horizontalInput+" "+verticalInput);
        var direction = new Vector3(horizontalInput, 0, verticalInput);
        var velocity = direction * speed;
        controller.Move(velocity * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            if(GetComponent<Rigidbody>().freezeRotation)
            {
                GetComponent<Rigidbody>().freezeRotation = false;
            }
            else
            {
                GetComponent<Rigidbody>().freezeRotation = true;
            }
        }

        if(Input.GetKeyDown(KeyCode.E))
        {
            //floor.GetComponent<MeshRenderer>().materials[0].color = new Color(Random.value, Random.value, Random.value);
            floor.GetComponent<MeshRenderer>().materials[0].SetColor(name: "_Color", new Color(Random.value, Random.value, Random.value));
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            gameObject.transform.localScale = new Vector3(3, 3, 3);
        }
    }
}
