using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoxClick : MonoBehaviour {

	public Button btn;
	public Image buttonImage;
	private bool selected = false;
	//private GameLogic logic;
	[SerializeField] private SpriteRenderer spriteR;
	private Sprite[] sprites;

	public void SetNumber(){
		if(Input.GetKeyDown(KeyCode.Alpha1)){
			selected = false;
			spriteR.sprite = sprites[0];
			//logic.CheckForEquals(buttonImage.sprite.ToString());
		}
		if(Input.GetKeyDown(KeyCode.Alpha2)){
			selected = false;
			spriteR.sprite = sprites[1];
			//logic.CheckForEquals(buttonImage.sprite.ToString());
		}
		if(Input.GetKeyDown(KeyCode.Alpha3)){
			selected = false;
			spriteR.sprite = sprites[2];
			//logic.CheckForEquals(buttonImage.sprite.ToString());
		}
		if(Input.GetKeyDown(KeyCode.Alpha4)){
			selected = false;
			spriteR.sprite = sprites[3];
			//logic.CheckForEquals(buttonImage.sprite.ToString());
		}
		if(Input.GetKeyDown(KeyCode.Alpha5)){
			selected = false;
			spriteR.sprite = sprites[4];
			//logic.CheckForEquals(buttonImage.sprite.ToString());
		}
		if(Input.GetKeyDown(KeyCode.Alpha6)){
			selected = false;
			spriteR.sprite = sprites[5];
			//logic.CheckForEquals(buttonImage.sprite.ToString());
		}
		if(Input.GetKeyDown(KeyCode.Alpha7)){
			selected = false;
			spriteR.sprite = sprites[6];
			//logic.CheckForEquals(buttonImage.sprite.ToString());
		}
		if(Input.GetKeyDown(KeyCode.Alpha8)){
			selected = false;
			spriteR.sprite = sprites[7];
			//logic.CheckForEquals(buttonImage.sprite.ToString());
		}
		if(Input.GetKeyDown(KeyCode.Alpha9)){
			selected = false;
			spriteR.sprite = sprites[8];
			//logic.CheckForEquals(buttonImage.sprite.ToString());
		}
		

	}

	// Use this for initialization
	void Start () {
		btn = GetComponent<Button>();
		buttonImage = GetComponent<Image>();
		spriteR = gameObject.GetComponent<SpriteRenderer>();
		Resources.LoadAll<Sprite>("numbers-sprite-100");
		
		btn.onClick.AddListener(Select);
	}

	private void Update() {
		if(selected)
			SetNumber();
	}

	private void Select(){ //faz com que o botao seja selecionado e aguarde input
		selected = !selected;
	}
}
