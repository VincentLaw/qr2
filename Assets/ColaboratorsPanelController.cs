using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColaboratorsPanelController : MonoBehaviour
{

    public List<GameObject> colaboratorsPanels;
    public GameObject noMoreColaboratorsPanel;
    private GameObject currentColaborator;
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


    public void displayNextPerson()
    {


        if (currentColaborator != null)
        {
            currentColaborator.SetActive(false);


        }

        if (colaboratorsPanels.Count > 0)
        {
            int index = Random.Range(0, colaboratorsPanels.Count);
            colaboratorsPanels[index].SetActive(true);
            currentColaborator = colaboratorsPanels[index];
            nextButton.SetActive(true);
            rejectButton.SetActive(true);
        }
        else
        {
            nextButton.SetActive(false);
            rejectButton.SetActive(false);
            noMoreColaboratorsPanel.SetActive(true);
            currentColaborator.SetActive(false);
        }


    }

    public void rejectPerson()
    {
        
        colaboratorsPanels.Remove(currentColaborator);
        Store.rejectedColaborators.Add(currentColaborator);
        displayNextPerson();
    }

    public void addPersonToMySelection()
    {
        Debug.Log(currentColaborator.name);
        colaboratorsPanels.Remove(currentColaborator);
        Store.myColaboratorsSelected.Add(currentColaborator);
        displayNextPerson();
    }
}
