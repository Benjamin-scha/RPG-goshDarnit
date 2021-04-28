using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class npcDialog : MonoBehaviour
{
   

    public List<string> strings = new List<string>();

    // Start is called before the first frame update
    void Start()
    {
        
    }


    float dialogcooldown =0;

    // Update is called once per frame
    void Update()
    {
        if (dialogcooldown > 0)
        {
            dialogcooldown += Time.deltaTime;
        }
        if (dialogcooldown > 1)
        {
            dialogcooldown = 0;
        }

        dialogFunction.dropdown.onValueChanged.AddListener(respond);
        //dialogFunction.dropdown.onValueChanged
    }



    public void startTalk()
    {
        dialogFunction.dropdown.ClearOptions();

        List<TMP_Dropdown.OptionData> newOptions = new List<TMP_Dropdown.OptionData>();

        foreach(string st in strings)
        {
            TMP_Dropdown.OptionData option = new TMP_Dropdown.OptionData();
            option.text = st;

            newOptions.Add(option);
        }




        dialogFunction.dropdown.AddOptions(newOptions);
    }




    public void respond(int option)
    {
        if (dialogcooldown == 0)
        {
            dialogcooldown += 0.1f;
            print(strings[option]);
        }
       
    }


}
