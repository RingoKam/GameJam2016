using UnityEngine;
using System.Collections;
using UnityEngine.UI;
 
 public class ColorTitleController : MonoBehaviour 
 {
     public Color[] colors;
	 public Text text;
     public int currentIndex = 0;
     public float changeColourTime = 2.0f;
	 private int nextIndex;
     private float lastChange = 0.0f;
     private float timer = 0.0f;
     
     void Start() {
     	text = GetComponent<Text>();
        nextIndex = (currentIndex + 1) % colors.Length;    
     }
     
     void Update() {
         
         timer += Time.deltaTime;
         
         if (timer > changeColourTime) {
             currentIndex = (currentIndex + 1) % colors.Length;
             nextIndex = (currentIndex + 1) % colors.Length;
             timer = 0.0f;
             
         }
         text.color = Color.Lerp (colors[currentIndex], colors[nextIndex], timer / changeColourTime );
     }
 }