Console.Clear();
Console.Write("insert an integer: ");
string number=Console.ReadLine()!;
bool comp=true;
for(int i=number.Length-1;i>=number.Length/2;i--){
    if (number[number.Length-i-1]!=number[i]){
        comp=false;
        break;
    }
}
if (comp)Console.WriteLine($"The number {number} is a polyndrome");
else Console.WriteLine($"The number {number} is not a polyndrome");
