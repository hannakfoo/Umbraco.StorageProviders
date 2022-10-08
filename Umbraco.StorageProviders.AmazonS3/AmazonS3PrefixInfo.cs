using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Umbraco.StorageProviders.AmazonS3
{
    public class AmazonS3PrefixInfo : IFileInfo
    {
        public bool Exists => true;

        public bool IsDirectory => throw new NotImplementedException();

        public DateTimeOffset LastModified => default;

        public long Length => throw new NotImplementedException();

        public string Name => throw new NotImplementedException();

        public string PhysicalPath => throw new NotImplementedException();

        public Stream CreateReadStream() => throw new NotImplementedException();
    }
}
