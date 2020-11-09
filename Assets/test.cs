using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.SceneManagement;
public class test : MonoBehaviour
{
    GameObject dialog = null;
    public GameObject mainPanel;
    public GameObject peoplePanel;
    public GameObject companiesPanel;
    public GameObject collaboratorsPanel;
    public PeoplePanelController peoplePanelController;
    public ColaboratorsPanelController collaboratorsPanelController;
    public CompaniesPanelController companiesPanelController;
    public GameObject infoPanelForAPerson;
    public GameObject infoPanelForACompany;
    public GameObject infoPanelForACollaborator;

    public GameObject scannedCodeSuccessfully;
    public GameObject scannedCodeSuccessfully2;
    public GameObject invalidQR;
    // Start is called before the first frame update
    void Start()
    {
        checkForNewCertification();



#if PLATFORM_ANDROID
        if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
        {
            Permission.RequestUserPermission(Permission.Camera);
            //dialog = new GameObject();
        }
#endif
    }


    void OnGUI()
    {
#if PLATFORM_ANDROID
        if (!Permission.HasUserAuthorizedPermission(Permission.Camera))
        {
            // The user denied permission to use the microphone.
            // Display a message explaining why you need it with Yes/No buttons.
            // If the user says yes then present the request again
            // Display a dialog here.
            //dialog.AddComponent<PermissionsRationaleDialog>();
            return;
        }
        else if (dialog != null)
        {
            //Destroy(dialog);
        }
#endif

        // Now you can do things with the microphone
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void openCamera() {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }


    private void checkForNewCertification()
    {   //checar que string es el acutal, para saber que panel mostrar
        if (Store.lastCodeScanned != null)
        {
            if (Store.lastCodeScanned.Equals("test1")) {
                scannedCodeSuccessfully.SetActive(true);
            }
            if (Store.lastCodeScanned.Equals("test2"))
            {
                scannedCodeSuccessfully2.SetActive(true);
            }
            else
            {
                invalidQR.SetActive(true);
            }

            mainPanel.SetActive(false);
        }
        else
        {
            mainPanel.SetActive(true);
        }
    }



    /// <summary>
    /// ////todo lo de arriva corres
    /// </summary>
    public void displayPeoplePanel()
    {
        peoplePanelController.displayNextPerson();
        mainPanel.SetActive(false);
        peoplePanel.SetActive(true);
    }


    public void displayCollaboratorsPanel()
    {
        mainPanel.SetActive(false);
        collaboratorsPanel.SetActive(true);
        collaboratorsPanelController.displayNextPerson();

    }

    public void displayCompaniesPanel()
    {
        mainPanel.SetActive(false);
        companiesPanel.SetActive(true);
        companiesPanelController.displayNextPerson();

    }


    public void displayMainPanel() {
        collaboratorsPanel.SetActive(false);
        companiesPanel.SetActive(false);
        peoplePanel.SetActive(false);

        //infoPanelForACollaborator.SetActive(false);
        //infoPanelForACompany.SetActive(false);
        infoPanelForAPerson.SetActive(false);

        mainPanel.SetActive(true);

    }

    public void displayMiInfoPanel()
    {
        infoPanelForAPerson.SetActive(true);
        mainPanel.SetActive(false);
    }

    public void closesSuccessfulScan()
    {
        scannedCodeSuccessfully.SetActive(false);
        scannedCodeSuccessfully2.SetActive(false);
        invalidQR.SetActive(false);
        infoPanelForAPerson.SetActive(true);
    }
}
