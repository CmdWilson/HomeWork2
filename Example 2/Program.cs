Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());

  int SumNumber(int A){
    
    int counter = Convert.ToString(A).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){advance = A - A % 10;
      result = result + (A - advance);
      A = A / 10;
    }
   return result;
  }

int sumNumber = SumNumber(A);
Console.Write("Сумма цифр в числе: ");
Console.Write(sumNumber); 