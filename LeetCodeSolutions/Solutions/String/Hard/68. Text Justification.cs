using System.Text;

namespace LeetCodeSolutions.Solutions.String.Hard;

public static class Text_Justification {
    
    public static IList<string> FullJustify(string[] words, int maxWidth)
    {
        var text = new List<string>(words.Length);
        var strokeWords = new List<string>((maxWidth / 2) + 1);
        var builder = new StringBuilder(maxWidth);
        
        var wordIndex = 0;
        while (wordIndex < words.Length)
        {
            if (words[wordIndex].Length == maxWidth)
            {   // Handle stroke-sized word
                text.Add(words[wordIndex]);
                wordIndex++;
                continue;
            }

            if (wordIndex == words.Length - 1)
            {   // Handle last word
                var lastWord = words[wordIndex];
                builder.Append(lastWord);
                builder.Append(' ', maxWidth - lastWord.Length);
                text.Add(builder.ToString());
                break;
            }

            var strokeWordsLength = 0;
            while (true)
            {
                var currentWord = words[wordIndex];
                if (strokeWordsLength + currentWord.Length + strokeWords.Count <= maxWidth)
                {
                    wordIndex++;
                    strokeWordsLength += currentWord.Length;
                    strokeWords.Add(currentWord);
                }
                else
                    break;

                if(wordIndex == words.Length)
                    break;
            }

            var emptySpace = maxWidth - strokeWordsLength;
            var spaceLength = strokeWords.Count > 1 ?  emptySpace / (strokeWords.Count - 1) : emptySpace;
            var extraSpace = emptySpace - spaceLength * (strokeWords.Count - 1);

            if (wordIndex == words.Length)
            {
                spaceLength = 1;
                extraSpace = 0;
            }
            
            for (int i = 0; i < strokeWords.Count; i++)
            {
                builder.Append(strokeWords[i]);
                if(i == strokeWords.Count - 1) continue;
                builder.Append(' ', spaceLength);
                if (extraSpace-- > 0) 
                    builder.Append(' ');
            }
            
            builder.Append(' ', maxWidth - builder.Length);
            text.Add(builder.ToString());
            builder.Clear();
            strokeWords.Clear();
        }
        
        return text;
    }
}