using System;

namespace WordPhone
{
  class MainClass
  {
    public static void Main(string[] args)
    {      
      Menu();
    }

    private static void function2()
    {
      /*string[] mPhone = Start();

      for (int a = 0; a < mPhone.Length;a++ )
      {
        for (int c = mPhone.Length; c == 0; c--)
        {

        }
      }
      */
      Console.WriteLine("Нет мыслей");

        Console.ReadKey();
      Menu();
    }

    private static void Menu()
    {
      Console.Clear();
      Console.WriteLine("-------Преобразователь телефонного номера в буквенный вид--------");
      Console.WriteLine("Menu");
      Console.WriteLine("1 - Function1\n2 - Function2\n0 - Exit");
      int n = int.Parse(Console.ReadLine());
      if (n == 1) function1();
      else
        if (n == 2) function2();
        else
          Console.WriteLine("Good Bye!");
    }

    private static string[] Start()
    {
      Console.WriteLine("Введите семизначный номер телефона");

      string iPhone = (Console.ReadLine()).ToString();

      int n = iPhone.Length;//длина номера
      string[] mPhone = new string[n];

      for (int i = 0; i < n; i++)//формируем массив строк из номера
      {
        char s = iPhone[i];
        string iW;
        switch (s)
        {
          case '1': iW = "1"; break;
          case '2': iW = "ABC"; break;
          case '3': iW = "DEF"; break;
          case '4': iW = "GHI"; break;
          case '5': iW = "JKL"; break;
          case '6': iW = "MNO"; break;
          case '7': iW = "PQRS"; break;
          case '8': iW = "TUV"; break;
          case '9': iW = "WXYZ"; break;
          default: iW = "0"; break;
        }
        mPhone[i] = iW;//массив строк букв номеров
      }
      return mPhone;
    }

    private static void function1()
    {
      string[] mPhone = Start();

      int K = 0;
      int k = 0, j = 0, x = 0, y = 0, a = 0, b = 0, c = 0;
      for (k = 0; k < mPhone[0].Length; k++)
      {
        for (j = 0; j < mPhone[1].Length; j++)
        {
          for (x = 0; x < mPhone[2].Length; x++)
          {
            for (y = 0; y < mPhone[3].Length; y++)
            {
              for (a = 0; a < mPhone[4].Length; a++)
              {
                for (b = 0; b < mPhone[5].Length; b++)
                {
                  for (c = 0; c < mPhone[6].Length; c++)
                  {
                    K++;
                    string sub = mPhone[0][k].ToString() + mPhone[1][j].ToString() + mPhone[2][x].ToString() + mPhone[3][y].ToString() + mPhone[4][a].ToString() + mPhone[5][b].ToString() + mPhone[6][c].ToString();
                    Console.Write("{0,3}-> {1} ", K, sub);
                    if (K % 10 == 0) Console.WriteLine();
                    if (K % 200 == 0)
                    {
                      // Console.ReadKey();
                      Console.Clear();
                    }
                  }
                  c = 0;
                }
                b = 0;
              }
              a = 0;
            }
            y = 0;
          }
          x = 0;
        }
        j = 0;
      }

      Console.ReadKey();
      Menu();
    }

  }
}
