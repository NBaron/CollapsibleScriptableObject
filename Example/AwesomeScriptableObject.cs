using UnityEngine;

namespace CollapsibleScriptableObject.Example
{
    [CreateAssetMenu]
    public class AwesomeScriptableObject : ScriptableObject
    {
        [SerializeField] private int _importantValue;

        public int GetValue() => _importantValue;
    }
}