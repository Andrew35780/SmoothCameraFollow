using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Transform player;

    private void FixedUpdate()
    {
        if (player.position.y < -2)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
