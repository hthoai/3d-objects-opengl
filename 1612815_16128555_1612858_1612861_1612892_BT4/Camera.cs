using SharpGL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab04
{
    public class Camera
    {
        public double _eyeX, _eyeY, _eyeZ;
        public double _lookX, _lookY, _lookZ;
        public double radius;
        public double theta;
        public double phi;

        public Camera()
        {
            _eyeX = 10;
            _eyeY = 5;
            _eyeZ = 10;
            _lookX = 0;
            _lookY = 0;
            _lookZ = 0;

            ComputeRadius();
            ComputeTheta();
            ComputePhi();
        }

        // Tính góc @theta hiện tại
        public void ComputeTheta()
        {
            // Trường hợp điểm nhìn không phải gốc tọa độ thì trừ @_lookX
            theta = Math.Atan((_eyeX - _lookX) / (_eyeZ - _lookZ));
        }

        // Tính góc @phi hiện tại
        public void ComputePhi()
        {
            // // Trường hợp điểm nhìn không phải gốc tọa độ thì trừ @_lookY
            phi = Math.Asin((_eyeY - _lookY) / radius);
        }

        // Tính bán kính của hình cầu khi thay đổi vị trí camera (khoảng cách từ eye đến look)
        public void ComputeRadius()
        {
            radius = Math.Sqrt(Math.Pow(_eyeX - _lookX, 2)
                     + Math.Pow(_eyeY - _lookY, 2)
                     + Math.Pow(_eyeZ - _lookZ, 2));
        }

        // Phóng to - di chuyển vị trí camera lại gần điểm nhìn
        public void ZoomIn()
        {
            _eyeX += -0.017f * _eyeX;
            _eyeY += -0.017f * _eyeY;
            _eyeZ += -0.017f * _eyeZ;

            // Khi di chuyển vị trí camera thì bán kính hình cầu sẽ thay đổi nên cần cập nhật lại
            ComputeRadius();
            ComputeTheta();
            ComputePhi();
        }

        // Thu nhỏ - di chuyển vị trí camera ra xa điểm nhìn
        public void ZoomOut()
        {
            _eyeX += 0.017f * _eyeX;
            _eyeY += 0.017f * _eyeY;
            _eyeZ += 0.017f * _eyeZ;

            // Khi di chuyển vị trí camera thì bán kính hình cầu sẽ thay đổi nên cần cập nhật lại
            ComputeRadius();
            ComputeTheta();
            ComputePhi();
        }

        // Di chuyển camera quay xung quanh điểm nhìn sang phải
        public void RotateRight()
        {
            theta += 0.017;
            _eyeX = _lookX + radius * Math.Cos(phi) * Math.Sin(theta);
            _eyeZ = _lookZ + radius * Math.Cos(phi) * Math.Cos(theta);
        }

        // Di chuyển camera quay xung quanh điểm nhìn sang trái 
        public void RotateLeft()
        {
            theta -= 0.017;
            _eyeX = _lookX + radius * Math.Cos(phi) * Math.Sin(theta);
            _eyeZ = _lookZ + radius * Math.Cos(phi) * Math.Cos(theta);
        }

        // Di chuyển camera quay xung quanh điểm nhìn lên trên
        public void RotateUp()
        {
            phi += 0.017;
            _eyeY = _lookY + radius * Math.Sin(phi);
            _eyeZ = _lookZ + radius * Math.Cos(phi) * Math.Cos(theta);
            _eyeX = _lookX + radius * Math.Cos(phi) * Math.Sin(theta);
        }

        // Di chuyển camera quay xung quanh điểm nhìn xuống dưới
        public void RotateDown()
        {
            phi -= 0.017;

            _eyeY = _lookY + radius * Math.Sin(phi);
            _eyeZ = _lookZ + radius * Math.Cos(phi) * Math.Cos(theta);
            _eyeX = _lookX + radius * Math.Cos(phi) * Math.Sin(theta);

        }
    }
}
