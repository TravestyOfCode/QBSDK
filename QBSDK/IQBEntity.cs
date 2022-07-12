using System;

namespace QBSDK
{
    public interface IQBEntity
    {
        public Type AddType { get; }

        public Type ModType { get; }

        public Type DelType { get; }
    }
}
