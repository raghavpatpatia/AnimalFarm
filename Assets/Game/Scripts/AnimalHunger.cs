using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnimalHunger : MonoBehaviour
{
    public Slider slider;
    public int amountToBeFed;
    private int currentAmountFed = 0;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        slider.maxValue = amountToBeFed;
        slider.value = 0;
        slider.fillRect.gameObject.SetActive(false);

        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void feedAnimal(int amount)
    {
        currentAmountFed += amount;
        slider.fillRect.gameObject.SetActive(true);
        slider.value = currentAmountFed;
        if(currentAmountFed >= amountToBeFed)
        {
            gameManager.Score(amountToBeFed);
            Destroy(gameObject, 0.1f);
        }
    }
}
