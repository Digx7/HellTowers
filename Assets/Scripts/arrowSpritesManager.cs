using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class arrowSpritesManager : MonoBehaviour
{

    public Color ArrowPressed, ArrowUnpressed, ArrowFailed;

    [SerializeField]
    private List<Transform> arrowSpritesGenerated;

    [SerializeField]
    private List<GameObject> arrowSpritesPrefabs;

    [SerializeField]
    private GameObject arrowSpritesParent;

    [SerializeField]
    private List<ArrowDirection> arrowDirections;

    [SerializeField] private ComboInteraction comboInteraction;

    [SerializeField] private int currentIndex=0;

    public void Awake(){
      arrowDirections = comboInteraction.getArrowDirections();
      arrowSpritesGenerator();
      //comboInteraction.comboStart.AddListener(arrowColorStart);
      comboInteraction.comboProgress.AddListener(arrowColorProgression);
      comboInteraction.comboFail.AddListener(arrowColorFailed);
      comboInteraction.comboSuccess.AddListener(arrowColorSuccess);
      comboInteraction.onState.AddListener(setArrowSpritesActiveOrNot);
    }

    private void arrowSpritesGenerator(){
      foreach(ArrowDirection direction in arrowDirections){
        if(direction.chosenDirection == ComboDirection.up) InstantiateArrowSprite(0);
        else if(direction.chosenDirection == ComboDirection.right)InstantiateArrowSprite(1);
        else if(direction.chosenDirection == ComboDirection.down)InstantiateArrowSprite(2);
        else if(direction.chosenDirection == ComboDirection.left)InstantiateArrowSprite(3);
      }
    }

    private void InstantiateArrowSprite(int input){
      arrowSpritesGenerated.Add(Instantiate(arrowSpritesPrefabs[input].transform, arrowSpritesParent.transform));
    }

    private void arrowColorProgression(){
      if(currentIndex == 0) arrowColorReset();
      arrowSpritesGenerated[currentIndex].gameObject.GetComponent<Image>().color = ArrowPressed;
      currentIndex++;
    }

    private void arrowColorStart(){
      for(int i = 1; i < arrowSpritesGenerated.Count; i++){
        arrowSpritesGenerated[i].gameObject.GetComponent<Image>().color = ArrowUnpressed;
      }
    }

    private void arrowColorSuccess(){
        arrowColorReset();
        resetCurrentIndex();
    }

    private void arrowColorFailed(){
      arrowColorReset();
      arrowSpritesGenerated[currentIndex].gameObject.GetComponent<Image>().color = ArrowFailed;
      resetCurrentIndex();
    }

    private void arrowColorReset(){
      foreach(Transform arrow in arrowSpritesGenerated){
        arrow.gameObject.GetComponent<Image>().color = ArrowUnpressed;
      }
    }

    private void resetCurrentIndex(){
      currentIndex = 0;
    }

    private void setArrowSpritesActiveOrNot(bool input){
      foreach(Transform arrow in arrowSpritesGenerated){
        arrow.gameObject.SetActive(input);
        if(input == false){
          arrowColorReset();
          currentIndex = 0;
        }
      }
    }
}
