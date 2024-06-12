string pangram = "The quick brown fox jumps over the lazy dog";

string[] words = pangram.Split(' ');
string reversedPangram = "";

for (int i = words.Length - 1; i >= 0; i--)
{
    words[i] = words[i].Reverse();
    reversedPangram += words[i] + " ";
}