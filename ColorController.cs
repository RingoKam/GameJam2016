using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ColorController
{
    //public enum colors {
    //	Red, Orange, Yellow, Green, Blue, Indigo, Violet
    //}

    public static Dictionary<string, Color> ColorDictionary {
        get {
            return new Dictionary<string, Color>()
            {
				{"Red", new Color(255, 0, 0)},
				{"Orange", new Color(255, 0, 0)},
				{"Yellow", new Color(255, 255, 0)},
				{"Green", new Color(0, 255, 0)},
				{"Blue", new Color( 0, 0, 255)},
                {"Indigo", new Color(75, 0, 130)},
                {"Violet", new Color(139, 0, 255)}
            };
        }
    }
}
