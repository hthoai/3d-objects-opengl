using System;
using SharpGL;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using SharpGL.SceneGraph.Assets;

namespace Lab04
{
    abstract class Object
    {
        public List<Vertex> listVertex; // danh sách tất cả đỉnh của object
        //public Vertex _center; // tâm của hình mặc định (0,0,0)
        //public double _size; //độ dày
        public Color _color; // màu nền
        public double _length; // chiều dài cạnh
        public double _height;
        public bool _Solid;
        public string name = "Object ";
        public int type;
        public static int _countObjects = 0;

        public double angelX, angelY, angelZ;
        public double tX, tY, tZ;
        public double sX, sY, sZ;

        public bool isTexture;
        public Texture texture;

        //public double R; // khoảng cách từ tâm tới đỉnh

        public Object() { }
        //{
        //    listVertex = null;
        //    _center = new Vertex(0, 0, 0);
        //    _color = Color.White;
        //    _length = 1;
        //    _Solid = false;
        //}

        public virtual void Draw(OpenGLControl gl)
        {
            gl.OpenGL.Color(_color.R / 255.0, _color.G / 255.0, _color.B / 255.0);
        }

        public void Update()
        {
            //this is abstract to override this method
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int GetCount() { return _countObjects; }

        ~Object()
        {
        }


    }
}
