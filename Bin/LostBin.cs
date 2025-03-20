using UnityEngine;

public class LostBin : MonoBehaviour
{
    private bool gotLostPosition;
    private Vector3 defaultBinPosition;

    private void Start()
    {
        gotLostPosition = false;
        defaultBinPosition = new Vector3(-0.76f, -2.2f, 6); 
    }

    private void Update()
    {
        IdentityGotLostPosition();
        BeckBinToGame();
    }

    private void IdentityGotLostPosition()
    {
        if(transform.position.x < -14 || transform.position.x > 12 || transform.position.y < -7 || transform.position.y > 7)
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
