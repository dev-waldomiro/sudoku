using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


// ESTE SCRIPT NAO ESTA SENDO UTILIZADO NO MOMENTO, O OBJETIVO DELE EH MUDAR A SPRITE DA CAIXA
// NO ENTANTO ESSA FUNCIONALIDADE FOI MOVIDA SEM SUCESSO PARA A BOXCLICK
public class NumberValue : MonoBehaviour {

	private int number;
	
	private SpriteRenderer spriteR;
	private Sprite[] sprites;

	private void Start() {
		spriteR = gameObject.GetComponent<SpriteRenderer>();
		sprites = Resources.LoadAll<Sprite>("numbers-sprite-100");
	}
	public void SpriteAssigner(int number, Image buttonImage){
		if(number == 1)
			buttonImage.sprite = sprites[0];
		if(number == 2)
			buttonImage.sprite = sprites[1];
		if(number == 3)
			buttonImage.sprite = sprites[2];
		if(number == 4)
			buttonImage.sprite = sprites[3];
		if(number == 5)
			buttonImage.sprite = sprites[4];
		if(number == 6)
			buttonImage.sprite = sprites[5];
		if(number == 7)
			buttonImage.sprite = sprites[6];
		if(number == 8)
			buttonImage.sprite = sprites[7];
		if(number == 9)
			buttonImage.sprite = sprites[8];

	}
}
