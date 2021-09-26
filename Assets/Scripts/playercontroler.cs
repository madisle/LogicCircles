using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroler : MonoBehaviour
{
    public float speed = 1;
    public bool right;
    // Start is called before the first frame update
    void Start()
    {
        if (!right)
        {
            transform.Rotate(Vector3.forward * 180);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right*speed*Time.deltaTime);
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        DirectionalNode dn = collision.GetComponent<DirectionalNode>();
        Vector3 dir = Vector3.zero;
        float rot = 0;
        if (dn.current=="left")
        {
            dir = Vector3.forward;
            rot = 90;
        }
        else if (dn.current=="right")
        {
            dir = Vector3.back;
            rot = 90;
        }
        transform.Rotate(dir*rot);
    }
}
