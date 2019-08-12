using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class Speech : MonoBehaviour {

	KeywordRecognizer KeywordRecognizerObj;
	public string[] Keywords_array;

	void Start () {
		KeywordRecognizerObj = new KeywordRecognizer (Keywords_array);
		KeywordRecognizerObj.OnPhraseRecognized += OnKeywordsRecognized;
		KeywordRecognizerObj.Start ();
	}

	void OnKeywordsRecognized (PhraseRecognizedEventArgs args) {
		Debug.Log ("Keyword: " + args.text + " : Confidence " + args.confidence);
		ActionPerformer (args.text);
	}

	void ActionPerformer (string command) {
		if (command.Contains ("scale up")) {
			ModelInfo.Instance.ScaleUp ();

		}
		if (command.Contains ("scale down")) {
			ModelInfo.Instance.ScaleDown ();

		}
	}

}