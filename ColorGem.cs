using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.GameJam2016.Script
{
    public class ColorGem: MonoBehaviour
    {
        public string ColorOfGem; 

        void Awake()
        {
        	var color = ColorController.ColorDictionary[ColorOfGem];
        	GetComponent<SpriteRenderer>().color = color;
        }
    }
}
