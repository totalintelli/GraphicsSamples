using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsSamples
{
    public partial class GraphicsSamplesForm : Form
    {
        bool btnRotateTransformClicked = false;    // RotateTransform 버튼이 클릭되었는지 여부
        bool btnSetClipPathCombineClicked = false; // SetClipPathCombine 버튼이 클릭되었는지 여부
        bool btnDrawStringClicked = false;         // DrawString 버튼이 클릭되었는지 여부 
        bool btnSetAndFillClipClicked = false;              // 초기화 버튼이 클릭되었는지 여부

        public GraphicsSamplesForm()
        {
            InitializeComponent();
            btnRotateTransformClicked = false;
            btnSetClipPathCombineClicked = false;
            btnDrawStringClicked = false;
            btnSetAndFillClipClicked = false;
        }

        private void btn_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if(btn == btnRotateTransform)
            {
                btnRotateTransformClicked = true;

            }
            else if(btn == btnSetClipPathCombine)
            {
                btnSetClipPathCombineClicked = true;
            }
            else if(btn == btnDrawString)
            {
                btnDrawStringClicked = true;
            }
            else if(btn == btnSetAndFillClip)
            {
                btnSetAndFillClipClicked = true;
            }

            Invalidate();
        }

        private void GraphicsSamplesForm_Paint(object sender, PaintEventArgs e)
        {
            if(btnRotateTransformClicked)
            {
                RotateTransformAngle(e);
            }
            else if(btnSetClipPathCombineClicked)
            {
                SetClipPathCombine(e);
            }
            else if(btnDrawStringClicked)
            {
                DrawStringPointF(e);
            }
            else if(btnSetAndFillClipClicked)
            {
                SetAndFillClip(e);
            }

            BeginContainerVoid(e);

            btnRotateTransformClicked = false;
            btnSetClipPathCombineClicked = false;
            btnDrawStringClicked = false;
            btnSetAndFillClipClicked = false;
        }

        private void RotateTransformAngle(PaintEventArgs e)
        {

            // Set world transform of graphics object to translate.
            e.Graphics.TranslateTransform(100.0F, 0.0F);

            // Then to rotate, prepending rotation matrix.
            e.Graphics.RotateTransform(30.0F);

            // Draw rotated, translated ellipse to screen.
            e.Graphics.DrawEllipse(new Pen(Color.Blue, 3), 0, 0, 200, 80);
        }

        private void SetClipPathCombine(PaintEventArgs e)
        {

            // Create graphics path.
            GraphicsPath clipPath = new GraphicsPath();
            clipPath.AddEllipse(0, 0, 200, 100);

            // Set clipping region to path. 
            //e.Graphics.SetClip(clipPath, CombineMode.Replace); // CombineMode.Replace : 클립 영역에 있는 부분만 출력
            e.Graphics.SetClip(clipPath, CombineMode.Exclude);   // CombineMode.Exclude : 클립 영역을 제외한 부분을 출력

            // Fill rectangle to demonstrate cliping region
            e.Graphics.FillRectangle(new SolidBrush(Color.Black), 0, 0, 500, 300);

            btnSetClipPathCombineClicked = false;
        }

        private void DrawStringPointF(PaintEventArgs e)
        {

            // Create string to draw.
            String drawString = "Sample Text";

            // Create font and brush.
            Font drawFont = new Font("Arial", 16);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            // Create point for upper-left corner of drawing.
            PointF drawPoint = new PointF(0.0F, 0.0F);

            // Draw string to screen.
            e.Graphics.DrawString(drawString, drawFont, drawBrush, drawPoint);
        }

        private void SetAndFillClip(PaintEventArgs e)
        {

            // Set the Clip property to a new region.
            e.Graphics.Clip = new Region(new Rectangle(10, 10, 100, 200));

            // Fill the region.
            e.Graphics.FillRegion(Brushes.LightSalmon, e.Graphics.Clip);

            // Demonstrate the clip region by drawing a string
            // at the outer edge of the region.
            e.Graphics.DrawString("Outside of Clip", new Font("Arial", 
                12.0F, FontStyle.Regular), Brushes.Black, 0.0F, 0.0F); 
        }

        private void BeginContainerVoid(PaintEventArgs e)
        {
            // Begin graphics container.
            GraphicsContainer containerState = e.Graphics.BeginContainer();

            // Translate workd transformation.
            e.Graphics.TranslateTransform(100.0F, 100.0F);

            // Fill translated rectangle in container with red.
            e.Graphics.FillRectangle(new SolidBrush(Color.Red), 0, 0, 200, 200);

            // End graphics container.
            e.Graphics.EndContainer(containerState);

            // Fill untransformed rectangle with green.
            e.Graphics.FillRectangle(new SolidBrush(Color.Green), 0, 0, 200, 200);
        }
    }
}
