using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompaniesPanelController : MonoBehaviour
{

    public List<GameObject> companiesPanels;
    public GameObject noMoreCompaniesPanel;
    private GameObject currentCompany;
    public GameObject nextButton;
    public GameObject rejectButton;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void displayNextPerson() {
        if (companiesPanels.Count > 0)
        {
            int index=Random.Range(0, companiesPanels.Count);
            if (currentCompany!=null) {
                currentCompany.SetActive(false);
            }
            companiesPanels[index].SetActive(true);
            currentCompany = companiesPanels[index];
            nextButton.SetActive(true);
            rejectButton.SetActive(true);
        }
        else {
            nextButton.SetActive(false);
            rejectButton.SetActive(false);
            noMoreCompaniesPanel.SetActive(true);
            currentCompany.SetActive(false);
        }

        
    }

    public void rejectPerson() {
        companiesPanels.Remove(currentCompany);
        Store.rejectedCompanies.Add(currentCompany);
        displayNextPerson();
    }

    public void addPersonToMySelection() {
        companiesPanels.Remove(currentCompany);
        Store.myCompaniesSelected.Add(currentCompany);
        displayNextPerson();
    }
}
