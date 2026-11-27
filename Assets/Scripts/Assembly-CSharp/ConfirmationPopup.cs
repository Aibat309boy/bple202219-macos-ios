using System;
using UnityEngine;

public class ConfirmationPopup : MonoBehaviour
{
	public event Action PopupClosed;

	public void DismissDialog()
	{
		base.gameObject.SetActive(value: false);
		if (this.PopupClosed != null)
		{
			this.PopupClosed();
		}
	}

	public void ExitGame()
	{
#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
#else
		Application.Quit();
#endif
	}
}
