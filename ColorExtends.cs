using UnityEngine;

public static class ColorExtends
{
    
    public static Color InvertColor(this Color color)
    {
        return new Color(1 - color.r, 1 - color.g, 1 - color.b);
    }


}
