using UnityEngine;

public class HelloSchleifen : MonoBehaviour
{


    public string[,] array = new string[3, 4]
  {
        {"A", "B", "C", "D" }, {"E", "F", "G", "H" },{"I", "J", "K", "L" }
  };


    void Start()
    {
        int row = array.GetLength(0);
        int col = array.GetLength(1);

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                Debug.Log(array[i, j]);
            }
        }
    }


}
