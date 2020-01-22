
using UnityEngine;
using UnityEngine.UI;

public class ExitPanel : MonoBehaviour
{
    public void Exit()
    {
    }
	public Button yourButton;

	void Start()
	{
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		Debug.Log("Quit");
		Application.Quit();
	}
}
