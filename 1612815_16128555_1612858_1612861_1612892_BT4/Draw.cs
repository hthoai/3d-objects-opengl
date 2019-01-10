//Draw and Redraw everytime
using SharpGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    class Draw
    {
        //public static Stack<Object> stackObject = new Stack<Object>();
        public static List<Object> listObject = new List<Object>();
        public static Object chooseObject(OpenGLControl openGLControl, int _chooseIcon, Vertex center)
        {
            Object _chooseObject = null;

            /*Choose a shape */

            switch (_chooseIcon)
            {
                case 1://Cube
                    _chooseObject = new Cube();//màu nền, tâm, chiều dài cạnh, check đang chọn
                    break;
                case 2://Pyramid - Hình chóp đáy là hình vuông
                    _chooseObject = new Pyramid(); //màu nền, tâm, chiều dài cạnh, check đang chọn, đỉnh chóp
                    break;
                case 3://Prism - Hình lăng trụ đáy là tam giác đều 
                    _chooseObject = new Prism();//màu nền, tâm, chiều dài cạnh, check đang chọn
                    break;
                //xem lại chú thích
                default:
                    break;
            }
            if (_chooseObject != null) // nếu tạo được object
            {
                _chooseObject.name += Object._countObjects.ToString();
                listObject.Add(_chooseObject);
            }

            return _chooseObject;
        }

        /*
        draw object from stack 
        */
        public static void DrawShape(OpenGLControl openGLControl)
        {
            var gl = openGLControl.OpenGL;
            foreach (var x in listObject)
            {
                gl.PushMatrix();
                x.Draw(openGLControl);
                gl.PopMatrix();
            }
        }
    }
}
