using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Transform transform_p;
    [SerializeField] private SpriteRenderer sprt;
    [SerializeField] private float moveSpeed = 5f;
    private int i = 0;
    [SerializeField] private Button Btn;

    void Update()
    {
        Transform trans = transform_p;
       


        if (Input.GetKeyDown(KeyCode.D))
            i = 1;
        if (Input.GetKeyDown(KeyCode.A))
            i = -1;


        if (i == 1)
        {

            trans.position = new Vector3(trans.position.x + moveSpeed, trans.position.y, trans.position.z);
            Debug.Log("chlenxyevui");
            sprt.flipX = false;
            i = 1; 

        }
        if (i == -1)
        {
            trans.position = new Vector3(trans.position.x +(- moveSpeed), trans.position.y, trans.position.z);
            Debug.Log("chlenxyevui2");
            i = -1;
            sprt.flipX = true;
        }

        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            i = 0;
        }

    }

  



    public void k_up()
    {
        i = 0;
        Debug.Log("Button 2");
    }

    public void k_left()
    {
        i = -1;
        Debug.Log("Button1");
    }

    public void k_right()
    {
        i = 1;
        Debug.Log("Button released");
    }



}