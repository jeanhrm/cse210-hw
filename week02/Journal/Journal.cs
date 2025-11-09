using System;
using System.Collections.Generic;
using System.IO;

namespace JournalProgram
{
    public class Journal
    {
        private readonly List<Entry> _entries;

        private const string Separator = "~|~";

        public Journal()
        {
            _entries = new List<Entry>();
        }

        public void AddEntry(Entry entry)
        {
            _entries.Add(entry);
        }

        public void DisplayEntries()
        {
            if (_entries.Count == 0)
            {
                Console.WriteLine("There are no journal entries yet.");
                return;
            }

            Console.WriteLine("\n--- Journal Entries ---\n");

            foreach (var e in _entries)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void SaveToFile(string filename)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    foreach (var e in _entries)
                    {
                        string safeResponse = e.Response.Replace("\r\n", "\\n").Replace("\n", "\\n");
                        string safePrompt = e.Prompt.Replace("\r\n", " ").Replace("\n", " ");
                        writer.WriteLine($"{e.Date}{Separator}{safePrompt}{Separator}{safeResponse}");
                    }
                }

                Console.WriteLine($"Journal saved successfully to '{filename}'.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving file: {ex.Message}");
            }
        }

        public void LoadFromFile(string filename)
        {
            try
            {
                if (!File.Exists(filename))
                {
                    Console.WriteLine("File not found.");
                    return;
                }

                string[] lines = File.ReadAllLines(filename);
                var newEntries = new List<Entry>();

                foreach (var line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    string[] parts = line.Split(new string[] { Separator }, StringSplitOptions.None);

                    if (parts.Length >= 3)
                    {
                        string date = parts[0];
                        string prompt = parts[1];
                        string response = parts[2].Replace("\\n", Environment.NewLine);
                        newEntries.Add(new Entry(date, prompt, response));
                    }
                }

                _entries.Clear();
                _entries.AddRange(newEntries);

                Console.WriteLine($"Journal loaded successfully. {_entries.Count} entries found.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading file: {ex.Message}");
            }
        }
    }
}
