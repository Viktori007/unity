using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnScripts : MonoBehaviour
{
    public int per;
    public Transform trans;
    private int i=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (i == 1)
            trans.position = new Vector3(transform.position.x - per, transform.position.y, transform.position.z);

        if (i == -1)
            trans.position = new Vector3(trans.position.x + per, trans.position.y, trans.position.z);
        k_left();
        k_right();
        
    }


    public void Jump_left()
    {
        if (trans.position.x < 540 + 360)
            i = -1;
            

    }

    public void Jump_center()
    {
        if (trans.position.x < 540 + 360*2)
            i = -1;


    }

    public void Jump_right()
    {
        if (trans.position.x < 540 + 1080)
            i = 1;
           
    }

    public void k_left()
    {
        if (Input.GetKeyDown(KeyCode.A))
            trans.position = new Vector3(540 + 360, transform.position.y, transform.position.z);


    }

    public void k_right()
    {
        if (Input.GetKeyDown(KeyCode.D))
            trans.position = new Vector3(540 + 360*2, transform.position.y, transform.position.z);


    }

}
