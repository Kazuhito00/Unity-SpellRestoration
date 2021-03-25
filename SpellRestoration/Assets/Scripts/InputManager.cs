using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Text;
using UnityEngine.UI;

[System.Serializable]
public class SaveData
{
    public string a;
    public string b;
    public string c;
    public string d;
    public string e;
    public string f;
}

public class InputManager : MonoBehaviour
{
    private SaveData saveData = null;

    private InputField inputField01;
    private InputField inputField02;
    private InputField inputField03;
    private InputField inputField04;
    private InputField inputField05;
    private InputField inputField06;

	private Button button01;
	private Button button02;
    
    private InputField inputField00;
    
	private Button resetButton;

    private SpellRestoration sr;

    void Start()
    {
        this.saveData = new SaveData();

        this.inputField01 = GameObject.Find("InputField01").GetComponent<InputField>();
        this.inputField02 = GameObject.Find("InputField02").GetComponent<InputField>();
        this.inputField03 = GameObject.Find("InputField03").GetComponent<InputField>();
        this.inputField04 = GameObject.Find("InputField04").GetComponent<InputField>();
        this.inputField05 = GameObject.Find("InputField05").GetComponent<InputField>();
        this.inputField06 = GameObject.Find("InputField06").GetComponent<InputField>();
        
        this.button01 = GameObject.Find("Button01").GetComponent<Button>();
		this.button01.onClick.AddListener(OnClickButton01);
        this.button02 = GameObject.Find("Button02").GetComponent<Button>();
		this.button02.onClick.AddListener(OnClickButton02);

        this.inputField00 = GameObject.Find("InputField00").GetComponent<InputField>();
        
        this.resetButton = GameObject.Find("ResetButton").GetComponent<Button>();
		this.resetButton.onClick.AddListener(OnClickResetButton);

        this.sr = new SpellRestoration();
    }
    
	public void OnClickButton01()
    {
        this.saveData.a = this.inputField01.text;
        this.saveData.b = this.inputField02.text;
        this.saveData.c = this.inputField03.text;
        this.saveData.d = this.inputField04.text;
        this.saveData.e = this.inputField05.text;
        this.saveData.f = this.inputField06.text;

        var spellRestoration = this.sr.ToSpellRestoration(this.saveData);
        this.inputField00.text = spellRestoration;
	}
    
	public void OnClickButton02()
    {
        var spellRestoration = this.inputField00.text;

        var tempSaveData = this.sr.FromSpellRestoration<SaveData>(spellRestoration);

        if (tempSaveData != null) {
            this.inputField01.text = tempSaveData.a;
            this.inputField02.text = tempSaveData.b;
            this.inputField03.text = tempSaveData.c;
            this.inputField04.text = tempSaveData.d;
            this.inputField05.text = tempSaveData.e;
            this.inputField06.text = tempSaveData.f;
        } else {
            Debug.Log("FromSpellRestoration() Error");
        }
	}
    
	public void OnClickResetButton()
    {
        this.inputField01.text = "";
        this.inputField02.text = "";
        this.inputField03.text = "";
        this.inputField04.text = "";
        this.inputField05.text = "";
        this.inputField06.text = "";

        this.inputField00.text = "";
	}
}
