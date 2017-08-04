using System;

namespace CSharpReview.SerializeTest
{
    internal class MySerializatize
    {
        public void Test()
        {
            // .net core 已经移除对二进制序列化的支持，其他包括
            // 数据契约序列化、XML序列化、JSON.NET以及protobuf-net；
        }

    }

    [Serializable]
    public class SerTest
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }

}
