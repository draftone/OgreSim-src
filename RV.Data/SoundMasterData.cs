using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GameDataEditor;
using UnityEngine;

namespace RV.Data
{
    public class SoundMasterData : AbstractMasterData<GDESoundData>
    {

        void Start()
        {
            GetList();
        }
        public override List<GDESoundData> GetList()
        {
            GDEDataManager.Init("gde_data");
            list_data = GDEDataManager.GetAllItems<GDESoundData>();
            return list_data;
        }

        /// <summary>
        /// @param technicalName
        /// </summary>
        public override GDESoundData GetData(string technicalName)
        {
            GDEDataManager.Init("gde_data");
            GDESoundData sound_data = new GDESoundData(technicalName);
            return sound_data;
        }
        public override int GetListCount()
        {
            return list_data.Count;
        }

        /// <summary>
        /// @param index
        /// </summary>
        public override string GetGDEDataName(int index)
        {
            return list_data[index].name;
        }

        /// <summary>
        /// @param index
        /// </summary>
        public override string GetGDEDataKey(int index)
        {
            return list_data[index].Key;
        }

        public override GDESoundData GetRandomData()
        {
            return list_data[UnityEngine.Random.Range(0, list_data.Count)];
        }
        public override string GetGDEIconPath(int index)
        {
            return null;
        }
    }
}