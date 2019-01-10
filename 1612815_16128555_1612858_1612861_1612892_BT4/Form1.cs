using SharpGL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpGL.SceneGraph.Assets;

namespace Lab04
{
    public partial class SharpGLFrom : Form
    {
        Camera cam = new Camera();
        OpenFileDialog openfd = new OpenFileDialog();
        static int chooseIcon = 0;
        //double length = 2.0;
        //double height = 5.0;
        //float size = 2.0f;
        //Color color = Color.White;
        //public bool solid = false;
        Background background = new Background();
        bool existObject = false;


        bool is_create = false; //Kiểm tra xem có tạo hình mới không
        int prev_index = -1;
        public SharpGLFrom()
        {
            InitializeComponent();
        }
        private void openGLControl_OpenGLInitialized(object sender, EventArgs e)
        {
            // Get the OpenGL object.
            OpenGL gl = openGLControl.OpenGL;

            // Set the clear color.
            gl.ClearColor(0, 0, 0, 0);
            // Set the projection matrix.
            gl.MatrixMode(OpenGL.GL_PROJECTION);
            // Load the identity.
            gl.LoadIdentity();
        }
        private void openGLControl_Resized(object sender, EventArgs e)
        {
            // Get the OpenGL object.
            OpenGL gl = openGLControl.OpenGL;
            // Set the ModelView matrix.
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
            // Create a perspective transformation.
            gl.LookAt(cam._eyeX, cam._eyeY, cam._eyeZ, cam._lookX, cam._lookY, cam._lookZ, 0, 1, 0);
            gl.MatrixMode(OpenGL.GL_PROJECTION);
            gl.Perspective(60, openGLControl.Width * 1f / openGLControl.Height, 1, 50);
            gl.Viewport(0, 0, openGLControl.Width, openGLControl.Height);
        }

        private void openGLControl_OpenGLDraw(object sender, RenderEventArgs args)
        {
            OpenGL gl = openGLControl.OpenGL;
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);

            // Set the projection matrix.
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
            // Load the identity.
            gl.LoadIdentity();
            // Create a perspective transformation.
            gl.LookAt(cam._eyeX, cam._eyeY, cam._eyeZ, cam._lookX, cam._lookY, cam._lookZ, 0, 1, 0);

            background.Draw(openGLControl, 100);

            //Nếu đang chọn hình để vẽ
            if (is_create)
            {
                if (prev_index != -1)
                {
                    Draw.listObject[prev_index]._Solid = false;
                    prev_index = -1;
                }
                //Vertex top = new Vertex(0, height / 2, 0);
                Vertex center = new Vertex(0, 0, 0);
                Draw.chooseObject(openGLControl, chooseIcon, center);
                lboxObjectsList.Items.Add(Draw.listObject[Draw.listObject.Count - 1]);
                lboxObjectsList.DisplayMember = "Name";
                is_create = false;
            }

            Lab04.Draw.DrawShape(openGLControl);

            gl.Flush();// Thực hiện lệnh vẽ ngay lập tức thay vì đợi sau 1 khoảng thời gian

            lbCamPosX.Text = Math.Round(cam._eyeX, 3).ToString();
            lbCamPosY.Text = Math.Round(cam._eyeY, 3).ToString();
            lbCamPosZ.Text = Math.Round(cam._eyeZ, 3).ToString();
        }

