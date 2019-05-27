//	Copyright© Tetr4lab.

using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// UI.ImageをCanvasにフィットさせる
/// Imageは、Canvas中央に中央アンカーで配置されている必要がある。
/// </summary>
public class FitForScreen : MonoBehaviour {

	public enum ExpandMethod {
		Fill,	 // 外接する
		Fit,	 // 内接する
		Stretch, // 伸縮させる
	}

	[SerializeField] private Image Image = default;
	[SerializeField] public ExpandMethod Method = default;
	private RectTransform CanvasRect;
	private Vector2 LastCanvasSize;
	private RectTransform ImageRect;
	private Vector2 ImageSize;
	private ExpandMethod LastMethod;
	
	/// <summary>初期化</summary>
	private void Awake () {
		CanvasRect = GetComponentInParent<Canvas> ().GetComponent<RectTransform> ();
		ImageRect = Image.GetComponent<RectTransform> ();
		var sprite = Image.sprite;
		ImageSize = sprite.bounds.size * sprite.pixelsPerUnit;
		LastMethod = Method;
	}

	/// <summary>駆動</summary>
	private void Update () {
		if (LastCanvasSize != CanvasRect.sizeDelta || LastMethod != Method) {
			LastCanvasSize = CanvasRect.sizeDelta;
			var narrow = (((float) LastCanvasSize.y / LastCanvasSize.x) <= (ImageSize.y / ImageSize.x));
			if (Method == ExpandMethod.Stretch) {
				ImageRect.sizeDelta = LastCanvasSize;
			} else {
				ImageRect.sizeDelta = ((Method == ExpandMethod.Fill && narrow) || (Method == ExpandMethod.Fit && !narrow)) ?
					new Vector2 (LastCanvasSize.x, ImageSize.y * LastCanvasSize.x / ImageSize.x) :
					new Vector2 (ImageSize.x * LastCanvasSize.y / ImageSize.y, LastCanvasSize.y);
			}
			LastMethod = Method;
		}
	}

}
