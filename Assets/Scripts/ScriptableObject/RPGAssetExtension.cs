using UnityEngine;
using UnityEditor;

public class RPGAssetExtension : ScriptableObject
{
	[MenuItem("Assets/Create/RPG/Coins")]
	static void CreateCharacter()
	{
        ScriptableObjectUtility.CreateAsset<Coins>();
	}

}
