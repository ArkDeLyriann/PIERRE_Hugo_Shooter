using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ennemySpawner : MonoBehaviour
{
    public float timePassed = 0f;
    public ennemy myEnnemy;
    public ennemyTypeDeux myEnnemy2;
    public int nbEnnemy;
    public Transform myPlayer;
    public int wave = 0;
    // Start is called before the first frame update
    void Start()
    {
        Spawner();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(nbEnnemy <= 0)
        {
            wave++;

            if (wave%2 == 0)
            {
                Spawner();
            }
            else
            {
                Spawner2();
            }
        }

      

    }

    public void Spawner()
    {
        for (int k = -6; k < 1; k++)
        {
            Instantiate(myEnnemy2, new Vector3(6 + 2f * k, 4, 0), Quaternion.identity);
            print("un de plus");
            nbEnnemy++;
        }
        
        for (int j = -2; j < 2; j++)
        {
            for (int i = -9; i < 3; i++)
            {
                Instantiate(myEnnemy, new Vector3(2+1.2f*i, j, 0), Quaternion.identity);
                print("un de plus");
                nbEnnemy++;
            }
        }
       
        
    }

    public void Spawner2()
    {
        for (int j = -2; j < 2; j++)
        {
            for (int i = -9; i < 3; i++)
            {
                Instantiate(myEnnemy2, new Vector3(2 + 1.2f * i, j, 0), Quaternion.identity);
                print("un de plus");
                nbEnnemy++;
            }
        }

    }

}
