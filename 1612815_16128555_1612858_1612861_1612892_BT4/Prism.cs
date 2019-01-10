using System;
using SharpGL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using SharpGL.SceneGraph;

namespace Lab04
{
    class Prism : Object
    {
        //private Vertex BeginPoint;//toa do cua 1 diem cua 1 mat tam giac
        private double R_bot;
        private double alpha;
        private Vertex _center;

        public Prism() //màu nền, tâm, chiều dài cạnh, check đang chọn
        {
            //if (center != null)
            //    _center = center; //tâm (mặc định (0,0,0))
            _center = new Vertex(0, 0, 0);
            _length = 2.0f; //độ dài cạnh cua mat day tam giac
            _height = 5.0f; // chieu cao cua lang tru
            _color = Color.White; //màu nền mặt phẳng
            _color = Color.White; //màu nền mặt phẳng
            //delta = new Vertex(_center.x - 0 - _length / 2, _center.y - 0 - _length / 2, _center.z - 0 - );
            //delta = độ chênh lệch các tọa độ của 2 tâm để dịch các đỉnh theo delta
            _Solid = false; //check xem có đang thao tác trên hình này không
            alpha = 2 * Math.PI / 3;
            R_bot = Math.Sqrt(3) * _length / 3;
            listVertex = new List<Vertex>();
            //_countObjects++;
            type = 2;

            listVertex = new List<Vertex> { new Vertex(), new Vertex(), new Vertex(), new Vertex(), new Vertex(), new Vertex(), new Vertex(), new Vertex() };
            angelX = angelY = angelZ = 0;
            tX = tY = tZ = 0;
            sX = sY = sZ = 1;
        }

        private void Save()
        {
            listVertex.Clear();
            R_bot = Math.Sqrt(3) * _length / 3;
            // Lưu tất cả đỉnh, hinh chay doc theo truc y
            Vertex V1, V2, V3, V4, V5, V6; //6 đỉnh
            //listVertex = new List<Vertex>();
            //3 diem dau la mot tam giac
            V1 = new Vertex(_center.x + R_bot, _center.y - _height / 2, _center.z);
            V2 = new Vertex(_center.x + R_bot * Math.Cos(alpha), _center.y - _height / 2, _center.z + R_bot * Math.Sin(alpha));
            V3 = new Vertex(_center.x + R_bot * Math.Cos(2 * alpha), _center.y - _height / 2, _center.z + R_bot * Math.Sin(2 * alpha));
            //3 diem con lai cung tao nen mot mat tam giac
            V4 = new Vertex(V1.x, _center.y + _height / 2, V1.z);
            V5 = new Vertex(V2.x, _center.y + _height / 2, V2.z);
            V6 = new Vertex(V3.x, _center.y + _height / 2, V3.z);

            listVertex.Add(V1);
            listVertex.Add(V2);
            listVertex.Add(V3);
            listVertex.Add(V4);
            listVertex.Add(V5);
            listVertex.Add(V6);
        }

