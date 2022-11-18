////using System.Text; Inlocuim literele cuurmatoarele : ex lfrib == mesaj

//string encodedMessage = Console.ReadLine();
//string message = "";
//string message2 = "";
//for (int i = 0; i < encodedMessage.Length; i++)
//{
//    if (encodedMessage[i] == ' ')
//    {
//        message += ' ';
//        message2 += ' ';
//        continue;
//    }

//    if (i % 2 == 0)
//    {



//        message += encodedMessage[i] + 1;
//        //message2 += (char)message[i];
//        message2 += Convert.ToChar(encodedMessage[i]+1);
//    }
//    else
//    {
//        message += encodedMessage[i] - 1;
//        message2 += Convert.ToChar(encodedMessage[i]-1);

//    }
//}


//Console.WriteLine(message2);
//========================================

//afiseaza numai numerele dintr-un string citit, despartit prin spatiu
//string text = Console.ReadLine();
//            string numbers = "";
//            bool digitAdded = false;

//            for (int i = 0; i < text.Length; i++)
//            {
//                if (text[i] >= '0' && text[i] <= '9')
//                {
//                    numbers += text[i];
//                    digitAdded = true;
//                }
//                else
//                {
//                // numbers += " ";
//                if (digitAdded)
//                    {
//                numbers += " ";
//                digitAdded = false;


//        }
//                }
//            }

//            Console.WriteLine(numbers);
//           // Console.ReadLine();
//================================
//scriem cu enter mai multe numere, la apasare x afisam nr pare
//string inputData = Console.ReadLine();
//int number ;
//bool found = false;
//string nrpare = "";

//do
//{


//    if (inputData == "x") { break; }
//    number = Convert.ToInt32(inputData);

//    if (number % 2 == 0)
//    {


//        nrpare =nrpare + "\n" + number  ;
//        found = true;
//    }
//    inputData = Console.ReadLine();
//        if (inputData == "x") { break; }
//       number = int.Parse(inputData);

//} while (number != 'x');
//if (found == false) { Console.WriteLine("N/A"); }
//else { Console.WriteLine(nrpare); }
//==============================
//inversez un string de numere :citesc 1 2 3, afisez 3 2 1
//string inputData = Console.ReadLine();
//string numbers = Convert.ToString(inputData);
//string result = "";
//string word = "";
//foreach (char c in numbers)
//{
//    if (c == ' ')
//    {
//        result = word + ' ' + result;
//        word = "";
//    }
//    else
//    {
//        word = word + c;
//    }
//}
//result = word + ' ' + result;

//Console.WriteLine(result);

//===============================================
//citesc un C om, nr de admisi, lista nume, daca C se afla in lista, se afiseaza true

//string inputData = Console.ReadLine();
//string Candidat =Convert.ToString(inputData);
//inputData = Console.ReadLine();
//int nrCandidati = Convert.ToInt32(inputData);
//string listaCandidati = "";
//for (int i=0; i < nrCandidati; i++)
//{ inputData = Console.ReadLine();
//    listaCandidati += " " + inputData;
//}
//if (listaCandidati.Contains(Candidat + " "))
//{ Console.WriteLine("True");
//}
//else{
//    Console.WriteLine("False");
//}

//===========================================
//citesc nr de livezi, liniile urmatoare nr de pomi:meri,peri,ciresi
//afisez cati pomi in fiecare livada, apoi cati pomi de fiecare fel



//string inputData = Console.ReadLine();
//int nrLivezi = Convert.ToInt32(inputData);
//int meri = 0, peri = 0, ciresi = 0;

//int[,] pomi = new int[10, 3];
//int rsum;
//int csum ;
//int i, j;
//for ( i = 0; i < nrLivezi; i++)
//{
//    var values = (Console.ReadLine().Split(' '));
//    for ( j = 0; j < 3; j++)
//    {


//        pomi[i, j] = int.Parse(values[j]);

//    }

//}

