
using UnityEngine;

public class RepeatRoad : MonoBehaviour
{
    private float offset;
    public GameObject road;
    public int roadCounter = 3;

    void Start()
    {
        offset = road.GetComponent<BoxCollider>().size.z;
    }

    void Update()
    {
        int counter = GameObject.FindGameObjectsWithTag("Ground").Length;

        if (counter < roadCounter)
        {
            Vector3 position = new Vector3(0, 0, offset * counter);
            Instantiate(road, position, road.transform.rotation);
        }
    }
}
