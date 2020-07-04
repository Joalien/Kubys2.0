using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[ExecuteInEditMode]

public class ProgressBar : MonoBehaviour
{

    public bool isLife;
    public PlayerCharacteristics playerCharacteristics;

    [Header("Title Setting")]
    public string Title;
    public Color TitleColor;
    public Font TitleFont;
    public int TitleFontSize = 10;

    public Color BarColor;
    public Color BarBackGroundColor;
    public Sprite BarBackGroundSprite;

    private Image bar, barBackground;
    private Text txtTitle;
    private float maximum;
    private float current;
    private float barValue;
    public float Current
    {
        get => current;

        set
        {
            value = Mathf.Clamp(value, 0, maximum);
            current = value;
            Refresh();
        }
    }

    public float Maximum
    {
        get => maximum;
        set => maximum = value;
    }

    private void Awake()
    {
        bar = transform.Find("Bar").GetComponent<Image>();
        barBackground = GetComponent<Image>();
        txtTitle = transform.Find("Text").GetComponent<Text>();
        barBackground = transform.Find("BarBackground").GetComponent<Image>();
    }

    private void Start()
    {
        txtTitle.color = TitleColor;
        txtTitle.font = TitleFont;
        txtTitle.fontSize = TitleFontSize;

        bar.color = BarColor;
        barBackground.color = BarBackGroundColor; 
        barBackground.sprite = BarBackGroundSprite;

        Maximum = isLife ? playerCharacteristics.totalHealth : playerCharacteristics.totalMana;

        (isLife ? playerCharacteristics.healthUpdate : playerCharacteristics.manaUpdate).AddListener(Call);

        playerCharacteristics.healthUpdate.Invoke();
        playerCharacteristics.manaUpdate.Invoke();
    }

    private void Call()
    {
        Current = isLife ? playerCharacteristics.CurrentHealth : playerCharacteristics.CurrentMana;
    }

    private void Update()
    {
        if (!Application.isPlaying)
        {
            current = 50;
            maximum = 100;
            Refresh();
            txtTitle.color = TitleColor;
            txtTitle.font = TitleFont;
            txtTitle.fontSize = TitleFontSize;

            bar.color = BarColor;
            barBackground.color = BarBackGroundColor;

            barBackground.sprite = BarBackGroundSprite;           
        }
    }

    public void Refresh()
    {
        bar.fillAmount = current / maximum;
        if (playerCharacteristics.gameObject.name == "MyPlayer")
        {
            txtTitle.text = Title + " " + current + "/" + maximum + " (" + Math.Round(current * 100 / maximum) + "%)";
        }
    }
}
