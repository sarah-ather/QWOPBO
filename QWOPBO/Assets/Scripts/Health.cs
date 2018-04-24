using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Health : MonoBehaviour
{
    public float m_StartingHealth = 100f;               // The amount of health each tank starts with.
    private Slider m_Slider;                             // The slider to represent how much health the tank currently has.
    private Slider m_Slider_enemy;                             // The slider to represent how much health the tank currently has.
                                                        //public Image m_FillImage;                           // The image component of the slider.
                                                        //public Color m_FullHealthColor = Color.green;       // The color the health bar will be when on full health.
                                                        //public Color m_ZeroHealthColor = Color.red;         // The color the health bar will be when on no health.
    private float m_CurrentHealth;                      // How much health the tank currently has.
    private bool m_Dead;                                // Has the tank been reduced beyond zero health yet?
    private Ragdoll_controller ragdollStatus;
    private GameObject player;


    private void Awake()
    {

    }

    private void Start()
    {
        m_CurrentHealth = m_StartingHealth;
        m_Dead = false;
        ragdollStatus = GetComponent<Ragdoll_controller>();
        m_Slider = GameObject.FindWithTag("PlayerHealth").GetComponent<Slider>();
        m_Slider_enemy = GameObject.FindWithTag("EnemyHealth").GetComponent<Slider>();
        player = GameObject.FindWithTag("Player");
    }

    private void OnEnable()
    {
        // When the tank is enabled, reset the tank's health and whether or not it's dead.
        /*m_CurrentHealth = m_StartingHealth;
        m_Dead = false;
        ragdollStatus = GetComponent<Ragdoll_controller>();*/

        // Update the health slider's value and color.
        //SetHealthUI();
    }


    public void TakeDamage(float amount)
    {
        // Reduce current health by the amount of damage done.
        m_CurrentHealth -= amount;
        print(m_CurrentHealth + ": Current health for " + gameObject.name);
        // Change the UI elements appropriately.
        SetHealthUI();

        // If the current health is at or below zero and it has not yet been registered, call OnDeath.
        if (m_CurrentHealth <= 0f && !m_Dead)
        {
            OnDeath();
        }
    }


    private void SetHealthUI()
    {
        // Set the slider's value appropriately.
        if (gameObject.name == "Player(Clone)")
        {
            m_Slider.value = m_CurrentHealth;
        }
        if (gameObject.name == "Enemy(Clone)")
        {
            m_Slider_enemy.value = m_CurrentHealth;
        }
        

        // Interpolate the color of the bar between the choosen colours based on the current percentage of the starting health.
        //m_FillImage.color = Color.Lerp (m_ZeroHealthColor, m_FullHealthColor, m_CurrentHealth / m_StartingHealth);
    }


    private void OnDeath()
    {
        // Set the flag so that this function is only called once.
        m_Dead = true;
        ragdollStatus.SetKinematic(false);
        //GetComponent<Collider>().enabled = false;
        GetComponent<Animator>().enabled = false;
        if (gameObject.name == "Player(Clone)")
        {
            GetComponent<PlayerMovement>().enabled = false;
        }
        if (gameObject.name == "Enemy(Clone)")
        {
            GetComponent<StateController>().enabled = false;
            GetComponent<Collider>().enabled = false;
            //if (this.name == "Player(Clone)")
            //{
            player.GetComponent<EmitterController>().enabled = true;
            //}
            StartCoroutine(Wait());

        }
        //ragdollStatus.playerHealth = m_Dead;
        //gameObject.SetActive(false);
    }
    private IEnumerator Wait()
    {
        yield return new WaitForSeconds(3f);
        LoadScene();
    }

    private void LoadScene()
    {
        SceneManager.LoadScene("End");
    }
}
