using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResp.Handlers
{
    /// <summary>
    /// 处理人基类
    /// </summary>
    public abstract class BaseHandler : IHandler
    {

        /**
         * 处理人：
         *     核心由三部分：处理条件、处理方法、设定下一个处理人
         *
         * 公共处理逻辑：
         *     当达到处理条件时，由当前处理人处理，否则由下一个处理人处理；
         *     如没有下一个处理人，则总的处理流程完成/结束
         *
         */


        /// <summary>
        /// 判断是否符合处理条件
        /// </summary>
        protected abstract bool IsProcess();

        /// <summary>
        /// 下一个处理人
        /// </summary>
        protected IHandler m_nextHandler = null;
        public void SetNextHandler(IHandler handler)
        {
            m_nextHandler = handler;
        }

        /// <summary>
        /// 处理请求
        /// </summary>
        protected abstract void ProcessRequest();

        public virtual void Handle()
        {
            //1. 是否符合当前处理条件
            if (IsProcess())
            {
                ProcessRequest();
            }
            else
            {
                m_nextHandler?.Handle();
            }
        }

    }
}
