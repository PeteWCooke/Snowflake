using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;

namespace Snowflake
{
    [Serializable()]
    class SnowflakeParameters
    {
        public float armAngleDegree = 25.0f;
        public int numberOfArms = 4;
        public float shrinkFactor = 0.4f;
        public float length = 250.0f;
        public float thickness = 1;
        public float thicknessShrinkFactor = 0.5f;
        public int maxDepth = 4;

        public Color backgroundColor;
        public Color foregroundColour;

        public int symmetryOrder;

        public SnowflakeParameters(
                
                float armAngleDegree,
                int numberOfArms,
                float shrinkFactor,
                float length,
                float thickness,
                float thicknessShrinkFactor,
                int maxDepth,
                Color backgroundColor,
                Color foregroundColour,
                int symmetryOrder
        )
        {
            this.armAngleDegree = armAngleDegree;
            this.numberOfArms = numberOfArms;
            this.shrinkFactor = shrinkFactor;
            this.length = length;
            this.thickness = thickness;
            this.thicknessShrinkFactor = thicknessShrinkFactor;
            this.maxDepth = maxDepth;
            this.backgroundColor = backgroundColor;
            this.foregroundColour = foregroundColour;
            this.symmetryOrder = symmetryOrder;
        }
    }
}
