using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class MyVector2
{
    // public float x { get; set; }
    // public float y { get; set; }

    public float x, y;

    public MyVector2()
    {
        this.x = 0;
        this.y = 0;
    }

    public MyVector2(float x, float y)
    {
        this.x = x;
        this.y = y;
    }

    ///accesss static returnType FunctionName(parameters){}
    public static MyVector2 down()
    {
        return new MyVector2(0, -1);
    }

    public static MyVector2 operator -(MyVector2 vec1, MyVector2 vec2)
    {
        return new MyVector2(vec1.x - vec2.x, vec1.y - vec2.y);
    }

}
