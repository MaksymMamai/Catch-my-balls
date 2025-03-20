using UnityEngine;

public class LostBin : MonoBehaviour
{
    private bool gotLostPosition;
    private Vector3 defaultBinPosition;

    private void Start()
    {
        gotLostPosition = false;
        defaultBinPosition = new Vector3(7, 2, 6);
    }

    private void Update()
    {
        IdentityGotLostPosition();
        BeckBinToGame();
    }

    private void IdentityGotLostPosition()
    {
        if(transform.position.x < -5 || transform.position.x > 20 || transform.position.y < -1.3 || transform.position.y > 11.5)
            gotLostPosition = true;
        else
            gotLostPosition = false;

    }

    private void BeckBinToGame()
    {
        if (gotLostPosition)
            transform.position = defaultBinPosition;
    }
}
