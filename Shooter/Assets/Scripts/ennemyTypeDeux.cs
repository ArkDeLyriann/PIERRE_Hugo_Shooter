using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ennemyTypeDeux : MonoBehaviour
{
    
    public GameObject bullet;
    private Vector3 descends;
    public Transform parent;
    private float time;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if(time >= 3)
        {
            EnnemyShoot();
        }
    }


    public void EnnemyShoot()
    {


        Instantiate(bullet, descends, parent.rotation);
    }
}
