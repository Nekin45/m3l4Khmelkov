using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManager;

public class Player : MonoBehaviour
{
    //Максимальное здоровье игрока
    private int health = 10;

    //Число собранных монет
    public int coins;

    //Префаб огненнего шара и параметр Transform точки атаки
    public GameObject fireballPrefab;
    public Transform attackPoint;

    public AudioSourse audioSource;


    public AudioClip damageSound;


    //Метод, понижающий здоровье игрока
    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Здоровье игрока: " + health);
        {
            healt -= damage;

            if (health > 0)
            {
                audioSource.PlayOneShot(damageSounde);

            }

            else {
                int sceneIndex = SceneManger.GetActiveScene().buildIndex;
                sceneManager.LoadScene(sceneIndex);
            }

        }
    }

        //Метод, увеличивающий число монеток
        public void CollectCoins()
        {
            coins++;
            print("Собранные монетки: " + coins);
        }


        void Update()
        {

            //Если игрок кликает левой кнопкой мыши, то создаётся огненный шар
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
            }

        }
    } 
