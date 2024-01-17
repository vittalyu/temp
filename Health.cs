using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public int health = 10;
    public int maxHealth = 10;
    public AudioSource audioSource;
    public AudioClip damageSound;
    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Çäîðîâüå èãðîêà: " + health);
        if (health > 0)
        {
            print("Health:" + health);
            audioSource.PlayOneShot(damageSound);
        }
        else
        {
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }
        print("Çäîðîâüå èãðîêà: " + health);
    }
}