using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store 
{
    public static List<GameObject> myPeopleSelected = new List<GameObject>();
    public static List<GameObject> rejectedPeople = new List<GameObject>();

    public static List<GameObject> myCompaniesSelected = new List<GameObject>();
    public static List<GameObject> rejectedCompanies = new List<GameObject>();

    public static List<GameObject> myColaboratorsSelected = new List<GameObject>();
    public static List<GameObject> rejectedColaborators = new List<GameObject>();


    public static List<string> scannedCodes = new List<string>();

    public static string lastCodeScanned;


    public static string userLogged=null;

    public static List<GameObject> myPeopleSelectedByACompany = new List<GameObject>();
    public static List<GameObject> rejectedPeopleByACompany = new List<GameObject>();

    public static List<GameObject> myCompaniesSelectedByACompany = new List<GameObject>();
    public static List<GameObject> rejectedCompaniesByACompany = new List<GameObject>();

    public static List<GameObject> myColaboratorsSelectedByACompany = new List<GameObject>();
    public static List<GameObject> rejectedColaboratorsByACompany = new List<GameObject>();

}
