string pangram = "The quick brown fox jumps over the lazy dog";
string[] words = pangram.Split(' ');
int wordsCount = words.Length;

// More efficient way to build the reversed pangram
string reversedPangram = string.Join(" ", words.Select(word => new string(word.Reverse().ToArray())));

Console.WriteLine(reversedPangram);