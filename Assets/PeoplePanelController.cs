using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeoplePanelController : MonoBehaviour
{

    public List<GameObject> peoplePanels;
    public GameObject noMorePeoplePanel;
    private GameObject currentPerson;
    public GameObject nextButton;
    public GameObject rejectButton;
    // Start is called before the first frame update
    void Start()
    {
       //displayNextPerson();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void displayNextPerson() {
        if (peoplePanels.Count > 0)
        {
            int index=Random.Range(0, peoplePanels.Count);
            if (currentPerson!=null) {
                currentPerson.SetActive(false);
            }
            peoplePanels[index].SetActive(true);
            currentPerson = peoplePanels[index];
            nextButton.SetActive(true);
            rejectButton.SetActive(true);
        }
        else {
            nextButton.SetActive(false);
            rejectButton.SetActive(false);
            noMorePeoplePanel.SetActive(true);
            currentPerson.SetActive(false);
        }

        
    }

    public void rejectPerson() {
        peoplePanels.Remove(currentPerson);
        Store.rejectedPeople.Add(currentPerson);
        displayNextPerson();
    }

    public void addPersonToMySelection() {
        peoplePanels.Remove(currentPerson);
        Store.myPeopleSelected.Add(currentPerson);
        displayNextPerson();
    }
}
