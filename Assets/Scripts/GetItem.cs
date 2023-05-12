using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItem : MonoBehaviour
{
    [SerializeField] private bool pureOfHeart = true;
    [SerializeField] private bool hasSecretIncantation = false;
    [SerializeField] private string rareItem = "Relic Stone";
    
    void Start()
    {
        OpenTreasureChamber();
    }

    public void OpenTreasureChamber()
    {
        if (pureOfHeart && rareItem == "Relic Stone")
        {
            if (!hasSecretIncantation)
            {
                Debug.Log("汝（なんじ）の心は清いが、知識が足りぬな。");
            }
            else
            {
                Debug.Log("真の英雄よ、宝は汝のものだ！");
            }
        }
        else
        {
            Debug.Log("条件が揃ったら、また来るがよい。 ");
        }
    }
    
}
