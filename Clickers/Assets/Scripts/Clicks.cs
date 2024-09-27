using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Clicks : MonoBehaviour
{   
    private Animator _anim;
    private float offset = 10f;


    public AudioSource Audio;
    public AudioSource Buy;



    [Header("Click")]
    public int Point ;
    public int LevelPlants = 1;
    public int Click = 1;
    public int AutoClick = 0;



    [Header("Text")]
    public Text LevelText;
    public Text AutoClickText;
    //public Text ClickText;
    public Text PointText;
    public GameObject TextFloats;
    public Text plantText;
    public GameObject LevelsText;

    public float BarClick;


    [Header("ImageSun")]
    public Image Sun1;
   public Image Sun2;
    //public Image Sun3;



    [Header("Image")]
    public Image ClickBar;

    [Header("Time")]
    public float Times =   1;
    float nextTime;




    [Header("Sprites")]
    public Image ImagePlants;
    public Sprite SpritesPlants1;
    public Sprite SpritesPlants2;

    public Sprite SpritesPlants3;

    public Sprite SpritesPlants4;

    public Sprite SpritesPlants5;

    public Sprite SpritesPlants6;

    public Sprite SpritesPlants7;

    public Sprite SpritesPlants8;

    public Sprite SpritesPlants9;

    public Sprite SpritesPlants10;
    public Sprite SpritesPlants11;



    private void Start()
    {
        _anim = GetComponent<Animator>();
        Point = PlayerPrefs.GetInt("Point" , Point);
        AutoClick = PlayerPrefs.GetInt("AutoClick" , AutoClick);
        Click = PlayerPrefs.GetInt("Click" , Click);
        LevelPlants = PlayerPrefs.GetInt("Level" , LevelPlants);
        ClickBar.fillAmount = PlayerPrefs.GetFloat("ClickBar" , ClickBar.fillAmount);
        BarClick = PlayerPrefs.GetFloat("BarClick" , BarClick);


    }
    private void Update()
    {   
        PlayerPrefs.Save();
        PlayerPrefs.SetInt("Point" ,Point);
        PlayerPrefs.SetInt("AutoClick" , AutoClick);
        PlayerPrefs.SetInt("Click" , Click);
        PlayerPrefs.SetInt("Level" , LevelPlants);
        PlayerPrefs.SetFloat("ClickBar" , ClickBar.fillAmount);
        PlayerPrefs.SetFloat("BarClick" , BarClick);



        
        
        plantText.text = $"{LevelPlants}";
        
        
        
        
        MoveImage();
        if(Time.time > nextTime)

        {
                nextTime = Time.time + Times  ;
                Point+= AutoClick;
        }
        PointText.text = $"{Point}";
        AutoClickText.text = $"+{AutoClick}";
       // ClickText.text = $"+{Click}";
      
    }

    public void ClicksCheck()
    {  
             _anim.SetTrigger("Click");
            Point += Click;
            Audio.Play();
            _anim.SetBool("_isClick" , true);
              _anim.SetBool("_isIdle" , false);


           if(LevelPlants == 1)
           {
            ImagePlants.sprite = SpritesPlants1;

            ClickBar.fillAmount = BarClick / 10f;
            BarClick++;
            LevelText.text = $"Уровень";

                if(BarClick == 10f)
                {
                    LevelPlants++;
                    BarClick = 0;
                }
            }
            


            else if(LevelPlants == 2)
            {
                ClickBar.fillAmount = BarClick / 100f;
                 ImagePlants.sprite = SpritesPlants2;
                BarClick++;
                 LevelText.text = $"Уровень";
                
                    if(BarClick == 100f)
                    {
                        LevelPlants++;
                        BarClick = 0;
                    }
            }
            
            
            else if(LevelPlants == 3)
            {    
                ClickBar.fillAmount = BarClick / 250f;
                 ImagePlants.sprite = SpritesPlants3;
                 BarClick++;
                 LevelText.text = $"Уровень";

                    if(BarClick == 250f)
                     {
                        LevelPlants++;
                        BarClick = 0;
                    }
            }

            else if(LevelPlants == 4)
            {
                    ClickBar.fillAmount = BarClick / 600f;
                 ImagePlants.sprite = SpritesPlants4;
                     BarClick++;
                 LevelText.text = $"Уровень";

                     
                     if(BarClick == 600f)
                     {
                            LevelPlants++;
                            BarClick = 0;
                    }
            }

            else if(LevelPlants == 5)
            {
                    ClickBar.fillAmount = BarClick / 1000f;
                 ImagePlants.sprite = SpritesPlants5;
                     BarClick++;
                 LevelText.text = $"Уровень";

                     
                     if(BarClick == 1000f)
                     {
                            LevelPlants++;
                            BarClick = 0;
                    }
            }

            else if(LevelPlants == 6)
            {
                    ClickBar.fillAmount = BarClick / 1500f;
                 ImagePlants.sprite = SpritesPlants6;
                     BarClick++;
                 LevelText.text = $"Уровень ";

                     
                     if(BarClick == 1500f)
                     {
                            LevelPlants++;
                            BarClick = 0;
                    }
            }

            else if(LevelPlants == 7)
            {
                    ClickBar.fillAmount = BarClick / 2500f;
                 ImagePlants.sprite = SpritesPlants7;
                     BarClick++;
                 LevelText.text = $"Уровень";

                     
                     if(BarClick == 2500f)
                     {
                            LevelPlants++;
                            BarClick = 0;
                    }
            }

            else if(LevelPlants == 8)
            {
                    ClickBar.fillAmount = BarClick / 3200f;
                 ImagePlants.sprite = SpritesPlants8;

                     BarClick++;
                 LevelText.text = $"Уровень ";

                     
                     if(BarClick ==  3200f)
                     {
                            LevelPlants++;
                            BarClick = 0;
                    }
            }

            else if(LevelPlants == 9)
            {
                    ClickBar.fillAmount = BarClick / 5000f;
                 ImagePlants.sprite = SpritesPlants9;
                     BarClick++;
                 LevelText.text = $"Уровень";

                     
                     if(BarClick == 5000f)
                     {
                            LevelPlants++;
                            BarClick = 0;
                    }
            }

            else if(LevelPlants == 10)
            {
                    ClickBar.fillAmount = BarClick / 10000f;
                 ImagePlants.sprite = SpritesPlants10;
                     BarClick++;
                 LevelText.text = $"Уровень";

                     
                     if(BarClick == 10000f)
                     {
                            LevelPlants++;
                    }
            }

            else if(LevelPlants == 11)
            {
                ClickBar.fillAmount = BarClick / 100f;
                     BarClick = 100;
                 LevelText.text = "Максимум";
                 LevelsText.SetActive(false);  
            }
          

            
            Debug.Log($"{ClickBar.fillAmount}");
            Vector3 mousePosition = Input.mousePosition;

            GameObject floatInstantiateText = Instantiate(TextFloats ,mousePosition , Quaternion.identity);
            floatingText floatTexts = floatInstantiateText.GetComponent<floatingText>();

            if(floatTexts != null)
                floatTexts.Clicks = Click;
            
         

    }

    public void UpClick1()
    {   
        if(Point >= 100)
        {   
            Point -= 100;
            Click += 1;
            Buy.Play();
        }
    }

      public void UpClick2()
    {   
        if(Point >= 5000)
        {   
            Point -= 5000;
            Click += 50;
            Buy.Play();

        }
    }

    public void UpClick3()
    {   
        if(Point >= 5000000)
        {   
            Point -= 5000000;
            Click += 110000;
            Buy.Play();

        }
    }

    public void AutoClick1()
    {
        if(Point >= 15)
        {
            Point -= 15;
            AutoClick += 1;
            Buy.Play();

        }
    }
    public void AutoClick2()
    {
        if(Point >= 2500)
        {
            Point -= 2500;
            AutoClick += 25;
            Buy.Play();

        }
    }
    public void AutoClick3()
    {
        if(Point >= 110000)
        {
            Point -= 110000;
            AutoClick += 1000;
            Buy.Play();

        }
    }
    public void AutoClick4()
    {
        if(Point >= 500000)
        {
            Point -= 500000;
            AutoClick += 5000;
            Buy.Play();

        }
    }

    public void AutoClick5()
    {
        if(Point >= 1500000)
        {
            Point -= 1500000;
            AutoClick += 15000;
            Buy.Play();

        }
    }

    public void AutoClick6()
    {
        if(Point >= 150000000)
        {
            Point -= 150000000;
            AutoClick += 250000;
            Buy.Play();

        }
    }

    public void AutoClick7()
    {
        if(Point >= 1000000000)
        {
            Point -= 1000000000;
            AutoClick += 1000000;
            Buy.Play();

        }
    }
    private void MoveImage()
    {

Vector3 textPosition = PointText.rectTransform.position;
Sun1.rectTransform.position = new Vector3(textPosition.x + PointText.preferredWidth + offset, textPosition.y, textPosition.z);

 Vector3 AutoClick = AutoClickText.rectTransform.position;
Sun2.rectTransform.position = new Vector3(AutoClick.x + AutoClickText.preferredWidth + offset, AutoClick.y, AutoClick.z);


}
}