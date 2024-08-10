/*
Lab 6: Serialization and Random Access Files
Ashleen Sidhu
2024-07-20
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Runtime.CompilerServices;
using System.Reflection.Metadata;
using System.Text.Json.Serialization;

namespace Serialization_and_RAF
{
    public class Program
    {
        static void Main(string[] args)
        {
            string filePath = "event.json";

            // Create an object of the Event class
            Event event1 = new Event(1, "Calgary");

            // Create a JsonSerializerOptions instance
            JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };

            // Serialize the event object to JSON
            string jsonString = JsonSerializer.Serialize(event1, options);

            //  Write the serialized JSON data to a file
            File.WriteAllText(filePath, jsonString);

            // Read the serialized JSON data from the file
            var jsonData = File.ReadAllText(filePath);

            // Deserialize the JSON data to an Event object
            Event? event1Deserialized = JsonSerializer.Deserialize<Event>(jsonData);

            // Display the deserialized Event object's properties
            Console.WriteLine(event1Deserialized?.ToString());

            ReadFromFile(filePath);
        }

        static void ReadFromFile(string filePath)
        {
            // Write the word "Hackathon" to the event.json file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.Write("Hackathon");
            }

            // Utilize StreamReader and the Seek method to read and display the first, middle, and last characters from the file
            using (StreamReader reader = new StreamReader(filePath))
            {
                string fileContent = reader.ReadToEnd();
                Console.WriteLine($"In Word: {fileContent}");

                reader.BaseStream.Seek(0, SeekOrigin.Begin);

                // Read the first character
                char firstChar = (char)reader.Read();
                Console.WriteLine($"The First Character: \"{firstChar}\"");

                // Seek to the middle character
                long middlechar = fileContent.Length / 2;
                reader.BaseStream.Seek(middlechar, SeekOrigin.Begin);
                reader.DiscardBufferedData();
                //reader.ReadLine(); // Skip to the next line if necessary

                // Read the middle character
                char middleChar = (char)reader.Read();
                Console.WriteLine($"The Middle Character: \"{middleChar}\"");

                // Seek to the last character
                reader.BaseStream.Seek(-1, SeekOrigin.End);
                reader.DiscardBufferedData();

                // Read the last character
                char lastChar = (char)reader.Read();
                Console.WriteLine($"The Last Character: \"{lastChar}\"");
            }
        }
    }
}
