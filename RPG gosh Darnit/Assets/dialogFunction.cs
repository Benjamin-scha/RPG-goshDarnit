using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class dialogFunction : MonoBehaviour
{
    [SerializeField]
    private TMPro.TMP_Dropdown dropdown_;
    public static TMP_Dropdown dropdown;



    // Start is called before the first frame update
    void Start()
    {
        dropdown = dropdown_;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown("q") && other.gameObject.GetComponent<npcDialog>()!=null)
        {
            other.BroadcastMessage("startTalk");
        }
    }


}
