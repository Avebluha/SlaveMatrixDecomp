using System;
using System.IO;

namespace _2DGAMELIB
{

    //its the position of a joint
    [Serializable]
    public class JointPoint
    {
    	public Vector2D Joint = DataConsts.Vec2DZero;

    	public JointPoint(JointPoint JointPoint)
    	{
    		Joint = JointPoint.Joint;
    	}

    	public JointPoint(Vector2D Joint)
    	{
    		this.Joint = Joint;
    	}

    }
}
