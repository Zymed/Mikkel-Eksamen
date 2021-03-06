using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Text;

namespace Assets.Sommer.BL
{
    
    public class SaveToJson
    {

        private static readonly string _fileName = "/timers.json";
        public static string filePath { get; private set; } = Application.persistentDataPath + _fileName;

        public static void WriteTimersToJson()
        {            
            string outputJson = JsonUtility.ToJson(TimerClasses.Instance);

            File.WriteAllText(filePath, outputJson);
            Debug.Log("File has been saved as json file at: " + filePath);
            Debug.Log("File has been saved with " + TimerClasses.Instance.Timers.Count + " amount of numbers in the list.");
            Debug.Log("The content of the list is: " + outputJson);
        }

        public static void ReadTimersFromJson()
        {
            string inputJson =  File.ReadAllText(filePath);
            TimerClasses myTimers = JsonUtility.FromJson<TimerClasses>(inputJson); 
        }
    }
}
