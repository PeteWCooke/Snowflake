using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Drawing;
using System.Drawing.Drawing2D;

namespace Snowflake
{
    class FlakeArm
    {

        int branches;
        double branchAngle;


        float length;
        double angle;

        float x;
        float y;

        float x2;
        float y2;

        List<FlakeArm> branchList;

        float thickness;

        float thicknessShrinkFactor;

        Color color;

        public FlakeArm(int depth, float x, float y, float length, double angle, int branches, double branchAngle, float shrinkFactor, float thickness, float thicknessShrinkFactor, int maxDepth, Color color)
        {
            this.x = x;
            this.y = y;

            this.length = length;
            this.angle = angle;
            this.branches = branches;
            this.branchAngle = branchAngle;

            x2 = x + length * (float)Math.Cos(angle);
            y2 = y + length * (float)Math.Sin(angle);

            this.thickness = thickness;

            this.thicknessShrinkFactor = thicknessShrinkFactor;

            branchList = new List<FlakeArm>();

            this.color = color;

            // create subflakes

            if ((depth < maxDepth) && (length > 1)) // say
            {

                for (int i = 0; i < branches; i++ )
                {
                    float d = length * (float)(i + 1)/(float)(branches);

                    float newx = x + d * (float)Math.Cos(angle);
                    float newy = y + d * (float)Math.Sin(angle);

                    float lFactor = GetMin((float)i, (float)(branches - (i + 1)));

                    float newLength = ((lFactor + (float)branches) * length * shrinkFactor) / (float)branches;

                    // 

                    branchList.Add(new FlakeArm(depth + 1, newx, newy, length * shrinkFactor, angle - branchAngle, branches, branchAngle, shrinkFactor, thickness * thicknessShrinkFactor, thicknessShrinkFactor, maxDepth, color));
                    branchList.Add(new FlakeArm(depth + 1, newx, newy, length * shrinkFactor, angle + branchAngle, branches, branchAngle, shrinkFactor, thickness * thicknessShrinkFactor, thicknessShrinkFactor, maxDepth, color));
                }
            }
        }


        public float AdjustScale(float dist, float length)
        {
            // todo


            // di = 0... len-1
            // eg len = 4
            //
            // 01,  23
            //

            float f = 0;
            if (dist < (length / 2))
            {
                f = dist;
            }
            else
            {
                f = length - dist - 1;
            }
            return (f / length);
        }

        public float GetMin(float a, float b)
        {
            if (a < b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(color, thickness);

            // Set the DashCap to round.
            pen.DashCap = System.Drawing.Drawing2D.DashCap.Round;

            // Create a custom dash pattern.
            //greenPen.DashPattern = new float[] { 4.0F, 2.0F, 1.0F, 3.0F };


            // Change the SmoothingMode to none.
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            g.DrawLine(pen, x, y, x2, y2);

            foreach (FlakeArm f in branchList)
            {
                f.Draw(g);
            }
        }
    }
}
