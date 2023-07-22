#region Task:Capitalized(Method1)
//using System.Globalization;
//using System.Text;

//string NewSentence = Console.ReadLine();

//string NewSentence1 = NewSentence.ToLower();
//StringBuilder sb = new StringBuilder(NewSentence1[0].ToString().ToUpper());
//for (int i = 1; i < NewSentence1.Length; i++)
//{

//    if (char.IsWhiteSpace(NewSentence1[i - 1]))
//    {

//        sb.Append(NewSentence1[i].ToString().ToUpper());
//    }
//    else
//    {
//        sb.Append(NewSentence1[i]);

//    }

//}

//foreach (var item in sb.ToString())
//{
//    Console.Write(item);
//}
#endregion
#region Task:Capatalized(Method2)
//using System.Globalization;
//using System.Text;

//string NewSentence = Console.ReadLine();

//string NewSentence1 = NewSentence.ToLower();
//StringBuilder sb = new StringBuilder(NewSentence1[0].ToString().ToUpper());
//for (int i = 0; i < NewSentence1.Length - 1; i++)
//{

//    if (char.IsWhiteSpace(NewSentence1[i]))
//    {

//        sb.Append(NewSentence1[i + 1].ToString().ToUpper());
//    }
//    else
//    {
//        sb.Append(NewSentence1[i + 1]);
//    }
//}

//foreach (var item in sb.ToString())
//{
//    Console.Write(item);
//}

#endregion


#region Task:Capitalized(the best Method 3)
//string NewSentence = Console.ReadLine();
//string[] arr = NewSentence.Split(' ');
//string capitalize=string.Empty;
//foreach (string item in arr)
//{
//    capitalize += item[0].ToString().ToUpper() + item.Substring(1) + " ";

//}
//Console.WriteLine(capitalize);

#endregion

#region Capitalized(Method 4)
//string newSentence=Console.ReadLine();
//char[] arr = newSentence.ToLower().ToCharArray();
//arr[0]=char.ToUpper(arr[0]);
//for (int i = 1;i< arr.Length-1; i++)
//{

//    if (arr[i]==' ')
//    {
//       arr[i+1]=char.ToUpper(arr[i+1]);
//    }

//}
////foreach (var item in arr)
////{
////    Console.Write(item);

////}
//Console.WriteLine(new string(arr));

#endregion
