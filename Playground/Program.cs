// ===== 1. List<int> =====
List<int> numbers = new List<int> { 4, 8, 15, 16, 23 };

Console.WriteLine("Forward:");
foreach (int n in numbers)
    Console.WriteLine(n);

Console.WriteLine("Reverse:");
for(int i = numbers.Count -1; i>=0;i--){
    Console.WriteLine(numbers[i]);
}


// ===== 2. Dictionary<char, int> =====
string word = "Indian";
Dictionary<char, int> counts = new Dictionary<char, int>();

// foreach (var count in word){
//     if(word[count] == counts[])
// }

foreach(char c in word)
{
    if(counts.ContainsKey(c))
        counts[c] = counts[c] +1;
    else    
        counts[c] = 1;
}


foreach(var pair in counts)
{
    Console.WriteLine($"{pair.Key} : {pair.Value}");
}
// TODO: foreach char c in word
//   if counts already has c as a key -> add 1 to it
//   otherwise -> add c with a count of 1

// TODO: foreach pair in counts, print "letter: count"


// ===== 3. HashSet<int> =====
int[] nums = { 3, 1, 3, 2, 1 };
HashSet<int> seen = new HashSet<int>();

foreach(int n in nums)
{
    if(!seen.Contains(n))
        seen.Add(n);
    else
        Console.WriteLine($"Duplicate: {n}");
}

// TODO: foreach n in nums
//   if seen already contains n -> print "Duplicate: n"
//   otherwise -> add n to seen