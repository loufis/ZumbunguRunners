using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BoardManager : MonoBehaviour {

    public Canvas canvas;
    private RectTransform canvasSpace;


    void Awake()
    {
        canvas = GetComponent<Canvas>();
        canvasSpace = canvas.GetComponent<RectTransform>();
    }

    private void initializeLevel()
    {
        for(int i=0;i<canvasSpace.rect.width;i+=Globals.GROUND_TILESIZE)
        {
            
        }
    }

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
