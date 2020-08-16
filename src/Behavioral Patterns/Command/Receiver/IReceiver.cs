using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Receiver
{
    public interface IReceiver
    {

        /// <summary>
        /// 这里是举个例子，实际使用中，可能会使用参数
        /// </summary>
        void ExcuteOpeation();

        /// <summary>
        /// 回滚
        /// 这里是举个例子，实际使用中，可能会使用参数
        /// </summary>
        void Rollback();

    }
}
