using UnityEngine;
 
/// <summary>
/// Use this property on a ScriptableObject type to allow the editors drawing the field to draw an expandable
/// area inline that allows for changing the values on the object without having to change editor.
/// </summary>
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public class InlineScriptableObjectAttribute : PropertyAttribute
{
    public InlineScriptableObjectAttribute()
    { 
    }
}