        //Xử lý sự kiện nhấn nút chọn màu
        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                if (prev_index != -1)
                    Draw.listObject[prev_index]._color = colorDialog1.Color;
            }
        }

        //Nhận các phím Z, X, Left, Right, Up, Down thao tác với camera
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            OpenGL gl = openGLControl.OpenGL;

            if (keyData == Keys.Z)
                cam.ZoomIn();
            if (keyData == Keys.X)
                cam.ZoomOut();
            if (keyData == Keys.Left)
                cam.RotateLeft();
            if (keyData == Keys.Right)
                cam.RotateRight();
            if (keyData == Keys.Up)
                cam.RotateUp();
            if (keyData == Keys.Down)
                cam.RotateDown();

            return base.ProcessCmdKey(ref msg, keyData);
        }

        // Nút chọn vẽ Cube
        private void btnCube_Click(object sender, EventArgs e)
        {
            is_create = true;
            chooseIcon = 1;
            Object._countObjects++;
        }

        // Nút chọn vễ Pyramid 
        private void btnPyramid_Click(object sender, EventArgs e)
        {
            is_create = true;
            chooseIcon = 2;
            Object._countObjects++;
        }

        // Nút chọn vễ Prism
        private void btnPrism_Click(object sender, EventArgs e)
        {
            is_create = true;
            chooseIcon = 3;
            Object._countObjects++;
        }

        // Xử lý sự kiện click vào List object
        private void lboxObjectsList_MouseClick(object sender, MouseEventArgs e)
        {
            // Get vị trí click chuột
            int index = this.lboxObjectsList.IndexFromPoint(e.Location);

            // Nếu chưa có đối tượng nào được tạo và chọn
            if (existObject == false && index != -1)
            {
                // Bậc textbox length của đối tượng được chọn
                tbShapeSize1.Enabled = true;

                // Bậc text box scale của đối tượng được chọn
                tbScaleX.Enabled = true;
                tbScaleY.Enabled = true;
                tbScaleZ.Enabled = true;

                // Bậc text box position của đối tượng được chọn
                tbPosX.Enabled = true;
                tbPosY.Enabled = true;
                tbPosZ.Enabled = true;

                // Bậc text box rotate của đối tượng được chọn
                tbRotX.Enabled = true;
                tbRotY.Enabled = true;
                tbRotZ.Enabled = true;

                existObject = true;
            }

            // Nếu click vào 1 vị trí khác trong List object
            if (prev_index != index && index >= 0)
            {
                // Và vị trí đó là tên 1 đối tượng
                if (prev_index != -1)
                    // Thì sửa lại đường viền màu nhạt cho đối tượng trước đó
                    Draw.listObject[prev_index]._Solid = false;
                // Rồi đổi đường viền đối tượng mới được chọn sang màu cam đậm
                Draw.listObject[index]._Solid = true;
                // Sau đó gán lại @prev_index cho những lần xử lý tiếp theo
                prev_index = index;

                // Hiển thị @length của đối tượng được chọn
                tbShapeSize1.Text = Draw.listObject[index]._length.ToString();

                // Hiển thị tỉ lệ hiện tại của hình được chọn vào hàng Scale
                tbScaleX.Text = Draw.listObject[index].sX.ToString();
                tbScaleY.Text = Draw.listObject[index].sY.ToString();
                tbScaleZ.Text = Draw.listObject[index].sZ.ToString();

                // Hiển thị vị trí hiện tại của hình được chọn vào hàng Position
                tbPosX.Text = Draw.listObject[index].tX.ToString();
                tbPosY.Text = Draw.listObject[index].tY.ToString();
                tbPosZ.Text = Draw.listObject[index].tZ.ToString();

                // Hiển thị góc xoay hiện tại của hình được chọn vào hàng Rotation
                tbRotX.Text = Draw.listObject[index].angelX.ToString();
                tbRotY.Text = Draw.listObject[index].angelY.ToString();
                tbRotZ.Text = Draw.listObject[index].angelZ.ToString();

                // Nếu là Cube, chỉ bậc thuộc tính @length
                if (Draw.listObject[index].type == 0)
                {
                    tbShapeSize2.Enabled = false;
                }
                // Ngược lại - là Pyramid/Prism - bậc @length và @height
                else
                {
                    tbShapeSize2.Enabled = true;
                    tbShapeSize2.Text = Draw.listObject[index]._height.ToString();
                }
            }
        }

        // Xử lý sự kiện người dùng set @length
        private void btnSetLength_Click(object sender, EventArgs e)
        {
            if (prev_index != -1)
            {
                double length;
                if (double.TryParse(tbShapeSize1.Text, out length))
                    Draw.listObject[prev_index]._length = length;
                else
                    MessageBox.Show("Invalid value :-");
            }
        }

        // Xử lý sự kiện người dùng set @height
        private void btnSetHeight_Click(object sender, EventArgs e)
        {
            if (prev_index != -1)
            {
                double height;
                if (double.TryParse(tbShapeSize2.Text, out height))
                    Draw.listObject[prev_index]._height = height;
                else
                    MessageBox.Show("Invalid value :-");
            }
        }

        // Xử lý sự kiện người dùng thay đổi vị trí đối tượng
        private void btnPosition_Click(object sender, EventArgs e)
        {
            if (existObject == true)
            {
                if (double.TryParse(tbPosX.Text, out double tX) &&
                double.TryParse(tbPosY.Text, out double tY) &&
                double.TryParse(tbPosZ.Text, out double tZ))
                {
                    Draw.listObject[prev_index].tX = tX;
                    Draw.listObject[prev_index].tY = tY;
                    Draw.listObject[prev_index].tZ = tZ;
                }
                else
                    MessageBox.Show("Invalid value :-");

            }
        }

        // Xử lý sự kiện người dùng thay đổi tỉ lệ theo các trục
        private void btnScale_Click(object sender, EventArgs e)
        {
            if (existObject == true)
            {
                if (double.TryParse(tbScaleX.Text, out double sX) &&
                    double.TryParse(tbScaleY.Text, out double sY) &&
                    double.TryParse(tbScaleZ.Text, out double sZ))
                {
                    Draw.listObject[prev_index].sX = sX;
                    Draw.listObject[prev_index].sY = sY;
                    Draw.listObject[prev_index].sZ = sZ;
                }
                else
                    MessageBox.Show("Invalid value :-");
            }
        }

        // Xử lý sự kiện người dùng xoay đối tượng
        private void btnRotation_Click(object sender, EventArgs e)
        {
            if (existObject == true)
            {
                if (double.TryParse(tbRotX.Text, out double angelX) &&
                double.TryParse(tbRotY.Text, out double angelY) &&
                double.TryParse(tbRotZ.Text, out double angelZ))
                {
                    Draw.listObject[prev_index].angelX = angelX;
                    Draw.listObject[prev_index].angelY = angelY;
                    Draw.listObject[prev_index].angelZ = angelZ;
                }
                else
                    MessageBox.Show("Invalid value :-");
            }
        }

        // Dán Texture theo đường dẫn đã chọn
        private void btnStickTexture_Click(object sender, EventArgs e)
        {
            if (prev_index != -1)
            {
                Draw.listObject[prev_index].isTexture = true;
                Texture texture = new Texture();
                texture.Create(openGLControl.OpenGL, tbTexturePath.Text);
                Draw.listObject[prev_index].texture = texture;
            }
            else
                MessageBox.Show("Select texture source first ^ _ ^ ");
        }

        // Bỏ dán texture 
        private void btnUnstickTexture_Click(object sender, EventArgs e)
        {
            if (prev_index != -1)
            {
                Draw.listObject[prev_index].isTexture = false;
            }
            else
                MessageBox.Show("Select texture source first ^_^ ");
        }

        // Chọn hình để dán texture
        private void btnOpenTextureFile_Click_1(object sender, EventArgs e)
        {
            if (prev_index != -1)
            {
                if (openfd.ShowDialog() == DialogResult.OK)
                {
                    tbTexturePath.Text = openfd.FileName.ToString();
                    pbShowTexture.BackgroundImage = Image.FromFile(tbTexturePath.Text);
                    Texture texture = new Texture();
                    texture.Create(openGLControl.OpenGL, tbTexturePath.Text);
                    Draw.listObject[prev_index].texture = texture;
                }
            }
            else
                MessageBox.Show("Select texture source first ^_^");
        }
    }
}
