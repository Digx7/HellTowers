using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class SpecialEvents : MonoBehaviour
{
}

[System.Serializable]
public class BoolEvent : UnityEvent<bool>
{
}

[System.Serializable]
public class IntEvent : UnityEvent<int>
{
}

[System.Serializable]
public class FloatEvent : UnityEvent<float>
{
}

[System.Serializable]
public class DoubleEvent : UnityEvent<double>
{
}

[System.Serializable]
public class StringEvent : UnityEvent<string>
{
}

[System.Serializable]
public class Vector2Event : UnityEvent<Vector2>
{
}

[System.Serializable]
public class Vector3Event : UnityEvent<Vector3>
{
}

[System.Serializable]
public class Collision2DEvent : UnityEvent<Collision2D>
{
}

[System.Serializable]
public class Collider2DEvent : UnityEvent<Collider2D>
{
}

[System.Serializable]
public class CollisionEvent : UnityEvent<Collision>
{
}

[System.Serializable]
public class ColliderEvent : UnityEvent<Collider>
{
}
