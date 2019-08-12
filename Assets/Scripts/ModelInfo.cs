using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ModelInfo : MonoBehaviour {

    public static ModelInfo Instance { set; get; }

    public string modelName;
    public string details;
    public string animalType;

    private void Start() {
        Instance = this;
    }

    public void ScaleUp () {
        transform.localScale += new Vector3 (1, 1, 1);
    }

    public void ScaleDown () {
        transform.localScale += new Vector3 (-1, -1, -1);
    }

    public void Rotate () {
        

    }
}