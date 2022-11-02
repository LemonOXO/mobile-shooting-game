using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyhp : MonoBehaviour
{
    private float hp = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Bullet")
        {
            hp -= 25;
            if(hp<=0)
            {
                gameObject.SetActive(false);
                Destroy(gameObject);
            }
        }
    }
}
