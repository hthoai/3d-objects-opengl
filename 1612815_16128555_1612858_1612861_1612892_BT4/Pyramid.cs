using SharpGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpGL.SceneGraph.Assets;

namespace Lab04
{
    class Pyramid : Object
    {
        public Vertex _center;
        public Pyramid() //độ dày, màu nền, tâm object, chiều dài cạnh
        {
            _center = new Vertex(0, 0, 0); //tâm (mặc định (0,0,0))
            _length = 2.0f; //độ dài cạnh
            _height = 5.0f;
            _color = Color.White; //màu nền mặt phẳng
            _Solid = false; //check xem có đang thao tác trên hình này không
            type = 1;
            isTexture = false;
            texture = new Texture();

            listVertex = new List<Vertex> { new Vertex(), new Vertex(), new Vertex(), new Vertex(), new Vertex(), new Vertex(), new Vertex(), new Vertex() };
            angelX = angelY = angelZ = 0;
            tX = tY = tZ = 0;
            sX = sY = sZ = 1;
        }
        private void Save()
        {
            // tam cua hinh se cach deu cac dinh cua hinh
            // diem Bot_Point co gia tri tai toa do x la 2 diem (_center.x + _length / 2), 2 diem (_center.x - _length / 2)
            // diem Bot_Point co gia tri tai toa do z la 2 diem (_center.z + _length / 2), 2 diem (_center.z - _length / 2)
            // Tinh toa do y cua diem Bot_Point, dua vao khoang cach giua cac diem den tam la bang nhau
            // (_center.x - Bot_Point.x)^2 + (_center.y - Bot_Point.y)^2 + (_center.z - Bot_Point.z)^2
            //                 = (_center.x - _top.x)^2 + (_center.y - _top.y)^2 + (_center.z - _top.z)^2
            // => |_center.x - Bot_Point.x| = Sqrt(...)
            //Dat bien pos_y de xet
            // bien distance la binh phuong khoang cach tu tam toi cac dinh
            //double distance = _height / 2.0f;
            //double k = Math.Sqrt(distance - 2 * Math.Pow(_length / 2, 2));

            Vertex V1, V2, V3, V4, V5; // 5 dinh cua hinh
            listVertex = new List<Vertex>();
            double d = (2 * _height * _height - _length * _length) / (4 * _height);

            //dinh chop
            V1 = new Vertex(_center.x, _center.y + _height - d, _center.z);
            // 4 dinh duoi mat day
            V2 = new Vertex(_center.x + _length / 2, _center.y - d, _center.z + _length / 2);
            V3 = new Vertex(_center.x + _length / 2, _center.y - d, _center.z - _length / 2);
            V4 = new Vertex(_center.x - _length / 2, _center.y - d, _center.z - _length / 2);
            V5 = new Vertex(_center.x - _length / 2, _center.y - d, _center.z + _length / 2);
            //luu lai cac diem
            listVertex.Add(V1);
            listVertex.Add(V2);
            listVertex.Add(V3);
            listVertex.Add(V4);
            listVertex.Add(V5);
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
            //Vẽ khối hoặc vẽ và dán texture
            if (isTexture)
                DrawTexture(gl);
            else
                DrawRaw(gl);
            VienKhung(gl);
            gl.PopMatrix();
            gl.Flush();
        }

        private void DrawRaw(OpenGL gl)
        {
            gl.Begin(OpenGL.GL_QUADS);
            //Ve mat day
            gl.Vertex(listVertex[1].x, listVertex[1].y, listVertex[1].z); // V2
            gl.Vertex(listVertex[2].x, listVertex[2].y, listVertex[2].z); // V3
            gl.Vertex(listVertex[3].x, listVertex[3].y, listVertex[3].z); // V4
            gl.Vertex(listVertex[4].x, listVertex[4].y, listVertex[4].z); // V5

            gl.End();
            //Ve mat ben la 4 tam giac
            gl.Begin(OpenGL.GL_TRIANGLES);

            gl.Vertex(listVertex[0].x, listVertex[0].y, listVertex[0].z); // V1
            gl.Vertex(listVertex[1].x, listVertex[1].y, listVertex[1].z); // V2
            gl.Vertex(listVertex[2].x, listVertex[2].y, listVertex[2].z); // V3

            gl.Vertex(listVertex[0].x, listVertex[0].y, listVertex[0].z); // V1
            gl.Vertex(listVertex[2].x, listVertex[2].y, listVertex[2].z); // V3
            gl.Vertex(listVertex[3].x, listVertex[3].y, listVertex[3].z); // V4

            gl.Vertex(listVertex[0].x, listVertex[0].y, listVertex[0].z); // V1
            gl.Vertex(listVertex[3].x, listVertex[3].y, listVertex[3].z); // V4
            gl.Vertex(listVertex[4].x, listVertex[4].y, listVertex[4].z); // V5

            gl.Vertex(listVertex[0].x, listVertex[0].y, listVertex[0].z); // V1
            gl.Vertex(listVertex[4].x, listVertex[4].y, listVertex[4].z); // V5
            gl.Vertex(listVertex[1].x, listVertex[1].y, listVertex[1].z); // V2

            gl.End();
        }

