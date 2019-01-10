namespace Lab04
{
    partial class SharpGLFrom
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SharpGLFrom));
            this.openGLControl = new SharpGL.OpenGLControl();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.tbShapeSize1 = new System.Windows.Forms.TextBox();
            this.lboxObjectsList = new System.Windows.Forms.ListBox();
            this.tbShapeSize2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbScaleX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbScaleY = new System.Windows.Forms.TextBox();
            this.tbScaleZ = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPosX = new System.Windows.Forms.TextBox();
            this.tbPosY = new System.Windows.Forms.TextBox();
            this.tbPosZ = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tbRotX = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbRotY = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbRotZ = new System.Windows.Forms.TextBox();
            this.btnChooseColor = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lbCamX = new System.Windows.Forms.Label();
            this.lbCamPosX = new System.Windows.Forms.Label();
            this.lbCamPosY = new System.Windows.Forms.Label();
            this.lbCamPosZ = new System.Windows.Forms.Label();
            this.btnRotation = new System.Windows.Forms.Button();
            this.btnScale = new System.Windows.Forms.Button();
            this.btnPosition = new System.Windows.Forms.Button();
            this.btnSetHeight = new System.Windows.Forms.Button();
            this.btnSetLength = new System.Windows.Forms.Button();
            this.btnPyramid = new System.Windows.Forms.Button();
            this.btnPrism = new System.Windows.Forms.Button();
            this.btnCube = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.pbShowTexture = new System.Windows.Forms.PictureBox();
            this.tbTexturePath = new System.Windows.Forms.TextBox();
            this.btnOpenTextureFile = new System.Windows.Forms.Button();
            this.btnStickTexture = new System.Windows.Forms.Button();
            this.btnUnstickTexture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowTexture)).BeginInit();
            this.SuspendLayout();
            // 
            // openGLControl
            // 
            this.openGLControl.DrawFPS = false;
            this.openGLControl.Location = new System.Drawing.Point(220, 116);
            this.openGLControl.Name = "openGLControl";
            this.openGLControl.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl.Size = new System.Drawing.Size(790, 456);
            this.openGLControl.TabIndex = 0;
            this.openGLControl.OpenGLInitialized += new System.EventHandler(this.openGLControl_OpenGLInitialized);
            this.openGLControl.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl_OpenGLDraw);
            this.openGLControl.Resized += new System.EventHandler(this.openGLControl_Resized);
            // 
            // tbShapeSize1
            // 
            this.tbShapeSize1.Enabled = false;
            this.tbShapeSize1.Location = new System.Drawing.Point(56, 116);
            this.tbShapeSize1.Name = "tbShapeSize1";
            this.tbShapeSize1.Size = new System.Drawing.Size(117, 20);
            this.tbShapeSize1.TabIndex = 4;
            // 
            // lboxObjectsList
            // 
            this.lboxObjectsList.FormattingEnabled = true;
            this.lboxObjectsList.Location = new System.Drawing.Point(12, 192);
            this.lboxObjectsList.Name = "lboxObjectsList";
            this.lboxObjectsList.Size = new System.Drawing.Size(191, 134);
            this.lboxObjectsList.TabIndex = 19;
            this.lboxObjectsList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lboxObjectsList_MouseClick);
            // 
            // tbShapeSize2
            // 
            this.tbShapeSize2.Enabled = false;
            this.tbShapeSize2.Location = new System.Drawing.Point(56, 154);
            this.tbShapeSize2.Name = "tbShapeSize2";
            this.tbShapeSize2.Size = new System.Drawing.Size(117, 20);
            this.tbShapeSize2.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Scale";
            // 
            // tbScaleX
            // 
            this.tbScaleX.Enabled = false;
            this.tbScaleX.Location = new System.Drawing.Point(308, 12);
            this.tbScaleX.Name = "tbScaleX";
            this.tbScaleX.Size = new System.Drawing.Size(72, 20);
            this.tbScaleX.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(504, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Z";
            // 
            // tbScaleY
            // 
            this.tbScaleY.Enabled = false;
            this.tbScaleY.Location = new System.Drawing.Point(416, 12);
            this.tbScaleY.Name = "tbScaleY";
            this.tbScaleY.Size = new System.Drawing.Size(72, 20);
            this.tbScaleY.TabIndex = 29;
            // 
            // tbScaleZ
            // 
            this.tbScaleZ.Enabled = false;
            this.tbScaleZ.Location = new System.Drawing.Point(524, 12);
            this.tbScaleZ.Name = "tbScaleZ";
            this.tbScaleZ.Size = new System.Drawing.Size(72, 20);
            this.tbScaleZ.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(216, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 31;
            this.label3.Text = "Position";
            // 
            // tbPosX
            // 
            this.tbPosX.Enabled = false;
            this.tbPosX.Location = new System.Drawing.Point(308, 39);
            this.tbPosX.Name = "tbPosX";
            this.tbPosX.Size = new System.Drawing.Size(72, 20);
            this.tbPosX.TabIndex = 32;
            // 
            // tbPosY
            // 
            this.tbPosY.Enabled = false;
            this.tbPosY.Location = new System.Drawing.Point(416, 39);
            this.tbPosY.Name = "tbPosY";
            this.tbPosY.Size = new System.Drawing.Size(72, 20);
            this.tbPosY.TabIndex = 33;
            // 
            // tbPosZ
            // 
            this.tbPosZ.Enabled = false;
            this.tbPosZ.Location = new System.Drawing.Point(524, 39);
            this.tbPosZ.Name = "tbPosZ";
            this.tbPosZ.Size = new System.Drawing.Size(72, 20);
            this.tbPosZ.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(288, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(396, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(504, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Z";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(216, 68);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Rotation";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(288, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "X";
            // 
            // tbRotX
            // 
            this.tbRotX.Enabled = false;
            this.tbRotX.Location = new System.Drawing.Point(308, 65);
            this.tbRotX.Name = "tbRotX";
            this.tbRotX.Size = new System.Drawing.Size(72, 20);
            this.tbRotX.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(396, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Y";
            // 
            // tbRotY
            // 
            this.tbRotY.Enabled = false;
            this.tbRotY.Location = new System.Drawing.Point(416, 65);
            this.tbRotY.Name = "tbRotY";
            this.tbRotY.Size = new System.Drawing.Size(72, 20);
            this.tbRotY.TabIndex = 42;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(504, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "Z";
            // 
            // tbRotZ
            // 
            this.tbRotZ.Enabled = false;
            this.tbRotZ.Location = new System.Drawing.Point(524, 65);
            this.tbRotZ.Name = "tbRotZ";
            this.tbRotZ.Size = new System.Drawing.Size(72, 20);
            this.tbRotZ.TabIndex = 44;
            // 
            // btnChooseColor
            // 
            this.btnChooseColor.Location = new System.Drawing.Point(135, 12);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(68, 33);
            this.btnChooseColor.TabIndex = 21;
            this.btnChooseColor.Text = "Colors";
            this.btnChooseColor.UseVisualStyleBackColor = true;
            this.btnChooseColor.Click += new System.EventHandler(this.btnChooseColor_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 119);
            this.label13.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 52;
            this.label13.Text = "Length";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 157);
            this.label14.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 53;
            this.label14.Text = "Height";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.SystemColors.WindowText;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(907, 122);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 13);
            this.label16.TabIndex = 61;
            this.label16.Text = "X :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.SystemColors.WindowText;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Lime;
            this.label17.Location = new System.Drawing.Point(907, 148);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 13);
            this.label17.TabIndex = 62;
            this.label17.Text = "Y :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.SystemColors.WindowText;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Blue;
            this.label18.Location = new System.Drawing.Point(907, 173);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(23, 13);
            this.label18.TabIndex = 63;
            this.label18.Text = "Z :";
            // 
            // lbCamX
            // 
            this.lbCamX.AutoSize = true;
            this.lbCamX.BackColor = System.Drawing.SystemColors.WindowText;
            this.lbCamX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCamX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCamX.ForeColor = System.Drawing.Color.Red;
            this.lbCamX.Location = new System.Drawing.Point(494, 25);
            this.lbCamX.Name = "lbCamX";
            this.lbCamX.Size = new System.Drawing.Size(0, 13);
            this.lbCamX.TabIndex = 64;
            // 
            // lbCamPosX
            // 
            this.lbCamPosX.AutoSize = true;
            this.lbCamPosX.BackColor = System.Drawing.SystemColors.WindowText;
            this.lbCamPosX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCamPosX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCamPosX.ForeColor = System.Drawing.Color.Red;
            this.lbCamPosX.Location = new System.Drawing.Point(928, 122);
            this.lbCamPosX.Name = "lbCamPosX";
            this.lbCamPosX.Size = new System.Drawing.Size(39, 13);
            this.lbCamPosX.TabIndex = 65;
            this.lbCamPosX.Text = "0.000";
            this.lbCamPosX.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbCamPosY
            // 
            this.lbCamPosY.AutoSize = true;
            this.lbCamPosY.BackColor = System.Drawing.SystemColors.WindowText;
            this.lbCamPosY.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCamPosY.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCamPosY.ForeColor = System.Drawing.Color.Lime;
            this.lbCamPosY.Location = new System.Drawing.Point(928, 148);
            this.lbCamPosY.Name = "lbCamPosY";
            this.lbCamPosY.Size = new System.Drawing.Size(39, 13);
            this.lbCamPosY.TabIndex = 66;
            this.lbCamPosY.Text = "0.000";
            this.lbCamPosY.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbCamPosZ
            // 
            this.lbCamPosZ.AutoSize = true;
            this.lbCamPosZ.BackColor = System.Drawing.SystemColors.WindowText;
            this.lbCamPosZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCamPosZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCamPosZ.ForeColor = System.Drawing.Color.Blue;
            this.lbCamPosZ.Location = new System.Drawing.Point(928, 173);
            this.lbCamPosZ.Name = "lbCamPosZ";
            this.lbCamPosZ.Size = new System.Drawing.Size(39, 13);
            this.lbCamPosZ.TabIndex = 67;
            this.lbCamPosZ.Text = "0.000";
            this.lbCamPosZ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnRotation
            // 
            this.btnRotation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRotation.Image = ((System.Drawing.Image)(resources.GetObject("btnRotation.Image")));
            this.btnRotation.Location = new System.Drawing.Point(602, 65);
            this.btnRotation.Name = "btnRotation";
            this.btnRotation.Size = new System.Drawing.Size(25, 20);
            this.btnRotation.TabIndex = 57;
            this.btnRotation.UseVisualStyleBackColor = true;
            this.btnRotation.Click += new System.EventHandler(this.btnRotation_Click);
            // 
            // btnScale
            // 
            this.btnScale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScale.Image = ((System.Drawing.Image)(resources.GetObject("btnScale.Image")));
            this.btnScale.Location = new System.Drawing.Point(602, 12);
            this.btnScale.Name = "btnScale";
            this.btnScale.Size = new System.Drawing.Size(25, 20);
            this.btnScale.TabIndex = 56;
            this.btnScale.UseVisualStyleBackColor = true;
            this.btnScale.Click += new System.EventHandler(this.btnScale_Click);
            // 
            // btnPosition
            // 
            this.btnPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPosition.Image = ((System.Drawing.Image)(resources.GetObject("btnPosition.Image")));
            this.btnPosition.Location = new System.Drawing.Point(602, 39);
            this.btnPosition.Name = "btnPosition";
            this.btnPosition.Size = new System.Drawing.Size(25, 20);
            this.btnPosition.TabIndex = 55;
            this.btnPosition.UseVisualStyleBackColor = true;
            this.btnPosition.Click += new System.EventHandler(this.btnPosition_Click);
            // 
            // btnSetHeight
            // 
            this.btnSetHeight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetHeight.Image = ((System.Drawing.Image)(resources.GetObject("btnSetHeight.Image")));
            this.btnSetHeight.Location = new System.Drawing.Point(178, 154);
            this.btnSetHeight.Name = "btnSetHeight";
            this.btnSetHeight.Size = new System.Drawing.Size(25, 20);
            this.btnSetHeight.TabIndex = 50;
            this.btnSetHeight.UseVisualStyleBackColor = true;
            this.btnSetHeight.Click += new System.EventHandler(this.btnSetHeight_Click);
            // 
            // btnSetLength
            // 
            this.btnSetLength.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetLength.Image = ((System.Drawing.Image)(resources.GetObject("btnSetLength.Image")));
            this.btnSetLength.Location = new System.Drawing.Point(178, 116);
            this.btnSetLength.Name = "btnSetLength";
            this.btnSetLength.Size = new System.Drawing.Size(25, 20);
            this.btnSetLength.TabIndex = 46;
            this.btnSetLength.UseVisualStyleBackColor = true;
            this.btnSetLength.Click += new System.EventHandler(this.btnSetLength_Click);
            // 
            // btnPyramid
            // 
            this.btnPyramid.FlatAppearance.BorderSize = 0;
            this.btnPyramid.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPyramid.Image = ((System.Drawing.Image)(resources.GetObject("btnPyramid.Image")));
            this.btnPyramid.Location = new System.Drawing.Point(47, 12);
            this.btnPyramid.Name = "btnPyramid";
            this.btnPyramid.Size = new System.Drawing.Size(33, 33);
            this.btnPyramid.TabIndex = 18;
            this.btnPyramid.UseVisualStyleBackColor = true;
            this.btnPyramid.Click += new System.EventHandler(this.btnPyramid_Click);
            // 
            // btnPrism
            // 
            this.btnPrism.FlatAppearance.BorderSize = 0;
            this.btnPrism.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrism.Image = ((System.Drawing.Image)(resources.GetObject("btnPrism.Image")));
            this.btnPrism.Location = new System.Drawing.Point(86, 12);
            this.btnPrism.Name = "btnPrism";
            this.btnPrism.Size = new System.Drawing.Size(30, 33);
            this.btnPrism.TabIndex = 17;
            this.btnPrism.UseVisualStyleBackColor = true;
            this.btnPrism.Click += new System.EventHandler(this.btnPrism_Click);
            // 
            // btnCube
            // 
            this.btnCube.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnCube.FlatAppearance.BorderSize = 0;
            this.btnCube.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCube.Image = ((System.Drawing.Image)(resources.GetObject("btnCube.Image")));
            this.btnCube.Location = new System.Drawing.Point(12, 12);
            this.btnCube.Name = "btnCube";
            this.btnCube.Size = new System.Drawing.Size(29, 33);
            this.btnCube.TabIndex = 16;
            this.btnCube.UseVisualStyleBackColor = true;
            this.btnCube.Click += new System.EventHandler(this.btnCube_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 342);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 75;
            this.label15.Text = "Texture";
            // 
            // pbShowTexture
            // 
            this.pbShowTexture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbShowTexture.Location = new System.Drawing.Point(12, 414);
            this.pbShowTexture.Name = "pbShowTexture";
            this.pbShowTexture.Size = new System.Drawing.Size(191, 158);
            this.pbShowTexture.TabIndex = 74;
            this.pbShowTexture.TabStop = false;
            // 
            // tbTexturePath
            // 
            this.tbTexturePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTexturePath.Location = new System.Drawing.Point(12, 388);
            this.tbTexturePath.Name = "tbTexturePath";
            this.tbTexturePath.ReadOnly = true;
            this.tbTexturePath.Size = new System.Drawing.Size(191, 20);
            this.tbTexturePath.TabIndex = 73;
            // 
            // btnOpenTextureFile
            // 
            this.btnOpenTextureFile.Location = new System.Drawing.Point(11, 359);
            this.btnOpenTextureFile.Name = "btnOpenTextureFile";
            this.btnOpenTextureFile.Size = new System.Drawing.Size(44, 23);
            this.btnOpenTextureFile.TabIndex = 72;
            this.btnOpenTextureFile.Text = "Open";
            this.btnOpenTextureFile.UseVisualStyleBackColor = true;
            this.btnOpenTextureFile.Click += new System.EventHandler(this.btnOpenTextureFile_Click_1);
            // 
            // btnStickTexture
            // 
            this.btnStickTexture.Location = new System.Drawing.Point(93, 359);
            this.btnStickTexture.Name = "btnStickTexture";
            this.btnStickTexture.Size = new System.Drawing.Size(52, 23);
            this.btnStickTexture.TabIndex = 76;
            this.btnStickTexture.Text = "Stick";
            this.btnStickTexture.UseVisualStyleBackColor = true;
            this.btnStickTexture.Click += new System.EventHandler(this.btnStickTexture_Click);
            // 
            // btnUnstickTexture
            // 
            this.btnUnstickTexture.Location = new System.Drawing.Point(151, 359);
            this.btnUnstickTexture.Name = "btnUnstickTexture";
            this.btnUnstickTexture.Size = new System.Drawing.Size(52, 23);
            this.btnUnstickTexture.TabIndex = 77;
            this.btnUnstickTexture.Text = "Unstick";
            this.btnUnstickTexture.UseVisualStyleBackColor = true;
            this.btnUnstickTexture.Click += new System.EventHandler(this.btnUnstickTexture_Click);
            // 
            // SharpGLFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 584);
            this.Controls.Add(this.btnUnstickTexture);
            this.Controls.Add(this.btnStickTexture);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pbShowTexture);
            this.Controls.Add(this.tbTexturePath);
            this.Controls.Add(this.btnOpenTextureFile);
            this.Controls.Add(this.lbCamPosZ);
            this.Controls.Add(this.lbCamPosY);
            this.Controls.Add(this.lbCamPosX);
            this.Controls.Add(this.lbCamX);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.btnRotation);
            this.Controls.Add(this.btnScale);
            this.Controls.Add(this.btnPosition);
            this.Controls.Add(this.tbShapeSize1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnSetHeight);
            this.Controls.Add(this.btnSetLength);
            this.Controls.Add(this.tbRotZ);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbRotY);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbRotX);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPosZ);
            this.Controls.Add(this.tbPosY);
            this.Controls.Add(this.tbPosX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbScaleZ);
            this.Controls.Add(this.tbScaleY);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbScaleX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnChooseColor);
            this.Controls.Add(this.tbShapeSize2);
            this.Controls.Add(this.lboxObjectsList);
            this.Controls.Add(this.btnPyramid);
            this.Controls.Add(this.btnPrism);
            this.Controls.Add(this.btnCube);
            this.Controls.Add(this.openGLControl);
            this.Name = "SharpGLFrom";
            this.Text = "SharpGL";
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbShowTexture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SharpGL.OpenGLControl openGLControl;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox tbShapeSize1;
        private System.Windows.Forms.Button btnCube;
        private System.Windows.Forms.Button btnPrism;
        private System.Windows.Forms.Button btnPyramid;
        private System.Windows.Forms.ListBox lboxObjectsList;
        private System.Windows.Forms.TextBox tbShapeSize2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbScaleX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbScaleY;
        private System.Windows.Forms.TextBox tbScaleZ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPosX;
        private System.Windows.Forms.TextBox tbPosY;
        private System.Windows.Forms.TextBox tbPosZ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbRotX;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbRotY;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbRotZ;
        private System.Windows.Forms.Button btnChooseColor;
        private System.Windows.Forms.Button btnSetLength;
        private System.Windows.Forms.Button btnSetHeight;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnPosition;
        private System.Windows.Forms.Button btnScale;
        private System.Windows.Forms.Button btnRotation;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lbCamX;
        private System.Windows.Forms.Label lbCamPosX;
        private System.Windows.Forms.Label lbCamPosY;
        private System.Windows.Forms.Label lbCamPosZ;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pbShowTexture;
        private System.Windows.Forms.TextBox tbTexturePath;
        private System.Windows.Forms.Button btnOpenTextureFile;
        private System.Windows.Forms.Button btnStickTexture;
        private System.Windows.Forms.Button btnUnstickTexture;
    }
}

