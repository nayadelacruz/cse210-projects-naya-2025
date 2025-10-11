using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();
    /* add the entry to the list of entries or journal*/
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    /* display all entries from the journal */
    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }
    /* save journal to text file */
    /*public void Save(string filename)
    {
        try
        {

            using (StreamWriter newFile = new StreamWriter(filename))
            {
                foreach (Entry entry in _entries)
                {
                    string line = $"{entry._date}|{entry._prompt}|{entry._response}";
                    newFile.WriteLine(line);
                }
            }

            Console.WriteLine("Your Journal has been saved to " + filename);

        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred while saving the journal: {ex.Message}");
        }
    }    */
    public void SaveCsv(string filename)
    {
        if (!filename.EndsWith(".csv", StringComparison.OrdinalIgnoreCase))
            filename += ".csv";

        using (var newCSV = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                string date = EscapeCsv(entry._date);
                string prompt = EscapeCsv(entry._prompt);
                string response = EscapeCsv(entry._response);
                newCSV.WriteLine($"{date},{prompt},{response}");
            }
        }
        Console.WriteLine("Your Journal has been saved to " + filename);
    }


    /* load journarl from text file */
    /*public void LoadJournal(string filename)
    {
        _entries.Clear(); // Clear existing entries before loading new ones


        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            string date = parts[0];
            string prompt = parts[1];
            string response = parts[2];
            Entry entry = new Entry(prompt, response);
            entry._date = date; // Set the date from the file
            _entries.Add(entry);
            Console.WriteLine($"{date} - {prompt}\n{response}\n");

        }

        Console.WriteLine("Your Journal has been loaded.");
    }*/
    public void LoadCsv(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine($"The file {filename} does not exist.");
            return;
        }
        _entries.Clear(); // Clear existing entries before loading new ones
        var lines = File.ReadAllLines(filename);
        int start = 0;
        if (lines.Length > 0 &&
            lines[0].Trim().StartsWith("date", StringComparison.OrdinalIgnoreCase))
        {
            start = 1;
        }

        for (int i = start; i < lines.Length; i++)
        {
            var fields = ParseCsvLine(lines[i]);
            if (fields.Count < 3) continue; // skip malformed rows

            var date = fields[0];
            var prompt = fields[1];
            var response = fields[2];

            var entry = new Entry(prompt, response);
            entry._date = date; // restore original date
            _entries.Add(entry);
            Console.WriteLine($"{date} - {prompt}\n{response}\n");
        }

    }
    
    private static string EscapeCsv(string input)
    {
        if (input is null) return "";
        bool mustQuote = input.Contains(",") || input.Contains("\"") || input.Contains("\n") || input.Contains("\r");
        string s = input.Replace("\"", "\"\"");
        return mustQuote ? $"\"{s}\"" : s;
    }

    // Parse a single CSV line with quotes and doubled quotes
    private static List<string> ParseCsvLine(string line)
    {
        var result = new List<string>();
        if (line == null)
        {
            result.Add("");
            return result;
        }

        var sb = new StringBuilder();
        bool inQuotes = false;

        for (int i = 0; i < line.Length; i++)
        {
            char c = line[i];

            if (inQuotes)
            {
                if (c == '"')
                {
                    // Lookahead for doubled quote
                    if (i + 1 < line.Length && line[i + 1] == '"')
                    {
                        sb.Append('"'); // add one quote
                        i++;            // skip the second
                    }
                    else
                    {
                        inQuotes = false; // end quoted field
                    }
                }
                else
                {
                    sb.Append(c);
                }
            }
            else
            {
                if (c == ',')
                {
                    result.Add(sb.ToString());
                    sb.Clear();
                }
                else if (c == '"')
                {
                    inQuotes = true;
                }
                else
                {
                    sb.Append(c);
                }
            }
        }

        result.Add(sb.ToString()); // last field
        return result;
    }
}


  



