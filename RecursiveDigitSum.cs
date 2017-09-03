using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static Int64 ToInteger (string N){
        char[] chars = N.ToCharArray();
        Int64 temp = 0;
        foreach(var ch in chars) temp += Int64.Parse(ch.ToString());
        return temp;
    }
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string[] s = Console.ReadLine().Split(' ');
        int k = Int32.Parse(s[1]);
        var n = ToInteger(s[0]) * k;
        while (n.ToString().Length != 1) n = ToInteger(n.ToString());
        Console.WriteLine(n);
    }
}
