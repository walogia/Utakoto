using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using PEPlugin;
using PEPlugin.Pmx;
using PEPlugin.View;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace embed
{
    partial class Class1
    {
    	private IPERunArgs args;
		private IPEPluginHost host;
		private IPEConnector connect;
		private IPXPmx PMX;
		public IPXPmxViewConnector PMXView;
		public IPEPMDViewConnector PMDView;
		public IPEBuilder builder;
		public IPEShortBuilder bd;
		
		//**************************************添加控件
        private TabPage tabPage;
        private Button button1;
		private GroupBox groupBox1;
		private Button button2;
		private GroupBox groupBox2;
		private Button button3;
		private GroupBox groupBox3;
		private Button button4;
		private GroupBox groupBox4;
		private Button button5;
		private Button button6;
		private Button button7;
		private LinkLabel linkLabel1;
		private GroupBox groupBox5;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label7;
		private Label label8;
		private Label label9;
		private Label label10;
		private Label label11;
		private Label label12;
		private Label label13;
		private Label label14;
		private Label label15;
		private Label label16;
		private Label label17;
		private TextBox textBox1;
		private TextBox textBox2;
		private TextBox textBox3;
		private TextBox textBox4;
		private TextBox textBox5;
		private TextBox textBox6;
	//********************添加结束**************
	     public void SetHostArgs(IPERunArgs args)
        {
            this.args = args;
        }
	        
        /// <summary>
        /// 寻找tabcontrol
        /// </summary>
        /// <param name="form"></param>
        /// <returns></returns>
        private TabControl searchTabControl(Form form)
        {
            foreach (System.Windows.Forms.Control control in form.Controls)
            {
                if (control is TabControl)
                {

                    return (TabControl)control;

                }
            }
            return null;
        }

        private void addTabPage(Form form)
        {
            TabControl tabControl = searchTabControl(form);
            Console.WriteLine("control");

            // 
            // 创建新button1
            // 
            this.button1=new Button();
			this.button1.Location = new System.Drawing.Point(115, 97);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(63, 31);
			this.button1.Text = "获取";
			this.button1.UseVisualStyleBackColor = true;
      		this.button1.Click += Button1Click;

            // 
            // 创建新groupBox1——顶点
            // 
            groupBox1=new GroupBox();
            groupBox1.Location = new System.Drawing.Point(6, 6);
			groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(177, 130);
			this.groupBox1.Text = "顶点";
			
			// 
            // 创建新button2
            // 
            this.button2=new Button();
			this.button2.Location = new System.Drawing.Point(300, 97);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(63, 31);
			this.button2.Text = "获取";
			this.button2.UseVisualStyleBackColor = true;
      		this.button2.Click += Button2Click;

            // 
            // 创建新groupBox2——骨骼
            // 
            groupBox2=new GroupBox();
            groupBox2.Location = new System.Drawing.Point(189, 6);
			groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(177, 130);
			this.groupBox2.Text = "骨骼";
			// 
            // 创建新button3
            // 
			this.button3=new Button();
			this.button3.Location = new System.Drawing.Point(555, 97);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(63, 31);
			this.button3.Text = "获取";
			this.button3.UseVisualStyleBackColor = true;
      		this.button3.Click += Button3Click;

            // 
            // 创建新groupBox3——刚体
            // 
            groupBox3=new GroupBox();
            groupBox3.Location = new System.Drawing.Point(372, 6);
			groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(250, 132);
			this.groupBox3.Text = "刚体";
			
			// 
			// button4
			// 
			this.button4=new Button();
			this.button4.Location = new System.Drawing.Point(300, 270);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(63, 31);
			this.button4.TabIndex = 0;
			this.button4.Text = "获取";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += Button4Click;
			// 
			// groupBox4——Joint
			// 
			groupBox4=new GroupBox();
			this.groupBox4.Controls.Add(this.button4);
			this.groupBox4.Location = new System.Drawing.Point(6, 142);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(360, 165);
			this.groupBox4.TabIndex = 15;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Joint";
			// 
			// groupBox5
			// 
			groupBox5=new GroupBox();
			this.groupBox5.Controls.Add(this.linkLabel1);
			this.groupBox5.Controls.Add(this.button7);
			this.groupBox5.Controls.Add(this.button4);
			this.groupBox5.Controls.Add(this.button6);
			this.groupBox5.Location = new System.Drawing.Point(372, 145);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(250, 158);
			this.groupBox5.TabIndex = 5;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "网址";
			// 
			// button5
			// 
			button5=new Button();
			this.button5.Location = new System.Drawing.Point(432, 170);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(137, 31);
			this.button5.TabIndex = 0;
			this.button5.Text = "とある工房";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += Button5Click;
			// 
			// button6
			// 
			button6=new Button();
			this.button6.Location = new System.Drawing.Point(432, 205);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(137, 31);
			this.button6.TabIndex = 0;
			this.button6.Text = "MikuMikuWiki";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += Button6Click;
			// 
			// button7
			// 
			button7=new Button();
			this.button7.Location = new System.Drawing.Point(432, 240);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(137, 31);
			this.button7.TabIndex = 2;
			this.button7.Text = "MikuMikuDance吧";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += Button7Click;
			// 
			// linkLabel1
			// 
			linkLabel1=new LinkLabel();
			this.linkLabel1.Location = new System.Drawing.Point(580, 281);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(41, 22);
			this.linkLabel1.TabIndex = 3;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "打赏";
			this.linkLabel1.LinkClicked +=LinkLabel1LinkClicked;
			//+++++++++++++++++++++++++
			// 
			// label1
			// 
			label1=new Label();
			this.label1.BackColor = System.Drawing.SystemColors.Control;
			this.label1.Location = new System.Drawing.Point(195, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(165, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "骨骼名:0";
			this.label1.MouseDown += Label1MouseDown;
			// 
			// label2
			// 
			label2=new Label();
			this.label2.BackColor = System.Drawing.SystemColors.Control;
			this.label2.Location = new System.Drawing.Point(195, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(165, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "位置:0,0,0";
			this.label2.Click += Label2Click;
			// 
			// label3
			// 
			label3=new Label();
			this.label3.BackColor = System.Drawing.SystemColors.Control;
			this.label3.Location = new System.Drawing.Point(376, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(238, 23);
			this.label3.TabIndex = 3;
			this.label3.Text = "序号:刚体名|序号:关联骨|组";
			this.label3.MouseDown += Label3MouseDown;
			// 
			// label4
			// 
			label4=new Label();
			this.label4.BackColor = System.Drawing.SystemColors.Control;
			this.label4.Location = new System.Drawing.Point(465, 50);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(151, 23);
			this.label4.TabIndex = 4;
			this.label4.Text = "移动/旋转";
			this.label4.MouseDown += Label4MouseDown;
			// 
			// textBox1
			// 
			textBox1=new TextBox();
			this.textBox1.Location = new System.Drawing.Point(401, 50);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(58, 26);
			this.textBox1.TabIndex = 5;
			// 
			// textBox2
			// 
			textBox2=new TextBox();
			this.textBox2.Location = new System.Drawing.Point(401, 78);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(58, 26);
			this.textBox2.TabIndex = 7;
			// 
			// textBox3
			// 
			textBox3=new TextBox();
			this.textBox3.Location = new System.Drawing.Point(401, 108);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(58, 26);
			this.textBox3.TabIndex = 8;
			// 
			// textBox4
			// 
			textBox4=new TextBox();
			this.textBox4.Location = new System.Drawing.Point(489, 78);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(58, 26);
			this.textBox4.TabIndex = 9;
			// 
			// textBox5
			// 
			textBox5=new TextBox();
			this.textBox5.Location = new System.Drawing.Point(489, 108);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(58, 26);
			this.textBox5.TabIndex = 10;
			// 
			// label5
			// 
			label5=new Label();
			this.label5.Location = new System.Drawing.Point(378, 54);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(20, 20);
			this.label5.TabIndex = 6;
			this.label5.Text = "质量";
			this.label5.Click += Label5Click;
			// 
			// label6
			// 
			label6=new Label();
			this.label6.Location = new System.Drawing.Point(378, 81);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(20, 20);
			this.label6.TabIndex = 11;
			this.label6.Text = "移动衰减";
			this.label6.Click += Label6Click;
			// 
			// label7
			// 
			label7=new Label();
			this.label7.Location = new System.Drawing.Point(378, 110);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(20, 20);
			this.label7.TabIndex = 12;
			this.label7.Text = "旋转衰减";
			this.label7.Click += Label7Click;
			// 
			// label8
			// 
			label8=new Label();
			this.label8.Location = new System.Drawing.Point(465, 81);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(20, 20);
			this.label8.TabIndex = 13;
			this.label8.Text = "反弹力";
			this.label8.Click += Label8Click;
			// 
			// label9
			// 
			label9=new Label();
			this.label9.Location = new System.Drawing.Point(465, 110);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(20, 20);
			this.label9.TabIndex = 14;
			this.label9.Text = "摩擦力";
			this.label9.Click += Label9Click;
			// 
			// textBox6
			// 
			textBox6=new TextBox();
			this.textBox6.Location = new System.Drawing.Point(10, 22);
			this.textBox6.Multiline = true;
			this.textBox6.Name = "textBox6";
			this.textBox6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.textBox6.Size = new System.Drawing.Size(165, 70);
			this.textBox6.TabIndex = 9;
			// 
			// label10
			// 
			label10=new Label();
			this.label10.BackColor = System.Drawing.SystemColors.Control;
			this.label10.Location = new System.Drawing.Point(10, 170);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(348, 23);
			this.label10.TabIndex = 4;
			this.label10.Text = "Joint名:序号|序号:刚体A--序号:刚体B";
			
			// 
			// label11
			// 
			label11=new Label();
			this.label11.BackColor = System.Drawing.SystemColors.Control;
			this.label11.Location = new System.Drawing.Point(10, 195);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(171, 23);
			this.label11.TabIndex = 5;
			this.label11.Text = "位置:";
			this.label11.Click += Label11Click;
			// 
			// label12
			// 
			label12=new Label();
			this.label12.BackColor = System.Drawing.SystemColors.Control;
			this.label12.Location = new System.Drawing.Point(185, 195);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(171, 23);
			this.label12.TabIndex = 6;
			this.label12.Text = "旋转:";
			this.label12.Click += Label12Click;
			// 
			// label13
			// 
			label13=new Label();
			this.label13.BackColor = System.Drawing.SystemColors.Control;
			this.label13.Location = new System.Drawing.Point(10, 220);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(110, 25);
			this.label13.TabIndex = 7;
			this.label13.Text = "限制X:";
			this.label13.MouseDown += Label13MouseDown;
			// 
			// label14
			// 
			label14=new Label();
			this.label14.BackColor = System.Drawing.SystemColors.Control;
			this.label14.Location = new System.Drawing.Point(130, 220);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(110, 25);
			this.label14.TabIndex = 8;
			this.label14.Text = "限制Y:";
			this.label14.MouseDown += Label14MouseDown;
			// 
			// label15
			// 
			label15=new Label();
			this.label15.BackColor = System.Drawing.SystemColors.Control;
			this.label15.Location = new System.Drawing.Point(250, 220);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(110, 25);
			this.label15.TabIndex = 9;
			this.label15.Text = "限制Z:";
			this.label15.MouseDown += Label15MouseDown;
			// 
			// label16
			// 
			label16=new Label();
			this.label16.BackColor = System.Drawing.SystemColors.Control;
			this.label16.Location = new System.Drawing.Point(10, 248);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(230, 23);
			this.label16.TabIndex = 10;
			this.label16.Text = "弹簧移动:";
			this.label16.Click += Label16Click;
			// 
			// label17
			// 
			label17=new Label();
			this.label17.BackColor = System.Drawing.SystemColors.Control;
			this.label17.Location = new System.Drawing.Point(10, 270);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(230, 23);
			this.label17.TabIndex = 11;
			this.label17.Text = "弹簧旋转:";
			this.label17.Click += Label17Click;
			//******************************************************************
            //
            //创建新tabpage
            //
            tabPage = new TabPage();
              tabPage.Controls.Add(textBox6);
		    tabPage.Controls.Add(button1);//添加控件
            tabPage.Controls.Add(groupBox1);
             tabPage.Controls.Add(label1);
             tabPage.Controls.Add(label2);
            tabPage.Controls.Add(button2);//添加控件
            tabPage.Controls.Add(groupBox2);
             tabPage.Controls.Add(label3);
             tabPage.Controls.Add(label4);
             tabPage.Controls.Add(label5);
             tabPage.Controls.Add(label6);
             tabPage.Controls.Add(label7);
             tabPage.Controls.Add(label8);
             tabPage.Controls.Add(label9);
             tabPage.Controls.Add(textBox1);
             tabPage.Controls.Add(textBox2);
             tabPage.Controls.Add(textBox3);
             tabPage.Controls.Add(textBox4);
             tabPage.Controls.Add(textBox5);
            tabPage.Controls.Add(button3);//添加控件
			tabPage.Controls.Add(groupBox3);
			 tabPage.Controls.Add(label10);             
			 tabPage.Controls.Add(label11);
             tabPage.Controls.Add(label12);             
			 tabPage.Controls.Add(label13);
             tabPage.Controls.Add(label14);
             tabPage.Controls.Add(label15);
             tabPage.Controls.Add(label16);
             tabPage.Controls.Add(label17);
			tabPage.Controls.Add(button4);//添加控件
			tabPage.Controls.Add(groupBox4);

			tabPage.Controls.Add(button5);//添加控件
			tabPage.Controls.Add(button6);
			tabPage.Controls.Add(button7);
			tabPage.Controls.Add(linkLabel1);
			tabPage.Controls.Add(groupBox5);
            //-----------------------分界线--------------------//
            tabPage.Location = new System.Drawing.Point(4, 22);
            tabPage.Name = "tabPage2";
            tabPage.Padding = new System.Windows.Forms.Padding(3);
            tabPage.Size = new System.Drawing.Size(369, 227);
            tabPage.TabIndex = 1;
            tabPage.Text = "呗言";
            //tabPage.UseVisualStyleBackColor = true;
           	tabPage.BackColor = System.Drawing.SystemColors.Control;
         //   tabPage.MouseDoubleClick += tabPage_MouseDoubleClick;


            tabControl.Controls.Add(tabPage);
        }
//***************************************
		void Button1Click(object sender, EventArgs e)
		{
			 this.InitializeValue();
			 
			 List<IPXVertex> list=GetSelectedVertexList();
//			 string k="";
//			k+=	list[0].Weight1+"\r\n";
//			k+=	list[0].Weight2+"\r\n";
//			k+=	list[0].Weight3+"\r\n";
//			k+=	list[0].Weight4+"\r\n";
//			//list[0].SDEF=true;
			 if(list.Count>0)
			 	groupBox1.Text="顶点"+"-"+list.Count.ToString();
			string k="";
			foreach (IPXVertex v in list)  
			  {
				k+=GetVertexIndex(v).ToString()+"\r\n";
			  }
			textBox6.Text=k;

			this.Update();
		}

		void Button2Click(object sender, EventArgs e)
		{
			this.InitializeValue();
			
			List<IPXBone> list=GetSelectdeBoneList();
			//index
			int index=GetBoneIndex(list[0].Name);
			string name=list[0].Name;
			string pos=(list[0].Position.X).ToString()+","+(list[0].Position.Y).ToString()+","+(list[0].Position.Z).ToString();//0,5,0

			
			label1.Text=name+":"+index.ToString();
			label2.Text="位置:"+pos;
		
			
			this.Update();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			this.InitializeValue();
			
			List<IPXBody> list=GetSelectedBodyList();
			int index=GetBodyIndex(list[0].Name);
			//刚体名
			string name=list[0].Name;
			//关联骨
			string bonename=list[0].Bone.Name;
			int bi=GetBoneIndex(bonename);
			//组
			int group=list[0].Group;
			//位置
			string pos=(list[0].Position.X).ToString()+","+(list[0].Position.Y).ToString()+","+(list[0].Position.Z).ToString();//0,5,0
			//旋转
			string rot=(list[0].Rotation.X).ToString()+","+(list[0].Rotation.Y).ToString()+","+(list[0].Rotation.Z).ToString();//0,5,0
			//摩擦力
			string friction=(list[0].Friction).ToString();
			//质量
			string mass=(list[0].Mass).ToString();
			//反弹力
			string restitution=(list[0].Restitution).ToString();
			//移动衰减
			string pd=(list[0].PositionDamping).ToString();
			//旋转衰减
			string rd=(list[0].RotationDamping).ToString();

			textBox1.Text=mass;
			textBox2.Text=pd;
			textBox3.Text=rd;
			textBox4.Text=restitution;
			textBox5.Text=friction;
			label3.Text=index.ToString()+":"+name+"|"+bi.ToString()+":"+bonename+"|"+group;
			label4.Text=pos+":"+rot;
			
			
			
			this.Update();
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			this.InitializeValue();
			
			List<IPXJoint> list=GetSelectedJointList();
			//index
			int index=GetJointIndex(list[0].Name);
			//Joint名
			string name=list[0].Name;
			//刚体A-B
			string BodyA=list[0].BodyA.Name;
			string Ai=(GetBodyIndex(BodyA)).ToString();
			string BodyB=list[0].BodyB.Name;
			string Bi=(GetBodyIndex(BodyB)).ToString();
			//位置
			string pos=(list[0].Position.X).ToString()+","+(list[0].Position.Y).ToString()+","+(list[0].Position.Z).ToString();//0,5,0
			//旋转
			string rot=(list[0].Rotation.X).ToString()+","+(list[0].Rotation.Y).ToString()+","+(list[0].Rotation.Z).ToString();//0,5,0
			//移动限制
			string Limit_Move_X=(list[0].Limit_MoveLow.X).ToString()+","+(list[0].Limit_MoveHigh.X).ToString();
			string Limit_Move_Y=(list[0].Limit_MoveLow.Y).ToString()+","+(list[0].Limit_MoveHigh.Y).ToString();
			string Limit_Move_Z=(list[0].Limit_MoveLow.Z).ToString()+","+(list[0].Limit_MoveHigh.Z).ToString();
			//旋转限制
			string Limit_Angle_X=(list[0].Limit_AngleLow.X).ToString()+","+(list[0].Limit_AngleHigh.X).ToString();
			string Limit_Angle_Y=(list[0].Limit_AngleLow.Y).ToString()+","+(list[0].Limit_AngleHigh.Y).ToString();
			string Limit_Angle_Z=(list[0].Limit_AngleLow.Z).ToString()+","+(list[0].Limit_AngleHigh.Z).ToString();
			//弹簧移动
			string SpringConst_Move=(list[0].SpringConst_Move.X).ToString()+","+(list[0].SpringConst_Move.Y).ToString()+","+(list[0].SpringConst_Move.Z).ToString(); 
			//弹簧旋转
			string SpringConst_Rotate=(list[0].SpringConst_Rotate.X).ToString()+","+(list[0].SpringConst_Rotate.Y).ToString()+","+(list[0].SpringConst_Rotate.Z).ToString();
			
			label10.Text=name+":"+index.ToString()+" | "+Ai+":"+BodyA+"--"+Bi+":"+BodyB;
			
			label11.Text="位置:"+pos;
			label12.Text="旋转:"+rot;
			
			label13.Text="限制X:"+Limit_Move_X+":"+Limit_Angle_X;
			label14.Text="限制Y:"+Limit_Move_Y+":"+Limit_Angle_Y;
			label15.Text="限制Z:"+Limit_Move_Z+":"+Limit_Angle_Z;
			
			label16.Text="弹簧移动:"+SpringConst_Move;
			label17.Text="弹簧旋转:"+SpringConst_Rotate;
			
			this.Update();
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("http://kkhk22.seesaa.net/");  
		}
		void Button6Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://wiki.mmdxyz.cn/doku.php");  
		}		
		void Button7Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("http://tieba.baidu.com/f?kw=mikumikudance");  
		}
		void LinkLabel1LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start("http://walogia.ucoz.club/donate.html");  
		}
		//---------------------------------------------------------//
		
		void Label1MouseDown(object sender, MouseEventArgs e)
		{
			string[] k=label1.Text.Split(':');
			if (e.Button == MouseButtons.Left)
			{
				Clipboard.SetDataObject(k[0]);
			}
			else
			{
				Clipboard.SetDataObject(k[1]);
			}
		}
		
		void Label2Click(object sender, EventArgs e)
		{
			string[] k=label2.Text.Split(':');
			Clipboard.SetDataObject(k[1]);
		}
		
		void Label3MouseDown(object sender, MouseEventArgs e)
		{
			string[] k=label3.Text.Split(':');
			if (e.Button == MouseButtons.Left)
			{
				Clipboard.SetDataObject(k[0]);
			}
			else
			{
				Clipboard.SetDataObject(k[1]);
			}
		}
				
	    void Label4MouseDown(object sender, MouseEventArgs e)
		{
			string[] k=label4.Text.Split(':');
			if (e.Button == MouseButtons.Left)
			{
				Clipboard.SetDataObject(k[0]);
			}
			else
			{
				Clipboard.SetDataObject(k[1]);
			}
		}
    	    
	    void Label5Click(object sender, EventArgs e)
		{
			Clipboard.SetDataObject(textBox1.Text);
		}
	    void Label6Click(object sender, EventArgs e)
		{
			Clipboard.SetDataObject(textBox2.Text);
		}
	   void Label7Click(object sender, EventArgs e)
		{
			Clipboard.SetDataObject(textBox3.Text);
		}
	    void Label8Click(object sender, EventArgs e)
		{
			Clipboard.SetDataObject(textBox4.Text);
		}
	    void Label9Click(object sender, EventArgs e)
		{
			Clipboard.SetDataObject(textBox5.Text);
		}
	   //************** 
	    
		void Label11Click(object sender, EventArgs e)
		{
			string[] k=label11.Text.Split(':');
			Clipboard.SetDataObject(k[1]);
		}	
		void Label12Click(object sender, EventArgs e)
		{
			string[] k=label12.Text.Split(':');
			Clipboard.SetDataObject(k[1]);
		}	
		
		void Label13MouseDown(object sender, MouseEventArgs e)
		{
			string[] k=label13.Text.Split(':');
			if (e.Button == MouseButtons.Left)
			{
				Clipboard.SetDataObject(k[1]);
			}
			else
			{
				Clipboard.SetDataObject(k[2]);
			}
		}
				
	    void Label14MouseDown(object sender, MouseEventArgs e)
		{
			string[] k=label14.Text.Split(':');
			if (e.Button == MouseButtons.Left)
			{
				Clipboard.SetDataObject(k[1]);
			}
			else
			{
				Clipboard.SetDataObject(k[2]);
			}
		}
	     void Label15MouseDown(object sender, MouseEventArgs e)
		{
			string[] k=label15.Text.Split(':');
			if (e.Button == MouseButtons.Left)
			{
				Clipboard.SetDataObject(k[1]);
			}
			else
			{
				Clipboard.SetDataObject(k[2]);
			}
		}
	     //******************
		void Label16Click(object sender, EventArgs e)
		{
			string[] k=label16.Text.Split(':');
			Clipboard.SetDataObject(k[1]);
		}	
		void Label17Click(object sender, EventArgs e)
		{
			string[] k=label17.Text.Split(':');
			Clipboard.SetDataObject(k[1]);
		}		
//**************************************
		private void InitializeValue()
		{
			try
			{
				this.host = this.args.Host;;
				this.connect = this.host.Connector;
				this.PMX = this.connect.Pmx.GetCurrentState();
				this.PMDView = this.connect.View.PMDView;
				this.PMXView = this.connect.View.PmxView;
				this.builder = this.host.Builder;
				this.bd = this.host.Builder.SC;
			}
			catch
			{
				MessageBox.Show("值初始化失败");
			}
		}
		
			/// <summary>
	        /// モデル・画面を更新します。
	        /// </summary>
	        public void Update()
	        {
	            this.connect.Pmx.Update(this.PMX);
	            this.connect.Form.UpdateList(PEPlugin.Pmd.UpdateObject.All);
	            this.connect.View.PMDView.UpdateModel();
	            this.connect.View.PMDView.UpdateView();
	        }
		
        //*******************************函数开始*********************//
        
        /// <summary>
        /// 获取頂点Index
        /// </summary>
        /// <param name="Vertex"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public int GetVertexIndex(IPXVertex Vertex, int e = 0)
        {
            for (int i = 0; i < this.PMX.Vertex.Count; i++)
            {
                if (this.PMX.Vertex[i] == Vertex)
                {
                    return i;
                }
            }
            if (e == 0)
            {
                return -1;
            }
            else
            {
                MessageBox.Show("未获取顶点Index");
                return -1;
            }
        }
        /// <summary>
        /// PMXViewで選択した頂点のリストを返します。
        /// </summary>
        /// <returns></returns>
        public List<IPXVertex> GetSelectedVertexList()
        {
            int[] SelectedItem = this.PMDView.GetSelectedVertexIndices();
            if (SelectedItem.Length == 0)
            {
                MessageBox.Show("没有选中顶点");
            }
            List<IPXVertex> RetList = new List<IPXVertex>();
            for (int i = 0; i < SelectedItem.Length; i++)
            {
                RetList.Add(this.PMX.Vertex[SelectedItem[i]]);
            }
            return RetList;
        }
        
        			//-----------骨骼部分-------------//
        			
        /// <summary>
        /// ボーンIndexを返す関数です。
        /// </summary>
        /// <param name="BoneName"></param>
        /// <returns></returns>
        public int GetBoneIndex(string BoneName, int e = 0)
        {
            for (int i = 0; i < this.PMX.Bone.Count; i++)
            {
                if (this.PMX.Bone[i].Name == BoneName) { return i; }
            }
            if (e == 0)
            {
                return -1;
            }
            else
            {
                 MessageBox.Show(BoneName + "骨骼不存在");
                 return -1;
            }
        }
        
        /// <summary>
        /// PMXViewで選択したボーンのリストを返します。
        /// </summary>
        /// <returns></returns>
        public List<IPXBone> GetSelectdeBoneList()
        {
            int[] SelectedItem = this.PMDView.GetSelectedBoneIndices();
            if (SelectedItem.Length == 0)
            {
                MessageBox.Show("没有选中骨骼");
            }
            List<IPXBone> RetList = new List<IPXBone>();
            for (int i = 0; i < SelectedItem.Length; i++)
            {
                RetList.Add(this.PMX.Bone[SelectedItem[i]]);
            }
            return RetList;
        }
        
        			//-------------------刚体-----------------//
        /// <summary>
        /// 剛体Indexを取得する。
        /// </summary>
        /// <param name="BodyName"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public int GetBodyIndex(string BodyName, int e = 0)
        {
            for (int i = 0; i < this.PMX.Body.Count; i++)
            {
                if (this.PMX.Body[i].Name == BodyName)
                {
                    return i;
                }
            }
            if (e == 0)
            {
                return -1;
            }
            else
            {
                MessageBox.Show("未获取刚体Index");
                return -1;
            }
        }
        
        /// <summary>
        /// PMXViewで選択した剛体のリストを返します。
        /// </summary>
        /// <returns></returns>
        public List<IPXBody> GetSelectedBodyList()
        {
            int[] SelectedItem = this.PMDView.GetSelectedBodyIndices();
            if (SelectedItem.Length == 0)
            {
                MessageBox.Show("没有选中刚体");
            }
            List<IPXBody> RetList = new List<IPXBody>();
            for (int i = 0; i < SelectedItem.Length; i++)
            {
                RetList.Add(this.PMX.Body[SelectedItem[i]]);
            }
            return RetList;
        }
        
        
        			//----------------Joint部分------------//
        /// <summary>
        /// JointIndexを取得する。
        /// </summary>
        /// <param name="JointName"></param>
        /// <param name="e"></param>
        /// <returns></returns>
        public int GetJointIndex(string JointName, int e = 0)
        {
            for (int i = 0; i < this.PMX.Joint.Count; i++)
            {
                if (this.PMX.Joint[i].Name == JointName)
                {
                    return i;
                }
            }
            if (e == 0)
            {
                return -1;
            }
            else
            {
                throw new System.Exception("Indexを取得できません。");
            }
        }
        /// <summary>
        /// PMXViewで選択したJointのリストを返します。
        /// </summary>
        /// <returns></returns>
        public List<IPXJoint> GetSelectedJointList()
        {
            int[] SelectedItem = this.PMDView.GetSelectedJointIndices();
            if (SelectedItem.Length == 0)
            {
                throw new System.Exception("Jointを選択していません。");
            }
            List<IPXJoint> RetList = new List<IPXJoint>();
            for (int i = 0; i < SelectedItem.Length; i++)
            {
                RetList.Add(this.PMX.Joint[SelectedItem[i]]);
            }
            return RetList;
        }
        //********************函数结束*******************************//
    }
}
