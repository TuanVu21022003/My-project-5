using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="LevelOS", menuName = "ScriptableObject/LevelOS")]

public class LevelOS : ScriptableObject
{
    public List<LevelDataItem> list = new List<LevelDataItem>();
}
