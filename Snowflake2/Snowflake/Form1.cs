using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Snowflake
{
    public partial class Form1 : Form
    {



        List<FlakeArm> snowflake = new List<FlakeArm>();


        SnowflakeParameters sfp;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            // use it to generate possible IOS images at 512x512

            pbxDisplay2.Width = 512;
            pbxDisplay2.Height = 512;

            pbxForegroundColour.BackColor = Color.Orange;
            pbxBackgroundColour.BackColor = Color.DarkBlue;


            Recreate();

            
        }


        private void Recreate()
        {

            sfp = new SnowflakeParameters(
                (float)nudArmAngle.Value,
                (int)nudNumberOfArms.Value,
                ((float)nudShrinkFactor.Value) / 100.0f,
                (float)nudLength.Value,
                (float)nudThickness.Value,
                (float)nudThicknessShrink.Value / 100.0f,
                (int)nudMaxDepth.Value,
                pbxBackgroundColour.BackColor,
                pbxForegroundColour.BackColor,
                (int)nudSymmetryOrder.Value);

            pbxDisplay2.BackColor = sfp.backgroundColor;
            pbxDisplay2.ForeColor = sfp.foregroundColour;

            snowflake.Clear();

            float x = pbxDisplay2.Width / 2;
            float y = pbxDisplay2.Height / 2;

            int numberOfFlakes = (int)nudSymmetryOrder.Value;

            for (int i = 0; i < numberOfFlakes; i++)
            {
                float theta = (float)Math.PI * 2 * (float)i / numberOfFlakes;


                snowflake.Add(new FlakeArm(0, x, y, sfp.length, theta, sfp.numberOfArms, sfp.armAngleDegree * Math.PI / 180.0f, sfp.shrinkFactor, sfp.thickness, sfp.thicknessShrinkFactor, sfp.maxDepth, sfp.foregroundColour));
            }
            pbxDisplay2.Invalidate();

        }


        private void pbxDisplay(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Rectangle rect = new Rectangle(0,0, pbxDisplay2.Width, pbxDisplay2.Height);

            Brush br = new SolidBrush(sfp.backgroundColor);

            g.FillRectangle(br, rect);


            foreach(FlakeArm f in snowflake)
            {
                f.Draw(g);
            }
        }

        private void nudArmAngle_ValueChanged(object sender, EventArgs e)
        {
            Recreate();
        }

        private void nudNumberOfArms_ValueChanged(object sender, EventArgs e)
        {
            Recreate();
        }

        private void nudShrinkFactor_ValueChanged(object sender, EventArgs e)
        {
            Recreate();
        }

        private void nudLength_ValueChanged(object sender, EventArgs e)
        {
            Recreate();
        }

        private void nudThickness_ValueChanged(object sender, EventArgs e)
        {
            Recreate();
        }

        private void nudThicknessShrink_ValueChanged(object sender, EventArgs e)
        {
            Recreate();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Recreate();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            string saveFilename = null;
            SaveFileDialog saveDialog = saveFileDialog1;
            saveDialog.DefaultExt = "*.png";
            saveDialog.Filter = "Images(png0|*.png";

            DialogResult dr = saveFileDialog1.ShowDialog();


            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // this could fail so we need a try catch block around it


                try
                {
                    saveFilename = saveFileDialog1.FileName;

                    //this is the net recipe for saving an list of serializable objects
                    //serializable means able to be sent to a filestream

                    Save(saveFilename);


                }
                catch (System.IO.IOException ex)
                {
                    MessageBox.Show(ex.Message, "File Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }


        private void Save(string saveFilename)
        {
            int width = pbxDisplay2.Width;
            int height = pbxDisplay2.Height;


            Bitmap bitmap = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            Graphics g = Graphics.FromImage(bitmap);

            foreach (FlakeArm f in snowflake)
            {
                f.Draw(g);
            }

            g.Dispose();

            // save....

            //string name = String.Format("test{0}x{1}.png", width, height);

            bitmap.Save(saveFilename, System.Drawing.Imaging.ImageFormat.Png);         // or a bmp


        }

        private void btnLoadSettings_Click(object sender, EventArgs e)
        {
            LoadSnowflakeData();
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            SaveSnowflakeData();
        }


        private void SaveSnowflakeData()
        {
            //create the save dialog

            string saveFilename = null;
            SaveFileDialog saveDialog = saveFileDialog1;
            saveDialog.DefaultExt = "*.txt";
            saveDialog.Filter = "Snowflake data files|*.snowflake";

            DialogResult dr = saveFileDialog1.ShowDialog();


            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                // this could fail so we need a try catch block around it


                try
                {
                    saveFilename = saveFileDialog1.FileName;

                    //this is the net recipe for saving an list of serializable objects
                    //serializable means able to be sent to a filestream

                    System.IO.FileStream s = new System.IO.FileStream(saveFilename, System.IO.FileMode.Create);
                    System.Runtime.Serialization.Formatters.Binary.BinaryFormatter f = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    f.Serialize(s, sfp);
                    s.Close();
                }
                catch (System.IO.IOException ex)
                {
                    MessageBox.Show(ex.Message, "File Save Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void LoadSnowflakeData()
        {
            string fileName = null;
            OpenFileDialog openDialog = openFileDialog1;

            openDialog.DefaultExt = "*.txt";
            openDialog.Filter = "Snowflake data files(snowflake)|*.snowflake";

            DialogResult dr = openFileDialog1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                //could fail - so we have a try catch block
                //also we load to a second copy of the animal list
                //then if the load is ok we copy the data to the original list
                //
                //this means that if the load fails we won't lose any original list

                try
                {
                    fileName = openFileDialog1.FileName;

                    System.IO.FileStream filestream = new System.IO.FileStream(fileName, System.IO.FileMode.Open);
                    System.Runtime.Serialization.Formatters.Binary.BinaryFormatter f = new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();
                    SnowflakeParameters restoredSfp = null;
                    restoredSfp = (SnowflakeParameters)f.Deserialize(filestream);
                    filestream.Close();

                    // copy this across to the real one

                    sfp = restoredSfp;

                    // copy to the controls

                    //sfp = new SnowflakeParameters(
                    nudArmAngle.Value = (decimal)restoredSfp.armAngleDegree;
                    nudNumberOfArms.Value = restoredSfp.numberOfArms;
                    nudShrinkFactor.Value = (decimal)(restoredSfp.shrinkFactor * 100.0f);
                    nudLength.Value = (decimal)restoredSfp.length;                                         
                    nudThickness.Value = (decimal)restoredSfp.thickness;
                    nudThicknessShrink.Value = (decimal)(restoredSfp.thicknessShrinkFactor * 100.0f);
                    nudMaxDepth.Value = restoredSfp.maxDepth;
                    
                    // colour to do later...

                    pbxForegroundColour.BackColor = restoredSfp.foregroundColour;
                    pbxBackgroundColour.BackColor = restoredSfp.backgroundColor;

                    nudSymmetryOrder.Value = restoredSfp.symmetryOrder;

                    Recreate();



                }
                catch (System.IO.IOException ex)
                {
                    MessageBox.Show(ex.Message, "File Load Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        private void btnForegroundColour_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = false;
            colorDialog1.ShowHelp = true;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pbxForegroundColour.BackColor = colorDialog1.Color;
                Recreate();
            }
        }

        private void btnBackgroundColour_Click(object sender, EventArgs e)
        {
            colorDialog1.AllowFullOpen = false;
            colorDialog1.ShowHelp = true;

            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                pbxBackgroundColour.BackColor = colorDialog1.Color;
                Recreate();
            }
        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {
            Recreate();
        }
    }
}
