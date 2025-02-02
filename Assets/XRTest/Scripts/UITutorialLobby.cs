using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UITutorialLobby : MonoBehaviour
{
	public Dropdown dropdown;
	public Button button;
	private int selectedSceneIndex;

	public List<string> sceneNames = new List<string>();

	private void Awake() {
		//드롭다운 옵션 리스트 생성
		List<Dropdown.OptionData> options = new List<Dropdown.OptionData>();
		//sceneNames 내부 객체 순차 반복
		foreach (string sceneName in sceneNames) {
			options.Add(new Dropdown.OptionData(sceneName));
		}
		dropdown.options = options; //드롭다운 옵션 리스트 교체
		dropdown.onValueChanged.AddListener(SceneSelectionChange);//드롭다운 OnvalueChanged 이벤트에 SceneSelectionChange 추가
		button.onClick.AddListener(MoveButtonClick);
	}

	public void SceneSelectionChange(int index) {
		selectedSceneIndex = index;
	}

	public void MoveButtonClick() {
		SceneManager.LoadScene(selectedSceneIndex);
	}
   
}
