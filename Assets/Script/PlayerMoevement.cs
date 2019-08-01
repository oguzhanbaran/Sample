using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoevement : MonoBehaviour
{
    private Animator news;
    float hAxis, vAxis;
    // Start is called before the first frame update
    void Start()
    {
        news = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        hAxis = Input.GetAxis("Horizontal");
        vAxis = Input.GetAxis("Vertical");
        gameObject.transform.position += new Vector3(-hAxis * Time.deltaTime, 0, -vAxis * Time.deltaTime);
        
        if(Input.GetKeyDown(KeyCode.F))
        {
            news.SetTrigger("pick");
        }
    }
}
