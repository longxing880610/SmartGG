using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace SmartGG
{
    public partial class FormMain : Form
    {
        public const Int32 MSG_TYPE_SCRIPT_COMPLETE = 1;
        public const Int32 MSG_TYPE_ALL_SCRIPTS_COMPLETE = MSG_TYPE_SCRIPT_COMPLETE + 1;
        public const Int32 MSG_TYPE_SCRIPT_PROCESSING = MSG_TYPE_ALL_SCRIPTS_COMPLETE + 1;
        public const Int32 MSG_TYPE_DISPLAY_TEXT = MSG_TYPE_SCRIPT_PROCESSING + 1;
        public const Int32 MSG_TYPE_DISPLAY_STATUS = MSG_TYPE_DISPLAY_TEXT + 1;
        public const Int32 MSG_TYPE_DISPLAY_SCRIPT_NAME = MSG_TYPE_DISPLAY_STATUS + 1;
        public const Int32 MSG_TYPE_DISPLAY_MSG = MSG_TYPE_DISPLAY_SCRIPT_NAME + 1;
        public const Int32 MSG_TYPE_GET_CONTROL = MSG_TYPE_DISPLAY_MSG + 1;
        public const Int32 MSG_TYPE_SET_CONTROL = MSG_TYPE_GET_CONTROL + 1;
        public const Int32 MSG_TYPE_SET_PROGRESS_FILE = MSG_TYPE_SET_CONTROL + 1;
        public const Int32 MSG_TYPE_SET_PROGRESS_FILES = MSG_TYPE_SET_PROGRESS_FILE + 1;
        public const Int32 MSG_TYPE_PAUSE = MSG_TYPE_SET_PROGRESS_FILES + 1;
        public const Int32 MSG_TYPE_BREAK = MSG_TYPE_PAUSE + 1;   // 10


        private delegate object Delegate_UI_Access(Int32 msgType, object param0, object param1);

        private Delegate_UI_Access m_UI_Access;

        private FormMain m_ownObj;

        private SmartGG m_smartGG;

        private void InstallFormMainUI()
        {
            m_ownObj = this;

            m_UI_Access = new Delegate_UI_Access(UI_Access);


            m_smartGG = new SmartGG();

        }
        private void UninstallFormMainUI()
        {
            m_ownObj = null;

        }
        /// <summary>
        /// 显示日志
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="newLine"></param>
        private void DisplayLog(String msg, Int32 newLine)
        {
            StringBuilder strBuilder = new StringBuilder(msg);

            //isDisplayLog = true;
            while (newLine > 0)
            {
                strBuilder.AppendLine();
                newLine--;
            }
            //m_curRTBOX_OutPut.Focus( );
            richTextBox_Output.AppendText(strBuilder.ToString());
            //m_curRTBOX_OutPut.Select(rtbox_AdpuLog.TextLength-1, 0);
            //m_curRTBOX_OutPut.AppendText("");
            richTextBox_Output.ScrollToCaret();//.Select(rtbox_AdpuLog.TextLength, 0);

            //m_apduLog.WriteToLog(strBuilder.ToString());

            //isDisplayLog = false;
        }

        #region 界面事件处理

        private void ProcUserInput()
        {
            string input = richTextBox_Input.Text;

            DisplayLog("雅平说:" + input, 1);

            StringBuilder output = m_smartGG.ProcUserInput(input);

            DisplayLog("龙回复:" + output.ToString(), 1);
        }

        #endregion

        #region 界面操作函数


        public object UI_Access(Int32 msgType)
        {
            return UI_Access(msgType, null, null);
        }
        public object UI_Access(Int32 msgType, object param0)
        {
            return UI_Access(msgType, param0, null);
        }
        /*public object UI_Access(Int32 msgType, object param0, object param1)
        {
            return UI_Access(msgType, param0, param1);
        }*/
        /// <summary>
        /// 界面访问
        /// </summary>
        /// <param name="msgType"></param>
        /// <param name="param"></param>
        public object UI_Access(Int32 msgType, object param0, object param1)
        {

            if (this.InvokeRequired)
            {
                if (m_ownObj == null)
                {
                    return null;
                }
                return m_ownObj.Invoke(m_UI_Access, msgType, param0, param1);
            }
            // 处理各种消息
            switch (msgType)
            {
                case MSG_TYPE_DISPLAY_TEXT:
                    if (param0 is String)
                    {
                        StringBuilder strBuilder = new StringBuilder((String)param0);
                        Int32 newLine;

                        if (param1 is Int32)
                        {
                            newLine = (Int32)param1;
                        }
                        else
                        {
                            newLine = 1;
                        }

                        while (newLine > 0)
                        {
                            strBuilder.AppendLine();
                            newLine--;
                        }

                        DisplayLog(strBuilder.ToString(), 1);
                    }
                    break;
                default:
                    break;
            }
            return null;
        }

        #endregion
    }
}
