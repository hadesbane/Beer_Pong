using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color_Changer : MonoBehaviour {
    private float[] rgb = new float[3];
    private SpriteRenderer rend;
    public float[] background;
    public float colorChange; //Changes how fast the color of the ball will change
    public float inter; //Interval used for the sameAs function

	// Use this for initialization
	void Start () {
        this.rend = GetComponent<SpriteRenderer>();
        this.rend.enabled = true;
        for(int i = 0; i < 3; i++)
        {
            rgb[i] = 1;
        }
	}
	
	// Update is called once per frame
	void Update () {
        rgbUpdate(rgb);
        this.rend.color = new Color(rgb[0], rgb[1],rgb[2], 1);
        if(inter < 0)
        {
            inter = 0;
        }
	}

    //Changes the specific r, g, and b values of the index so as to change the color of the object
    private float[] rgbUpdate(float[] rgb){
        for(int i = 0; i < 3; i++) {
            rgb[i] -= Random.Range(0F, colorChange);
            if(rgb[i] < 0)
            {
                rgb[i] += 1;
            }
        }
        if (sameAs(rgb)){
            rgbUpdate(rgb);
        }
        return rgb;
    }

    private bool sameAs(float[] rgb)
    {
        bool r =false;
        bool g = false;
        bool b = false;
        for(int i = 0; i < 3; i++) {
            //checks if the rgb values are close enough to the backround to warrant a redo of the rgb method
            if(background[i] + .07 >= rgb[i] && background[i] - .07 <= rgb[i])
            {
                if(i == 0)
                {
                    r = true;
                }
                else if(i == 1)
                {
                    g = true;
                }
                else
                {
                    b = true;
                }
            }
        }

        if (r && g && b)
        {
            return true;
        }
            return false;
        
    }
}
