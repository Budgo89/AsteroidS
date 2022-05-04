using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace AsteroidS
{
    [CreateAssetMenu(menuName = "GameData/GameData", fileName = "GameData")]
    public class GameData : ScriptableObject
    {
        [SerializeField] private string _playerDataPath;

        [Header("Assets to place on scene")]
        [SerializeField] private GameObject[] _boundaries;

        private PlayerData _playerData;

        public PlayerData PlayerData
        {
            get 
            {
                if (_playerData == null) _playerData = LoadPath<PlayerData>("GameData/" + _playerDataPath);
                return _playerData;
            }
        }

        private T LoadPath<T>(string path) where T : Object =>
            Resources.Load<T>(Path.ChangeExtension(path, null));
    }
}

