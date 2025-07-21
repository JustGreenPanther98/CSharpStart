String s="why";
s.Replace("y", "sh"); 
String[] w = s.Split("");
s=s.Insert(1, "d");
Console.WriteLine(s.Reverse());
for(int i = 0; i < s.Length; i++)
    Console.WriteLine(s[i]);
