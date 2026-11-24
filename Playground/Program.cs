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


// ===== 4. Stack<int> =====
Stack<int> stack = new Stack<int>();
int x = 1;
while (x < 4)
{
    
    stack.Push(x);
    x++;
}

Console.WriteLine("Stack (LIFO):");
while (stack.Count > 0)
{
    Console.WriteLine(stack.Peek());
    stack.Pop();
}


// ===== 5. Queue<int> =====
Queue<int> queue = new Queue<int>();

int y = 1;
while (y < 4)
{
    
    queue.Enqueue(y);
    y++;
}

Console.WriteLine("Queue (FIFO):");
while (queue.Count > 0)
{
    Console.WriteLine(queue.Peek());
    queue.Dequeue();
}


// ===== 6. PriorityQueue<string, int> =====
PriorityQueue<string, int> tasks = new PriorityQueue<string, int>();

// TODO: enqueue "Fix bug" with priority 1
// TODO: enqueue "Write tests" with priority 3
// TODO: enqueue "Code review" with priority 2

tasks.Enqueue("Fix bug",1);
tasks.Enqueue("Write tests",3);
tasks.Enqueue("Code review",2);

Console.WriteLine("PriorityQueue (lowest priority number first):");
while (tasks.Count > 0)
{
    Console.WriteLine(tasks.Peek());
    tasks.Dequeue();
}