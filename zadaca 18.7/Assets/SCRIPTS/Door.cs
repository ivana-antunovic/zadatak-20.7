using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject player;
    private bool isPlayerNear = false;
    private bool doorOpened = false;

    void Update()
    {
        if (isPlayerNear && Input.GetKeyDown(KeyCode.E))
        {
            if (player.GetComponent<Player>().hasKey && !doorOpened)
            {
                transform.rotation = Quaternion.Euler(0, transform.eulerAngles.y + 90f, 0);
                doorOpened = true;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")  
        {
            isPlayerNear = true;
            
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "Player")
        {
            isPlayerNear = false;
        }
    }
}
// da budem iskrena, namucila sam se ko mali majmun sa ovom skriptom. trebalo mi je sto godina i puno pomoci da spojim sve što treba a skripta uopce nije velika
// boze pomozi
//nisam stavljala da se vrata postepeno otvaraju jer se za sada zelim drzati jednostavnih stvari, ako je to ok
