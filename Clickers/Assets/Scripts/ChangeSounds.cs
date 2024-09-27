using UnityEngine;

public class ChangeSounds : MonoBehaviour
{

    public GameObject OnMus;
    public GameObject OffMus;
    public int SoundsManage = 1;

    void Start()
    {
        SoundsManage  = PlayerPrefs.GetInt("Sound" , SoundsManage);
    }

    public void Update()
    {
        PlayerPrefs.SetInt("Sound" , SoundsManage);
         

        if(SoundsManage == 1)
        {
            OnMus.SetActive(true);
            OffMus.SetActive(false);
            GetComponent<AudioSource>().enabled = false;

        }
        else if(SoundsManage == 2)
        {
           OnMus.SetActive(false);
            OffMus.SetActive(true);

            GetComponent<AudioSource>().enabled = true;

           
        }
}


public void OnMusic()
{
   SoundsManage = 2;
}

public void OffMusic()
{
   SoundsManage = 1;

}
}
