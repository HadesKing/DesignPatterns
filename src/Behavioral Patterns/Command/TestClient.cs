using System;
using System.Collections.Generic;
using System.Text;
using Command.Commands;

namespace Command
{
    public sealed class TestClient
    {

        public void Main()
        {
            /**
             * 如果使用依赖注入，则可以进行该例子进行变更
             */

            ICommand command = new ConcreteCommand();
            /**
             * 解耦：
             *     如这里需要执行其他命令，只需要变更上一行代码
             */
            Invoker invoker = new Invoker(command);
            invoker.ExcuteCommand();

            invoker.Rollback();

        }

    }
}
