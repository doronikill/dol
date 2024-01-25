using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private int health = 10;
    public GameObject fireballPrefab;
    public Transform AttackPoint;

     void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab,
      AttackPoint.
      position, AttackPoint.
      rotation);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            RestartLevel();
        }
        print("Здоровье игрока: " + health);
    }

    private void RestartLevel()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(currentScene.buildIndex);
    }
}
