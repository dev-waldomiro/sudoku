/// Olá, chuchu!
/// Marquei seu código com vários tags "ERRO", só fazer uma busca por essa palavra pra ver os erros que encontrei
/// Boa sorte!! 
///
///
///
///
///
///
///
///
///
///
/// Guilherme

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Assertions; // adicionado para checar null gameobjects

public class BoxClick : MonoBehaviour {

    public Button btn;
    public Image buttonImage;
    private bool selected = false;
    //private GameLogic logic;
    // ERRO: sprite renderer é pra renderizar sprites, você ta renderizando botões numa canvas, são coisas diferentes
    // [SerializeField] private SpriteRenderer spriteR;  // não é necessário para botoes
    // ERRO: Mudei a maneira de carrgar os sprites pro mais fácil que eu consegui pensar. Dá pra fazer por código também, mas esse é o mais fácil.
    [SerializeField] private Sprite[] sprites;

    public void SetNumber() {
        // ERRO: esses KeyCode.Alpha# não estão funcionando pra mim, troquei pra KeyPad#.
        // ERRO: você tava trocando o sprite renderer, mas você ta usando botoes. Nesse caso você precisa mudar a imagem do botão!
        if ( Input.GetKeyDown( KeyCode.Keypad0 ) ) {
            buttonImage.sprite = sprites[0];
            selected = false;
            //logic.CheckForEquals(buttonImage.sprite.ToString());
        }
        if ( Input.GetKeyDown( KeyCode.Keypad1 ) ) {
            buttonImage.sprite = sprites[1];
            selected = false;
            //logic.CheckForEquals(buttonImage.sprite.ToString());
        }
        if ( Input.GetKeyDown( KeyCode.Keypad2 ) ) {
            buttonImage.sprite = sprites[2];
            selected = false;
            //logic.CheckForEquals(buttonImage.sprite.ToString());
        }
        if ( Input.GetKeyDown( KeyCode.Keypad3 ) ) {
            buttonImage.sprite = sprites[3];
            selected = false;
            //logic.CheckForEquals(buttonImage.sprite.ToString());
        }
        if ( Input.GetKeyDown( KeyCode.Keypad4 ) ) {
            buttonImage.sprite = sprites[4];
            selected = false;
            //logic.CheckForEquals(buttonImage.sprite.ToString());
        }
        if ( Input.GetKeyDown( KeyCode.Keypad5 ) ) {
            buttonImage.sprite = sprites[5];
            selected = false;
            //logic.CheckForEquals(buttonImage.sprite.ToString());
        }
        if ( Input.GetKeyDown( KeyCode.Keypad6 ) ) {
            buttonImage.sprite = sprites[6];
            selected = false;
            //logic.CheckForEquals(buttonImage.sprite.ToString());
        }
        if ( Input.GetKeyDown( KeyCode.Keypad7 ) ) {
            buttonImage.sprite = sprites[7];
            selected = false;
            //logic.CheckForEquals(buttonImage.sprite.ToString());
        }
        if ( Input.GetKeyDown( KeyCode.Keypad8 ) ) {
            buttonImage.sprite = sprites[8];
            selected = false;
            //logic.CheckForEquals(buttonImage.sprite.ToString());
        }
        if ( Input.GetKeyDown( KeyCode.Keypad9 ) ) {
            buttonImage.sprite = sprites[9];
            selected = false;
            //logic.CheckForEquals(buttonImage.sprite.ToString());
        }

    }

    void Awake() {
        // Jeito bem porco de mostrar uma mensagem caso uma das caixas de sprites esteja vazia
        // O for está com 10 iterações como um número mágico...
        for ( int i = 0; i < 10; ++i ) {
            Assert.IsNotNull( sprites[i] );
        }
    }

    // Use this for initialization
    void Start() {
        btn = GetComponent<Button>();
        buttonImage = GetComponent<Image>();
        // spriteR = gameObject.GetComponent<SpriteRenderer>(); // não é necessário para botões
        // ERRO: você não ta passando a referencia de sprites pra ninguém
        // ERRO: não tenho certeza se a função LoadAll() pode ser usada pra esse tipo de coisa
        // Resources.LoadAll<Sprite>("numbers-sprite-100"); 

        btn.onClick.AddListener( Select );
    }

    private void Update() {
        if ( selected ) {
            SetNumber();
        }
    }

    private void Select() { //faz com que o botao seja selecionado e aguarde input
        selected = !selected;
    }
}
