namespace StringAlgorithms
{
    public class GeneralStringAlgos
    {
        public static bool isAnagram(string s1, string s2)
        {
            // if length of strings not equal then they cant be anagrams.
            if (s1.Length != s2.Length)
                return false;

            int[] alpha = new int[256];

            for (int i = 0; i < s1.Length; i++)
            {
                alpha[s1[i]]++;
                alpha[s2[i]]--;
            }

            foreach (int i in alpha)
                if (i != 0) return false;

            return true;
        }

        public static bool isPalindrome(string s)
        {
            int start = 0;
            int end = s.Length - 1;

            while (start < end)
            {
                if (s[start] != s[end])
                    return false;

                start++;
                end--;
            }

            return true;
        }
    }
}
