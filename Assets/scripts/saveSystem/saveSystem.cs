using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class saveSystem : MonoBehaviour
{
    public static void SaveData(levelSystem player)
    {
        string path = Application.persistentDataPath + "/dataPlayer.palePale";
        BinaryFormatter x = new BinaryFormatter();
        FileStream stram = new FileStream(path, FileMode.Create);

        dataPlayer data = new dataPlayer(player);

        x.Serialize(stram, data);
        stram.Close();
        Debug.Log("simpan Baru");
    }


    public static dataPlayer LoadData()
    {
        string path = Application.persistentDataPath + "/dataPlayer.palePale";
        if (File.Exists(path))
        {
            BinaryFormatter x = new BinaryFormatter();
            FileStream stram = new FileStream(path, FileMode.Open);

            dataPlayer data = x.Deserialize(stram) as dataPlayer;
            stram.Close();
            Debug.Log("load");
            return data;
        }
        else
        {
            Debug.Log("unload");
            return null;
        }
    }
}
