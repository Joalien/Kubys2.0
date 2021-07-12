using System;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode]
public abstract class ProgressBar : MonoBehaviour
{
    [SerializeField] private int titleFontSize = 40;

    public PlayerCharacteristics playerCharacteristics;

    public Color barBackGroundColor = Color.white;
    public Sprite BarBackGroundSprite;

    private readonly Color _titleColor = Color.white;

    private Image _bar, _barBackground;

    private float _current;

    private Text _txtTitle;

    // protected float barValue;
    public float Current
    {
        get => _current;

        set
        {
            value = Mathf.Clamp(value, 0, Maximum);
            _current = value;
            Refresh();
        }
    }

    public float Maximum { get; set; }

    private void Awake()
    {
        Init();
    }

    protected void Update()
    {
        if (!Application.isPlaying)
        {
            Init();
            Current = 65;
            Maximum = 100;
            Refresh();
        }
    }

    private void Init()
    {
        _bar = transform.Find("Bar").GetComponent<Image>();
        _txtTitle = transform.Find("Text").GetComponent<Text>();
        _barBackground = transform.Find("BarBackground").GetComponent<Image>();

        _txtTitle.color = _titleColor;
        _txtTitle.fontSize = titleFontSize;

        _bar.color = GetBarColor();

        _barBackground.color = barBackGroundColor;
        _barBackground.sprite = BarBackGroundSprite;
    }


    protected abstract void Call();

    private void Refresh()
    {
        _bar.fillAmount = _current / Maximum;
        if (playerCharacteristics.gameObject.name == "MyPlayer")
            _txtTitle.text = GetTitle() + " " + (int) _current + "/" + Maximum + " (" +
                             Math.Round(_current * 100 / Maximum) + "%)";
    }

    protected abstract Color GetBarColor();
    protected abstract string GetTitle();
}
