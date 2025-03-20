using UnityEngine;

public class BinHandler : MonoBehaviour
{
    private Touch touch;
    private float speedModifire;

    private void Start()
    {
        speedModifire = 0.02f;
    }

    private void Update()
    {
        MoveBin();
    }

    private void MoveBin()
    {
        if (Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * speedModifire,
                                                 transform.position.y + touch.deltaPosition.y * speedModifire,
                                                 transform.position.z);
            }
        }
    }
}
