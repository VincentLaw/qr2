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

}
