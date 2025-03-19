using UnityEngine;

public class SpaceBodyParalax : MonoBehaviour
{
    private Touch touch;
    private float speedModifire;

    private void Start()
    {
        LayerDefinition();
    }

    private void Update()
    {
        ParallaxSpace();
    }

    private void ParallaxSpace()
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

    private void LayerDefinition()
    {
        if (gameObject.tag == "ParallaxGroup1")
            speedModifire = 0.0003f;

        if (gameObject.tag == "ParallaxGroup2")
            speedModifire = 0.0005f;

        if (gameObject.tag == "ParallaxGroup3")
            speedModifire = 0.0008f;

        if (gameObject.tag == "ParallaxGroup4")
            speedModifire = 0.0002f;
    }
}
