using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Timer_Script : MonoBehaviour
{
    public float StartTimer;
    [SerializeField] private float timer;
    [SerializeField] private float timer2 = 1;
    [SerializeField] private Image TextMashPro;
    [SerializeField] private TextMeshProUGUI Text;
    [SerializeField] private TextMeshProUGUI WoodAmount;
    [SerializeField] private Button MyButton;
    [SerializeField] private Slider MySlider;
    [SerializeField] private TextMeshProUGUI Upper;
    private bool a;
    private float b;
    private float wood = 20;
    private float level = 1f;
    private float price = 30f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (wood < 5)
        {
            MyButton.enabled = false;
        }
        else
        {
            MyButton.enabled = true;
        }
        UITimer();
        eshkere();
        Timer2();
        WoodUpdate();
    }
    private void UITimer()
    {
        if (a && timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else if (timer <= 0)
        {
            a = false;
        }
    }
        IEnumerator UI()
    {
        timer = StartTimer;
        yield return new WaitForSecondsRealtime(0.1f);
        a = true;
    }
    public void eshkere()
    {
        if (timer > 0)
        {
            TextMashPro.fillAmount = timer/StartTimer;
        }
        if (timer <= 0)
        {
            TextMashPro.fillAmount = 1;
        }
    }
    public void Button()
    {
        wood -= 5;
        StartCoroutine(UI());
        b += level;
        Text.text = $"—четчик: {b}";
    }
    public void Timer2()
    {
        if (timer2 <= 0)
        {
            timer2 = 1;
            wood += level;
        }
        else
        {
            MySlider.value = timer2;
            timer2 -= Time.deltaTime;
        }
    }
    public void WoodUpdate()
    {
        WoodAmount.text = $"Wood: {wood}";
    }
    public void LevelUp()
    {
        if (wood >= price)
        {
            wood -= price;
            level = price * 0.05f;
            price = price * 1.3f;
            Upper.text = $"Price {price}";
        }
    }
    public void Clicker()
    {
        b += level;
        wood += level;
        Text.text = $"—четчик: {b}";
    }
}

