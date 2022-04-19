using UnityEngine;

public static class GameObjectUtils
{
    public static void DestoryIfExist( string name )
    {
        var gameObject = GameObject.Find( name );
        if ( gameObject == null )
        {
            return;
        }
        GameObject.Destroy( gameObject );
    }
}