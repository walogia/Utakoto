﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PEPlugin;
using PEPlugin.Form;
using PEPlugin.Pmd;
using PEPlugin.Pmx;
using PEPlugin.SDX;
using PEPlugin.View;

namespace embed
{
    public partial class Class1 : IPEPlugin, IPEPluginOption, IDisposable
    {

	       
        /// <summary>
        /// 保存pe运行参数
        /// </summary>
        public PEPlugin.IPERunArgs peArgs;


        /// <summary>
        /// 获取对这个插件的描述
        /// </summary>
        public string Description
        {
            get { return "嵌入式"; }
        }

        /// <summary>
        /// 获取这个插件的名称
        /// </summary>
        public string Name
        {
            get { return "呗言"; }
        }

        /// <summary>
        /// 获取启动的选项
        /// </summary>
        public PEPlugin.IPEPluginOption Option
        {
            get { return this; }
        }



        /// <summary>
        /// 这个方法在插件启动时被调用。
        /// </summary>
        /// <param name="args"></param>
        public void Run(PEPlugin.IPERunArgs args)
        {
            
			
            peArgs = args;//保存这个IPERunArgs
		

            Form mainForm = peArgs.Host.Connector.Form as Form;//主窗口
			
            SetHostArgs(args);
            addTabPage(mainForm);

        }



        /// <summary>
        /// 获取对这个插件版本的描述
        /// </summary>
        public string Version
        {
            get { return "1.0"; }
        }

        /// <summary>
        /// 这个插件被销毁时被调用
        /// </summary>
        public void Dispose()
        {

        }

        /// <summary>
        /// 获取一个布尔值，表示插件是否随PE一起启动。取值为true或false
        /// </summary>
        public bool Bootup
        {
            get { return true; }
        }

        /// <summary>
        /// 获取一个布尔值，表示插件是否应该有菜单项。取值为true或false
        /// </summary>
        public bool RegisterMenu
        {
            get { return false; }
        }

        /// <summary>
        /// 获取一个字符串，表示插件菜单项上的文本。
        /// </summary>
        public string RegisterMenuText
        {
            get { return "呗言"; }
        }
    }
}
