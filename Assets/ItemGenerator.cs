using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    public GameObject OrangePrefab;
    public GameObject GreenPrefab;
    public GameObject HurdlePrefab;
    private int startPos = -22519;
    private int goalPos = 2400;
    private float posRange = 3.4f;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = startPos; i < goalPos; i+=20)
        {
            int num = Random.Range(1, 11);
            if (num <= 2)
            {
                for (float j = -1; j <= 1; j += 0.4f)
                {
                    GameObject hurdle = Instantiate(HurdlePrefab);
                    hurdle.transform.position = new Vector3(4 * j, hurdle.transform.position.y, i);
                }
            }
            else
            {
                for (int j = -1; j <= 1; j++)
                {
                    int item = Random.Range(1, 11);
                    int offsetZ = Random.Range(-5, 6);
                    if (1 <= item && item <= 6)
                    {
                        GameObject orange = Instantiate(OrangePrefab);
                        orange.transform.position = new Vector3(posRange * j, orange.transform.position.y, i + offsetZ);
                    }
                    else if (7 <= item && item <= 9)
                    {
                        GameObject green = Instantiate(GreenPrefab);
                        green.transform.position = new Vector3(posRange * j, green.transform.position.y, i + offsetZ);
                    }
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
