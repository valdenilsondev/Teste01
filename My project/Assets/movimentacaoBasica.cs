using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentacaoBasica : MonoBehaviour
{


    private Rigidbody rb;
    public float speed, movHorizontal, movVertical;
   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        movHorizontal = Input.GetAxisRaw("Horizontal");

        movVertical = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector3(movHorizontal * speed, 0, movVertical *speed);



    }
}
