using Microsoft.Extensions.Options;
using SixLabors.ImageSharp.Web;
using SixLabors.ImageSharp.Web.Caching;
using SixLabors.ImageSharp.Web.Resolvers;

namespace Umbraco.StorageProviders.AmazonS3.Imaging
{
    public class AmazonS3FileSystemImageCache : IImageCache
    {
        public AmazonS3FileSystemImageCache()
        {

        }

        public Task<IImageCacheResolver> GetAsync(string key) => throw new NotImplementedException();
        public Task SetAsync(string key, Stream stream, ImageCacheMetadata metadata) => throw new NotImplementedException();
    }
}