//for (i = 0; i < nrLivezi; i++)
//{
//    rsum = 0;
//    for (j = 0; j < 3; j++)
//    {
//        rsum += pomi[i, j];
//    }
//    Console.Write("Livada " + (i + 1) + ": " + rsum);
//    Console.WriteLine("");
//}
//for (i = 0; i <3; i++)
//{
//    csum= 0;
//    for (j = 0; j < nrLivezi; j++)
//    { csum+= pomi[j, i]; }
//    if(i==0)Console.WriteLine("Meri: " + csum);
//     if(i==1)Console.WriteLine("Peri: " + csum);
//     if(i==2)Console.WriteLine("Ciresi: " + csum);

//}

//=========================================
//Dat un numar la consola calculati cate patrate
//se pot forma pe o tabla de dimensiunea nxn


//string inputData = Console.ReadLine();
//int n = Convert.ToInt32(inputData);
//int NrPatrate = 0;
//for (int i = 1; i <= n; i++)
//{
//    NrPatrate += i * i;
//}    
//Console.WriteLine(NrPatrate);

//========================================
//afiseaza triunghiul lui Pascal

//using System.Diagnostics.CodeAnalysis;

//string inputData = Console.ReadLine();
//int rows = Convert.ToInt32(inputData);

////int prev = 1;
////Console.Write(prev);
//int sum = 0;
////int rows = 5,
// int   val = 1, blank, i, j;
//Console.WriteLine("Pascal's triangle");
//for (i = 0; i < rows; i++)
//{
//    for (blank = 1; blank <= rows - i; blank++)
//         Console.Write(" ");
//        for (j = 0; j <= i; j++)
//        {
//            if (j == 0 || i == 0)
//                val = 1;
//            else
//                val = val * (i - j + 1) / j;
//            Console.Write(val + " ");
//        //if (j == rows) { sum += val; }
//        }
//    Console.WriteLine();
//}
//==============================
//Afiseaza suma elementelor de pe linia n a triunghiului lui Pascal

//string inputData =  Console.ReadLine();
//int n = Convert.ToInt32(inputData);
//int sum = 1;
//for (int i = 1; i < n; i++)
//{
//    sum *= 2 ;
//}
//if (n == 0) Console.WriteLine(1);
//else Console.WriteLine(sum);
//=================================

//scrie true daca o fraza e un panagram = foloseste toate 26 litere ale alfabetului

//string inputData = Console.ReadLine();
//string phrase = Convert.ToString(inputData);
//string alpha = "abcdefghijklmnopqrstuvwxyz";
//int count = 0;
//foreach (char c in alpha)
//{
//    foreach (char l in phrase.ToLower())
//    {
//        if (c == l)
//        {
//            count++;
//            break;
//        }
//    }
//}
//if (count == 26) Console.WriteLine("True");
//else Console.WriteLine("False");

//==================================

//////cate batoane de ciocolata pot cumpara fiind pachete de 1,2,3,5,10 bucati
string inputData = Console.ReadLine();
int batoane = Convert.ToInt32(inputData);
int pachet10=0, pachet5=0, pachet3 = 0, pachet2 = 0, pachet1 = 0;
while(batoane > 0)
{
    while (batoane >= 10) 
    {

        pachet10 += 1;
        batoane -= 10;
    }

    while(batoane >= 5)
    {

        pachet5 += 1;
        batoane -= 5;
    }
    while(batoane >= 3)
    {

        pachet3 += 1;
        batoane -= 3;
    }
    while (batoane >= 2) 
    {

        pachet2 += 1;
        batoane -= 2;
    }
    while (batoane >= 1) 
    {

        pachet1 += 1;
        batoane -= 1;
    } 
} 
int sum = pachet10 + pachet5 + pachet3 + pachet2 + pachet1;
Console.WriteLine(sum+ " pachete");
if (pachet10 > 0) { Console.WriteLine(pachet10 + " x 10 buc"); }
if (pachet5 > 0) { Console.WriteLine(pachet5 + " x 5 buc"); }
if (pachet3 > 0) { Console.WriteLine(pachet3 + " x 3 buc"); }
if (pachet2 > 0) { Console.WriteLine(pachet2 + " x 2 buc"); }
if (pachet1 > 0) { Console.WriteLine(pachet1 + " x 1 buc"); }
