using System;

namespace ConsoleApp1
{ 
    public class Agenda
    {
        private readonly List<string> entries = new List<string>();

        private static int count = 0;

        public int AddEntry(string text)
        {
            entries.add($"{++count} + {text}");
            return count;
        }

        public void RemoveEntry(int index) {
            entries.RemoveAt(index);
        }

        public override string ToString()
        {
            return string.Join(Environment.NewLine, entries);
        }
    }
}