
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
		yourButton.GetComponent<Button>();
		yourButton.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		Debug.Log("Quit");
		Application.Quit();
	}
}
