using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveSystem
{
    public static void SaveString(SaveData text)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/data.jpg";
        FileStream stream = new FileStream(path, FileMode.Create);

        SaveData data = text;

        formatter.Serialize(stream, data);
        stream.Close();
        Debug.Log("File saved at[" + path + "] with no issues.");
    }

    public static SaveData LoadString()
    {
        string path = Application.persistentDataPath + "/data.jpg";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            SaveData data = formatter.Deserialize(stream) as SaveData;
            stream.Close();
            Debug.Log("File found successfully at: " + path);
            return data;
        }
        else
        {
            Debug.LogError("Save file not found in " + path);
            return null;
        }
    }
}
