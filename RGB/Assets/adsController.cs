using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Monetization;
public class adsController : MonoBehaviour
{

    private string storeid = "3291686";
    private string videoAd = "video";
    private string rewardedVideoAd = "rewardedVideo";
    private string bannerAd = "bannerAd";
    public static bool showAd;
    // Start is called before the first frame update
    void Start()
    {
        Monetization.Initialize(storeid, false);
        showAd = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(rayHit.gameOver && showAd)
        {

            //is the video add is ready to be played
            if (Monetization.IsReady(videoAd))
            {

                ShowAdPlacementContent ad = null;
                ad = Monetization.GetPlacementContent(videoAd) as ShowAdPlacementContent;

                if (ad != null)
                {
                    ad.Show();
                    showAd = false;
                }
            }
        }
    }
}
