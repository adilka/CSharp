/* TASK 2
Console.Clear();
Console.Write("Введите числа: " );


int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());




 if (a > b){

 Console.WriteLine( a );
 
 }

 if (b > a ){
 
 Console.WriteLine ( b );
 
 }
 */

 /* TASK 4
 

 Console.Clear();
 Console.Write("Введите числа ");

 int a = Convert.ToInt32(Console.ReadLine());
 int b = Convert.ToInt32(Console.ReadLine());
 int c = Convert.ToInt32(Console.ReadLine());

 if (a > b && a > c){
   Console.WriteLine (a);
 }

 if (b > a && b > c){
   Console.WriteLine (b);
 }

 if (c > a && c > b){
   Console.WriteLine (c);
 }
 */

 /* TASK 6
 Console.Clear();
 Console.Write("Введите число ");

 int n = Convert.ToInt32(Console.ReadLine());

 if (n % 2 == 0){
   Console.WriteLine("Yes");
 }
 
 else {
    Console.WriteLine("No");
 }
 */

 /* TASK 8
 Console.Clear();
 Console.Write("Введите число ");

 int n = Convert.ToInt32(Console.ReadLine());

 for (int i = 1; i <= n; i++) {
   if (i % 2 == 0){
    Console.WriteLine ($"{i}");
   }
   
 }
 */

 // task 12

Console.Clear();

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());

if (n * n == m ){
    if (m * m == n)
    Console.WriteLine("yes");
}
else
    Console.WriteLine($"Не кратно");
