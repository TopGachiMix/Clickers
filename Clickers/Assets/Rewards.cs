
using UnityEngine;
using YG;
public class Rewards : MonoBehaviour
{
     private Clicks _clicks;
    public YandexGame sdk;



     private void Start()
     {
        _clicks = FindAnyObjectByType<Clicks>();
     }


     public void AdButton()
     {
            sdk._RewardedShow(1);
     }

     public void ButtonCul()
     {
        _clicks.Point += _clicks.Point;
     }
}
