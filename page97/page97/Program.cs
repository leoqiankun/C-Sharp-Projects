using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace page97
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "\"ab";
            string b = "solu";
            string c = "tely\"";
            string word = a + b + c;
            Console.WriteLine(word.ToUpper());

            StringBuilder sb = new StringBuilder();
            sb.Append("Paragraphs are the building blocks of papers.");           
            sb.Append("Many students define paragraphs in terms of length: a paragraph is a group of at least five sentences, a paragraph is half a page long, etc. ");
            sb.Append("In reality, though, the unity and coherence of ideas among sentences is what constitutes a paragraph. ");
            sb.Append("A paragraph is defined as “a group of sentences or a single sentence that forms a unit” (Lunsford and Connors 116).");
            sb.Append("Length and appearance do not determine whether a section in a paper is a paragraph. For instance, in some styles of writing, particularly journalistic styles, a paragraph can be just one sentence long.");
            sb.Append("Ultimately, a paragraph is a sentence or group of sentences that support one main idea. In this handout, we will refer to this as the “controlling idea,” because it controls what happens in the rest of the paragraph.");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
