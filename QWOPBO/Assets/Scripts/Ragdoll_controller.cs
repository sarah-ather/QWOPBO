using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ragdoll_controller : MonoBehaviour
{

    //public int maxHp = 10;
    //private int hp;
    public Rigidbody m_Rigidbody;              // Reference used to move the tank.
    //public GameObject enemyl;
    //public Collider enemyCollider;
    public Health healthStatus;
    //public bool playerHealth;

    public void SetKinematic(bool newValue)
    {
        Rigidbody[] bodies = GetComponentsInChildren<Rigidbody>();
        foreach (Rigidbody rb in bodies)
        {
            rb.isKinematic = newValue;
        }
        //m_Rigidbody.isKinematic = true ;
    }
    void Start()
    {
        //m_Rigidbody = GetComponent<Rigidbody>
        //SetKinematic(true);
        //hp = maxHp;
        //healthStatus = GetComponent<Health>();
        //print(healthStatus.m_StartingHealth);
    }
    private void OnEnable()
    {
        //healthStatus = GetComponent<Health>();
    }
    /*public void Damage(DamageInfo info)
    {
        if (hp <= 0) return;
        hp -= info.damage;
        if (hp <= 0) Die();
    }*/
    /*private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == enemyl)
        {
            SetKinematic(false);
            GetComponent<Animator>().enabled = false;
            print(collision.gameObject + "Collision Detected");
        }
        //Destroy(gameObject, 5);
    }*/

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "xbot_player_ragdoll(Clone)" && other.gameObject.tag != "Player")
        {
            //SetKinematic(false);
            //GetComponent<Animator>().enabled = false;
            healthStatus.TakeDamage(10);
            //print(other.gameObject + "Collision Detected with Xbot");
        }
        if (other.gameObject.name == "ybot_enemy_ragdoll(Clone)" && other.gameObject != this)
        {
            healthStatus.TakeDamage(10);
            //print(other.gameObject + "Collision Detected with Ybot");
        }
        if (other.gameObject.name == "Enemy(Clone)" && other.gameObject != this)
        {
            healthStatus.TakeDamage(5);
            //print(other.gameObject + "Collision Detected with Ybot");
        }
        /*if (playerHealth == true)
        {
            SetKinematic(false);
            GetComponent<Animator>().enabled = false;
        }*/
        /*if (other.gameObject.name == "ybot_enemy_ragdoll(Clone)")
        {
            SetKinematic(false);
            GetComponent<Animator>().enabled = false;
        }*/
        //print(collision.gameObject + "Collision Detected");
    }
}
