using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackground : MonoBehaviour
{

    public Transform Center;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y >= Center.position.y + 3.42f)
            Center.position = new Vector2(Center.position.x, transform.position.y + 3.42f);

        else if (transform.position.y <= Center.position.y - 3.42f)
            Center.position = new Vector2(Center.position.x, transform.position.y - 3.42f);

        if (transform.position.x >= Center.position.x + 6.079999f)
            Center.position = new Vector2(Center.position.x, transform.position.y + 6.079999f);

        else if (transform.position.x <= Center.position.x - 3.42f)
            Center.position = new Vector2(Center.position.x, transform.position.y - 6.079999f);
    }
}
