using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
  //This is confusing so I might get stuff wrong but if you want a
  //better understanding of how this all works then I'll link Brackeys'
  //original video on the topic that I followed here:
  //https://www.youtube.com/watch?v=XOjd_qU2Ido

  public static void SaveScore (ClickableG clickG)
  {
      //Referencing the Binary formatter
      BinaryFormatter formatter = new BinaryFormatter();
    
      //The path that the Binary file is created/saved in
      string path = Application.persistentDataPath + "/score.bruh";
      //Adds the data to that file
      FileStream stream = new FileStream(path, FileMode.Create);

      SaveData data = new SaveData(clickG);

      //Collects the variables from the SaveData script and turns them into a binary file
      formatter.Serialize(stream, data);
      stream.Close();
  }

  public static SaveData LoadScore ()
  {
      string path = Application.persistentDataPath + "/score.bruh";

      if (File.Exists(path))
      {
        //Referencing the Binary formatter
        BinaryFormatter formatter = new BinaryFormatter();
        //Adds the data to that file
        FileStream stream = new FileStream(path, FileMode.Open);
        
        //Turns the data from the binary file back into C# variables
        SaveData data = formatter.Deserialize(stream) as SaveData;
        stream.Close();

        return data;
      } 
      else
      {
          //Debug incase of error
          Debug.LogError("Save file not found in " + path);
          return null;
      }
  }

}
