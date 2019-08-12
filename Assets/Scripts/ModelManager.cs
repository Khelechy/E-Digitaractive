using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModelManager : MonoBehaviour {

    private GameObject[] modelList;
    private int index;

    public Text dName;
    public Text dDetails;
    public Text dAnimalType;

    private ModelInfo dModel;

    void Start () {
        //dModel = GameObject.FindGameObjectWithTag ("Model").GetComponent<ModelInfo> ();

        modelList = new GameObject[transform.childCount];
        for (int i = 0; i < transform.childCount; i++) {
            modelList[i] = transform.GetChild (i).gameObject;
        }

        foreach (GameObject model in modelList) {
            model.SetActive (false);

            if (modelList[0]) {
                modelList[0].SetActive (true);
            }
        }
    }

    void Update () {
        dModel = GameObject.FindGameObjectWithTag ("Model").GetComponent<ModelInfo> ();
        dName.text = "Name: " + dModel.modelName;
        dDetails.text = "Details: " + dModel.details;
        dAnimalType.text = "Type: " + dModel.animalType;
       
    }

    public void previousModel () {
        modelList[index].SetActive (false);
        index--;
        if (index < 0) {
            index = modelList.Length - 1;

        }

        modelList[index].SetActive (true);
    }

    public void nextModel () {
        modelList[index].SetActive (false);
        index++;
        if (index == modelList.Length) {
            index = 0;

        }

        modelList[index].SetActive (true);
    }

    public void ScaleUp () {
        dModel.ScaleUp ();

    }

    public void ScaleDown () {
        dModel.ScaleDown ();

    }

    public void Rotate () {
        dModel.Rotate ();

    }
}