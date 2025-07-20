using UnityEngine;

public class Key : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "Player")
        {
            Player player = other.GetComponent<Player>();
            player.hasKey = true;
            Destroy(gameObject); // stavila sam da se "kljuc" unisti da izgleda kao da ga je player stvarno pokupio
        }
    }
}
