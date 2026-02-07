#region Q1
double d = 9.99;
int x = (int)d;
Console.WriteLine(x);
#endregion


#region Q2
int n = 5;
double d2 = n / 2.0;
Console.WriteLine(d2);
#endregion


#region Q3
int age = int.Parse(Console.ReadLine());
#endregion



#region Q4
string s = "12a";
int x = int.Parse(s);//Runtime Exception
Console.WriteLine(x);
#endregion


#region Q5
string v = "12a";

if (int.TryParse(s, out int x))
    Console.WriteLine(x);
else
    Console.WriteLine("Invalid");
#endregion



#region Q6
object o = 10;
int a = (int)o;
Console.WriteLine(a + 1);
#endregion


#region Q7
object n = 10;
long e = Convert.ToInt64(o);
Console.WriteLine(x);
#endregion


#region Q8
object i = 10;

long q = o is long l ? l : -1;
Console.WriteLine(x);
#endregion

#region Q9
string? name = null;
Console.WriteLine(name?.Length);
#endregion


#region Q10
string? name2 = null;
int length = name2?.Length ?? 0;
Console.WriteLine(length);
#endregion

#region Q11
//string? s = null;
//int x = int.Parse(s ?? "0");
int w = int.TryParse(s, out int r) ? r : 0;
#endregion


#region Q12
string? u = null;
Console.WriteLine(s?.Length ?? 0);
#endregion


#region Q13
string? c = null;
int p = Convert.ToInt32(s);
Console.WriteLine(x);
#endregion


#region Q14
string? z = null;

// A
// int a = int.Parse(s);   // ❌ Exception

// B
int b = Convert.ToInt32(s); // ✔ 0
Console.WriteLine(b);
#endregion


#region Q15
string? user = null;
Console.WriteLine(user?.ToUpper() ?? "Guest");
#endregion