        private void DrawTexture(OpenGL gl)
        {
            gl.Enable(OpenGL.GL_TEXTURE_2D);
            //Bind the texture.
            texture.Bind(gl);
            gl.Color(1f, 1f, 1f, 0);
            gl.Begin(OpenGL.GL_QUADS);
            //Ve mat day
            gl.TexCoord(0.0f, 0.0f); gl.Vertex(listVertex[1].x, listVertex[1].y, listVertex[1].z); // V2
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(listVertex[2].x, listVertex[2].y, listVertex[2].z); // V3
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(listVertex[3].x, listVertex[3].y, listVertex[3].z); // V4
            gl.TexCoord(1.0f, 0.0f); gl.Vertex(listVertex[4].x, listVertex[4].y, listVertex[4].z); // V5

            //gl.End();
            //Ve mat ben la 4 tam giac
            //gl.Begin(OpenGL.GL_QUADS);
            //front face
            gl.TexCoord(0.5f, 0.0f); gl.Vertex(listVertex[0].x, listVertex[0].y, listVertex[0].z); // V1
            gl.TexCoord(0.5f, 0.0f); gl.Vertex(listVertex[0].x, listVertex[0].y, listVertex[0].z); // V1
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(listVertex[1].x, listVertex[1].y, listVertex[1].z); // V2
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(listVertex[2].x, listVertex[2].y, listVertex[2].z); // V3

            // right face
            gl.TexCoord(0.5f, 0.0f); gl.Vertex(listVertex[0].x, listVertex[0].y, listVertex[0].z); // V1
            gl.TexCoord(0.5f, 0.0f); gl.Vertex(listVertex[0].x, listVertex[0].y, listVertex[0].z); // V1
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(listVertex[2].x, listVertex[2].y, listVertex[2].z); // V3
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(listVertex[3].x, listVertex[3].y, listVertex[3].z); // V4
            //behind face
            gl.TexCoord(0.5f, 0.0f); gl.Vertex(listVertex[0].x, listVertex[0].y, listVertex[0].z); // V1
            gl.TexCoord(0.5f, 0.0f); gl.Vertex(listVertex[0].x, listVertex[0].y, listVertex[0].z); // V1
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(listVertex[3].x, listVertex[3].y, listVertex[3].z); // V4
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(listVertex[4].x, listVertex[4].y, listVertex[4].z); // V5
            //left face
            gl.TexCoord(0.5f, 0.0f); gl.Vertex(listVertex[0].x, listVertex[0].y, listVertex[0].z); // V1
            gl.TexCoord(0.5f, 0.0f); gl.Vertex(listVertex[0].x, listVertex[0].y, listVertex[0].z); // V1
            gl.TexCoord(0.0f, 1.0f); gl.Vertex(listVertex[4].x, listVertex[4].y, listVertex[4].z); // V5
            gl.TexCoord(1.0f, 1.0f); gl.Vertex(listVertex[1].x, listVertex[1].y, listVertex[1].z); // V2

            gl.End();
            gl.Disable(OpenGL.GL_TEXTURE_2D);
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

            gl.Vertex(listVertex[0].x, listVertex[0].y, listVertex[0].z); // V1
            gl.Vertex(listVertex[2].x, listVertex[2].y, listVertex[2].z); // V3

            gl.Vertex(listVertex[0].x, listVertex[0].y, listVertex[0].z); // V1
            gl.Vertex(listVertex[3].x, listVertex[3].y, listVertex[3].z); // V4

            gl.Vertex(listVertex[0].x, listVertex[0].y, listVertex[0].z); // V1
            gl.Vertex(listVertex[4].x, listVertex[4].y, listVertex[4].z); // V5

            gl.Vertex(listVertex[1].x, listVertex[1].y, listVertex[1].z); // V2
            gl.Vertex(listVertex[2].x, listVertex[2].y, listVertex[2].z); // V3

            gl.Vertex(listVertex[2].x, listVertex[2].y, listVertex[2].z); // V3
            gl.Vertex(listVertex[3].x, listVertex[3].y, listVertex[3].z); // V4

            gl.Vertex(listVertex[3].x, listVertex[3].y, listVertex[3].z); // V4
            gl.Vertex(listVertex[4].x, listVertex[4].y, listVertex[4].z); // V5

            gl.Vertex(listVertex[4].x, listVertex[4].y, listVertex[4].z); // V5
            gl.Vertex(listVertex[1].x, listVertex[1].y, listVertex[1].z); // V2

            gl.End();
        }
    }
}
