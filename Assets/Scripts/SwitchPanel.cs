using System;
using UnityEngine;
using UnityEngine.UI;

public class SwitchPanel : MonoBehaviour {

	[SerializeField] private FitForScreen imagePanel = null;
	[SerializeField] private ToggleGroup togleGroup = null;

	private bool ready;

	private void Start () {
		if (imagePanel != null) {
			foreach (var toggle in togleGroup.GetComponentsInChildren<Toggle> ()) {
				toggle.isOn = (toggle.name == imagePanel.Method.ToString ());
			}
			ready = true;
		}
	}

	public void OnChange (Toggle toggle) {
		if (imagePanel != null && ready) {
			imagePanel.Method = (FitForScreen.ExpandMethod) Enum.Parse (typeof (FitForScreen.ExpandMethod), toggle.name);
		}
	}

}