        public override void Draw(OpenGLControl glControl)
        {
            OpenGL gl = glControl.OpenGL;
            Save();
            gl.PushMatrix();
            gl.Rotate((float)angelX, (float)angelY, (float)angelZ);
            gl.Translate(tX, tY, tZ);
            gl.Scale(sX, sY, sZ);

            gl.Color(_color.R / 255.0, _color.G / 255.0, _color.B / 255.0, 0);
            gl.Begin(OpenGL.GL_TRIANGLES);
            //Ve mat tam giac
            gl.Vertex(listVertex[0].x, listVertex[0].y, listVertex[0].z); // V1
            gl.Vertex(listVertex[1].x, listVertex[1].y, listVertex[1].z); // V2
            gl.Vertex(listVertex[2].x, listVertex[2].y, listVertex[2].z); // V3

            gl.Vertex(listVertex[3].x, listVertex[3].y, listVertex[3].z); // V4
            gl.Vertex(listVertex[4].x, listVertex[4].y, listVertex[4].z); // V5
            gl.Vertex(listVertex[5].x, listVertex[5].y, listVertex[5].z); // V6

            gl.End();

            gl.Color(_color.R / 255.0, _color.G / 255.0, _color.B / 255.0, 0);
            gl.Begin(OpenGL.GL_QUADS);
            //Ve mat ben
            gl.Vertex(listVertex[0].x, listVertex[0].y, listVertex[0].z); // V1
            gl.Vertex(listVertex[1].x, listVertex[1].y, listVertex[1].z); // V2
            gl.Vertex(listVertex[4].x, listVertex[4].y, listVertex[4].z); // V5
            gl.Vertex(listVertex[3].x, listVertex[3].y, listVertex[3].z); // V4

            gl.Vertex(listVertex[0].x, listVertex[0].y, listVertex[0].z); // V1
            gl.Vertex(listVertex[2].x, listVertex[2].y, listVertex[2].z); // V3
            gl.Vertex(listVertex[5].x, listVertex[5].y, listVertex[5].z); // V6
            gl.Vertex(listVertex[3].x, listVertex[3].y, listVertex[3].z); // V4

            gl.Vertex(listVertex[1].x, listVertex[1].y, listVertex[1].z); // V2
            gl.Vertex(listVertex[2].x, listVertex[2].y, listVertex[2].z); // V3
            gl.Vertex(listVertex[5].x, listVertex[5].y, listVertex[5].z); // V6
            gl.Vertex(listVertex[4].x, listVertex[4].y, listVertex[4].z); // V5

            gl.End();

            VienKhung(gl);
            gl.PopMatrix();
            gl.Flush();// Thực hiện lệnh vẽ ngay lập tức thay vì đợi sau 1 khoảng thời gian
        }

        private void VienKhung(OpenGL gl)
        {
            if (_Solid) //nếu đang thao tác trên hình
            {
                //viền cam đậm
                gl.Color(236 / 255.0, 135 / 255.0, 14 / 255.0);
                //tăng kích cỡ viền
                gl.LineWidth((float)2);
            }
            else // nếu không thao tác
            {
                //viền đen nhạt
                gl.Color(255 / 255.0, 255 / 255.0, 255 / 255.0);
                //tăng kích cỡ viền
                gl.LineWidth((float)2);
            }

            gl.Begin(OpenGL.GL_LINES);
            //Vẽ các cạnh
            gl.Vertex(listVertex[0].x, listVertex[0].y, listVertex[0].z); // V1
            gl.Vertex(listVertex[1].x, listVertex[1].y, listVertex[1].z); // V2

            gl.Vertex(listVertex[1].x, listVertex[1].y, listVertex[1].z); // V2
            gl.Vertex(listVertex[2].x, listVertex[2].y, listVertex[2].z); // V3

            gl.Vertex(listVertex[0].x, listVertex[0].y, listVertex[0].z); // V1
            gl.Vertex(listVertex[2].x, listVertex[2].y, listVertex[2].z); // V3

            gl.Vertex(listVertex[0].x, listVertex[0].y, listVertex[0].z); // V1
            gl.Vertex(listVertex[3].x, listVertex[3].y, listVertex[3].z); // V4

            gl.Vertex(listVertex[1].x, listVertex[1].y, listVertex[1].z); // V2
            gl.Vertex(listVertex[4].x, listVertex[4].y, listVertex[4].z); // V5

            gl.Vertex(listVertex[2].x, listVertex[2].y, listVertex[2].z); // V3
            gl.Vertex(listVertex[5].x, listVertex[5].y, listVertex[5].z); // V6

            gl.Vertex(listVertex[3].x, listVertex[3].y, listVertex[3].z); // V4
            gl.Vertex(listVertex[4].x, listVertex[4].y, listVertex[4].z); // V5

            gl.Vertex(listVertex[5].x, listVertex[5].y, listVertex[5].z); // V6
            gl.Vertex(listVertex[3].x, listVertex[3].y, listVertex[3].z); // V4

            gl.Vertex(listVertex[5].x, listVertex[5].y, listVertex[5].z); // V6
            gl.Vertex(listVertex[4].x, listVertex[4].y, listVertex[4].z); // V5

            gl.End();
        }

        ~Prism()
        {
        }
    }
}
