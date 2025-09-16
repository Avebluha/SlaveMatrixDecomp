using System;


namespace _2DGAMELIB
{
    [Serializable]
    public struct Vector2D_2
    {
    	public Vector2D v1;

    	public Vector2D v2;

    	public Vector2D_2(Vector2D v1, Vector2D v2)
    	{
    		this.v1 = v1;
    		this.v2 = v2;
    	}
    }
}