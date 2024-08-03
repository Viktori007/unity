/*using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Transform transform_p;
    [SerializeField] private float moveSpeed = 5f;
    private int i = 0;

    void Update()
    {
        Transform trans = transform_p;


        if (Input.GetKeyDown(KeyCode.D) || i == 1)
        {

            trans.position = new Vector3(trans.position.x + moveSpeed, trans.position.y, trans.position.z);
            Debug.Log("chlenxyevui");
            i = 1;
        }
        if (Input.GetKeyDown(KeyCode.A) || i == -1)
        {
            trans.position = new Vector3(trans.position.x - moveSpeed, trans.position.y, trans.position.z);
            Debug.Log("chlenxyevui2");
            i = -1;
        }

        //Debug.Log(i);
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            i = 0;
            Debug.Log("chlen");
        }
    }

    public void k_left()
    {
        i = -1;
    }

    public void k_right()
    {
        i = 1;
    }

    public void k_up()
    {
        i = 0;
    }
}*/