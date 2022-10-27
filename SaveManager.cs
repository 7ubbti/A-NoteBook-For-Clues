using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace SweetCandy.MisTrust
{
    public class SaveManager
    {
        public static SaveManager instance;
        public static SaveManager Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SaveManager();
                }

                return instance;
            }
        }
        public Save CreateSave()
        {
            Save save = new Save();
            save._OwnedClues = Clue.OwnedClues;
            return save;
        }
        public void SaveGame()
        {
            Fungus.SaveMenu.instance.Save();
            Save save = CreateSave();
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = File.Create(Application.persistentDataPath + "/ClueDatas.sweetcandy");
            bf.Serialize(fs, save);
            fs.Close();
        }
        public void LoadGame()
        {
            if (File.Exists(Application.persistentDataPath + "/ClueDatas.sweetcandy"))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = File.Open(Application.persistentDataPath + "/ClueDatas.sweetcandy", FileMode.Open);//打开文件
                Save save = bf.Deserialize(fs) as Save;
                fs.Close();
                Clue.OwnedClues = save._OwnedClues;
                Fungus.SaveMenu.instance.Load();
            }
            else
            {
                Debug.LogError("Data Not Found");
                //加入弹窗 未找到存档
            }
        }
    }
}