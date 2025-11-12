    using UnityEngine;
    using System.Collections.Generic;

    [CreateAssetMenu(fileName = "DabaseGambar", menuName = "Scriptable Objects/DabaseGambar")]
    public class DabaseGambar : ScriptableObject
    {
        public List<Sprite> ListGambar = new List<Sprite>();
    }
