
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartyMembers : MonoBehaviour
{
    private void Start()
    {
        var questPartyMembers = new List<string>()
        {
            "Grim the Barbarian",
            "Merlin the Wise",
            "Sterling the Knight"
        };

        //Debug.LogFormat("Party Members: {0}", questPartyMembers.Count);
        foreach (var member in questPartyMembers)
        {
            Debug.LogFormat("Member:{0}", member);

            if (member == "Merlin the Wise")
            {
                Debug.Log("君がいてくれて嬉しいよ、マーリン！");
            }
        }
    }
}
