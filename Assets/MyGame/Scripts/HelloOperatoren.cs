using UnityEngine;

public class HelloOperatoren : MonoBehaviour
{
    private float float1 = -2;
    private float float2 = +3;

    private bool boolean = true;


    void Start()
    {
        if(float1 == float2)
        {
            Debug.Log("das funktioniert nicht");
        }
        if (float1 <= float2)
        {
            Debug.Log("float1 <= float2 trifft zu");
        }
        if (boolean && float1 <= float2)
        {
            Debug.Log("boolean && float1 <= float2 trifft zu");
        }
        float float3 = float1 - float2;
        Debug.Log(float3);
        float1 += float2;
        Debug.Log(float1);
        float1++;
        Debug.Log(float1 + "++");
    }
}
