using UnityEngine;

namespace CollapsibleScriptableObject.Example
{
    public class AwesomeComponent : MonoBehaviour
    {
        [InlineScriptableObject] [SerializeField] private AwesomeScriptableObject _importantProp;
    }
}