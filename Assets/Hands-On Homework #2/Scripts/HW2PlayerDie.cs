using UnityEngine;

public class HW2PlayerDie : MonoBehaviour
{
    private string Enemy = "Enemy";
    public GameObject endPanel;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Check the associated tag so the player doesn't die from hitting the side borders
        if(collision.gameObject.tag == Enemy)
        {
            //Kill the player
            gameObject.SetActive(false);
            //Change the canvas
            endPanel.SetActive(true);
        }
    }
}
