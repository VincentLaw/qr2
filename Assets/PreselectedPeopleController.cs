using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PreselectedPeopleController : MonoBehaviour
{
    public Text[] slotsText;
    public List<GameObject> preselectedPanels;
    public GameObject currentPanel;
    public GameObject mainPanel;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void init()
    {
        string userLogged = Store.userLogged;

        if (userLogged.Equals("commonUser"))
        {

        }
        else
        {
            for (int index = 0; index < Store.myPeopleSelected.Count; index++)
            {
                slotsText[index].transform.parent.gameObject.SetActive(true);
                slotsText[index].transform.parent.gameObject.name = Store.myPeopleSelected[index].name;
                slotsText[index].text = Store.myPeopleSelected[index].name;

                Button currentButton = (Button)slotsText[index].transform.parent.gameObject.GetComponent("Button");
                currentButton.onClick.RemoveAllListeners();

                Debug.Log(Store.myPeopleSelected[index].name);

                //currentButton.onClick.AddListener(delegate { DisplayPerson(Store.myPeopleSelected[index].name); });


            }
        }

    }

    public void DisplayPerson(string personName) {
        for (int index=0; index<preselectedPanels.Count; index++) {
            if (preselectedPanels[index].name.Equals(personName)) {
                preselectedPanels[index].SetActive(true);
                gameObject.SetActive(false);
                currentPanel = preselectedPanels[index];
                break;
            }
        }
    
    }

    public void closePanel() {
        currentPanel.SetActive(false);
        mainPanel.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }




}
