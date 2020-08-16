using System;
using ChainOfResp.Handlers;

namespace ChainOfResp
{
    public sealed class TestClient
    {

        public void Main()
        {
            /***
             * 这里是为了简单方便，才这样使用的。
             * 总的处理流程需要根据实际需要进行变化，
             * 可能单独一项业务需要指定的处理流程。
             * 例如：
             *     处理A业务，处理流程为：FirstHandler --》ThreeHandler
             *     处理B业务，处理流程为：SecondHandler --》ThreeHandler
             *     。。。。。。。。。。。
             * 这个时候，建议为每一个业务（A/B/C/D......）设置一个方法或者类
             */
            IHandler handler1 = new FirstHandler();
            IHandler handler2 = new SecondHandler();
            IHandler handler3 = new ThreeHandler();
            handler1.SetNextHandler(handler2);
            handler2.SetNextHandler(handler3);

            for (int i = 0; i < 5; i++)
            {
                handler1.Handle();
            }



        }

    }
}
