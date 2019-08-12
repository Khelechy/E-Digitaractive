using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenOverlay : MonoBehaviour {

    public void ScaleUp () {
        transform.localScale += new Vector3 (1, 1, 1);
    }

    public void ScaleDown () {
        transform.localScale += new Vector3 (-1, -1, -1);
    }
}