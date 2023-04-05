
// couldnt resolve the error 


string[] Names = { "Mary", "John", "Emma" };
int[] Height = { 180, 165, 170 };

//SortHeight(Names , Height );
//static string[] SortHeight(string[] Names, int[] Height)
//{

for (int i = 0; i < Names.Length; i++)
{
    var tallest = i;

    for (var j = i + 1; j < Names.Length; j++)
    {
        if (Height[j] > Height[tallest])
        {
            tallest = j;
        }
    }
    var TallestPerson = Names[i];
    Names[i] = Names[tallest];
    Names[tallest] = TallestPerson;

    var heightOfTallest = Height[i];
    Height[i] = Height[tallest];
    Height[tallest] = heightOfTallest;

}
// Console.WriteLine(Convert.ToString(Names));
Console.WriteLine(Names);
//return Names;
//}
