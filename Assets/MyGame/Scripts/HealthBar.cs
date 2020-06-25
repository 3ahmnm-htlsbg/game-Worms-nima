using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthBar : MonoBehaviour

{

    public Slider slider;

    public float maxHealth = 25;
    public float currentHealth;

    public GameObject winnerText;



    void Start()
    {
        slider.value = maxHealth;
        currentHealth = slider.value;
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "projectile")
        {
            slider.value -= 1;
            currentHealth = slider.value;
        }
    }


    void Update()
    {
        if (slider.value == 0)
        {
            winnerText.SetActive(true);
            StartCoroutine(LoadScene());
            
        }
    }

    public IEnumerator LoadScene()
    {
        yield return new WaitForSeconds(4);
        SceneManager.LoadScene("GameOver");
    }

}
